using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using Lucero.Modelos;

namespace Lucero.Servicios
{
    /// <summary>
    /// Cliente HTTP del API Lucero. Envía y recibe JSON usando los modelos del escritorio.
    /// La dirección del API se configura en App.config con la clave "LuceroApiUrl".
    /// </summary>
    internal static class ApiClient
    {
        private const string UrlPorDefecto = "http://localhost:5272";
        private const int TiempoLimiteMs = 5000;

        private static readonly JavaScriptSerializer Serializador = new JavaScriptSerializer();

        public static string UrlBase
        {
            get
            {
                string url = ConfigurationManager.AppSettings["LuceroApiUrl"];

                if (string.IsNullOrWhiteSpace(url))
                {
                    return UrlPorDefecto;
                }

                return url.Trim().TrimEnd('/');
            }
        }

        public static bool IniciarSesion(
            string clave,
            string contrasena,
            out Usuario usuario,
            out string mensaje)
        {
            usuario = null;

            Dictionary<string, object> cuerpo = new Dictionary<string, object>();
            cuerpo["clave"] = clave;
            cuerpo["contrasena"] = contrasena;

            Dictionary<string, object> respuesta = Enviar("POST", "/api/auth/login", cuerpo, out mensaje);

            if (respuesta == null)
            {
                return false;
            }

            if (!ObtenerBooleano(respuesta, "exitoso"))
            {
                mensaje = ConstruirMensajeError(respuesta);
                return false;
            }

            Dictionary<string, object> datos = ObtenerObjeto(respuesta, "usuario");

            if (datos == null)
            {
                mensaje = "El servidor no devolvió los datos del usuario.";
                return false;
            }

            string claveRespuesta = ObtenerTexto(datos, "clave");
            string nombre = ObtenerTexto(datos, "nombre");

            usuario = new Usuario(
                string.IsNullOrWhiteSpace(claveRespuesta) ? clave : claveRespuesta,
                contrasena,
                nombre ?? string.Empty);

            mensaje = null;
            return true;
        }

        public static bool GuardarFactura(GuiaFactura guia, out string mensaje)
        {
            Dictionary<string, object> respuesta = Enviar(
                "POST",
                "/api/facturas",
                CrearCuerpoFactura(guia),
                out mensaje);

            if (respuesta == null)
            {
                return false;
            }

            if (!ObtenerBooleano(respuesta, "exitoso"))
            {
                mensaje = ConstruirMensajeError(respuesta);
                return false;
            }

            mensaje = ObtenerTexto(respuesta, "mensaje") ?? "Factura guardada correctamente.";
            return true;
        }

        public static string ObtenerSiguienteFolio(out string mensaje)
        {
            Dictionary<string, object> respuesta = Enviar(
                "GET",
                "/api/facturas/siguiente-folio",
                null,
                out mensaje);

            if (respuesta == null)
            {
                return null;
            }

            string folio = ObtenerTexto(respuesta, "folio");

            if (string.IsNullOrWhiteSpace(folio))
            {
                mensaje = "El servidor no devolvió un folio.";
                return null;
            }

            mensaje = null;
            return folio;
        }

        private static Dictionary<string, object> CrearCuerpoFactura(GuiaFactura guia)
        {
            List<Dictionary<string, object>> detalles = new List<Dictionary<string, object>>();

            if (guia.Detalles != null)
            {
                foreach (DetalleGuia detalle in guia.Detalles)
                {
                    Dictionary<string, object> renglon = new Dictionary<string, object>();
                    renglon["tipo"] = detalle.Tipo.ToString();
                    renglon["numero"] = detalle.Numero;
                    renglon["embalaje"] = detalle.Embalaje;
                    renglon["contenido"] = detalle.Contenido;
                    renglon["peso"] = detalle.Peso;
                    renglon["valorUnitarioPorCuota"] = detalle.ValorUnitarioPorCuota;
                    renglon["retieneIva"] = detalle.RetieneIva;
                    detalles.Add(renglon);
                }
            }

            Dictionary<string, object> cuerpo = new Dictionary<string, object>();
            cuerpo["fecha"] = guia.Fecha.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            cuerpo["folio"] = guia.Folio;
            cuerpo["oficina"] = guia.Oficina.ToString();
            cuerpo["lugar"] = guia.Lugar;
            cuerpo["origen"] = guia.Origen;
            cuerpo["remitente"] = guia.Remitente;
            cuerpo["domicilioRemitente"] = guia.DomicilioRemitente;
            cuerpo["rfcRemitente"] = guia.RfcRemitente;
            cuerpo["seRecogeraEn"] = guia.SeRecogeraEn;
            cuerpo["destino"] = guia.Destino;
            cuerpo["destinatario"] = guia.Destinatario;
            cuerpo["domicilioDestinatario"] = guia.DomicilioDestinatario;
            cuerpo["rfcDestinatario"] = guia.RfcDestinatario;
            cuerpo["seEntregaraEn"] = guia.SeEntregaraEn;
            cuerpo["valorDeclarado"] = guia.ValorDeclarado;
            cuerpo["flete"] = guia.Flete;
            cuerpo["maniobras"] = guia.Maniobras;
            cuerpo["cobroPorSeguro"] = guia.CobroPorSeguro;
            cuerpo["otros"] = guia.Otros;
            cuerpo["alyt"] = guia.Alyt;
            cuerpo["suma"] = guia.Suma;
            cuerpo["retenerIva"] = guia.RetenerIva;
            cuerpo["subtotal"] = guia.Subtotal;
            cuerpo["iva"] = guia.Iva;
            cuerpo["total"] = guia.Total;
            cuerpo["pagado"] = guia.Pagado;
            cuerpo["seguroPagado"] = guia.SeguroPagado;
            cuerpo["observacionesDdf"] = guia.ObservacionesDdf;
            cuerpo["reembarco"] = guia.Reembarco;
            cuerpo["condujo"] = guia.Condujo;
            cuerpo["observaciones"] = guia.Observaciones;
            cuerpo["reembarcarseCon"] = guia.ReembarcarseCon;
            cuerpo["conducira"] = guia.Conducira;
            cuerpo["usuario"] = guia.Usuario;
            cuerpo["detalles"] = detalles;

            return cuerpo;
        }

        private static Dictionary<string, object> Enviar(
            string metodo,
            string ruta,
            object cuerpo,
            out string mensaje)
        {
            mensaje = null;
            string json = cuerpo == null ? null : Serializador.Serialize(cuerpo);

            try
            {
                HttpWebRequest peticion = (HttpWebRequest)WebRequest.Create(UrlBase + ruta);
                peticion.Method = metodo;
                peticion.Accept = "application/json";
                peticion.ContentType = "application/json; charset=utf-8";
                peticion.Timeout = TiempoLimiteMs;
                peticion.ReadWriteTimeout = TiempoLimiteMs;

                if (json != null)
                {
                    byte[] datos = Encoding.UTF8.GetBytes(json);
                    peticion.ContentLength = datos.Length;

                    using (Stream flujo = peticion.GetRequestStream())
                    {
                        flujo.Write(datos, 0, datos.Length);
                    }
                }

                using (WebResponse respuesta = peticion.GetResponse())
                {
                    return LeerJson(respuesta);
                }
            }
            catch (WebException ex)
            {
                Dictionary<string, object> respuestaError = LeerJson(ex.Response);

                if (respuestaError != null)
                {
                    mensaje = ConstruirMensajeError(respuestaError);
                }
                else
                {
                    mensaje = "No se pudo conectar con el servidor. Verifica que el API esté en ejecución.";
                }

                return null;
            }
            catch (Exception)
            {
                mensaje = "No se pudo conectar con el servidor. Verifica que el API esté en ejecución.";
                return null;
            }
        }

        private static Dictionary<string, object> LeerJson(WebResponse respuesta)
        {
            if (respuesta == null)
            {
                return null;
            }

            try
            {
                using (Stream flujo = respuesta.GetResponseStream())
                {
                    if (flujo == null)
                    {
                        return null;
                    }

                    using (StreamReader lector = new StreamReader(flujo, Encoding.UTF8))
                    {
                        string contenido = lector.ReadToEnd();

                        if (string.IsNullOrWhiteSpace(contenido))
                        {
                            return null;
                        }

                        return Serializador.DeserializeObject(contenido) as Dictionary<string, object>;
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        private static string ConstruirMensajeError(Dictionary<string, object> respuesta)
        {
            string mensaje = ObtenerTexto(respuesta, "mensaje");

            if (string.IsNullOrWhiteSpace(mensaje))
            {
                mensaje = "No se pudo completar la operación.";
            }

            Dictionary<string, object> errores = ObtenerObjeto(respuesta, "errores");

            if (errores == null || errores.Count == 0)
            {
                return mensaje;
            }

            List<string> detalles = new List<string>();

            foreach (KeyValuePair<string, object> error in errores)
            {
                object[] valores = error.Value as object[];

                if (valores != null)
                {
                    foreach (object valor in valores)
                    {
                        detalles.Add(Convert.ToString(valor, CultureInfo.CurrentCulture));
                    }
                }
                else if (error.Value != null)
                {
                    detalles.Add(Convert.ToString(error.Value, CultureInfo.CurrentCulture));
                }
            }

            if (detalles.Count > 0)
            {
                mensaje += Environment.NewLine + string.Join(Environment.NewLine, detalles.ToArray());
            }

            return mensaje;
        }

        private static Dictionary<string, object> ObtenerObjeto(
            Dictionary<string, object> origen,
            string clave)
        {
            if (origen == null)
            {
                return null;
            }

            object valor;

            if (!origen.TryGetValue(clave, out valor))
            {
                return null;
            }

            return valor as Dictionary<string, object>;
        }

        private static string ObtenerTexto(Dictionary<string, object> origen, string clave)
        {
            if (origen == null)
            {
                return null;
            }

            object valor;

            if (!origen.TryGetValue(clave, out valor) || valor == null)
            {
                return null;
            }

            return Convert.ToString(valor, CultureInfo.CurrentCulture);
        }

        private static bool ObtenerBooleano(Dictionary<string, object> origen, string clave)
        {
            if (origen == null)
            {
                return false;
            }

            object valor;

            if (!origen.TryGetValue(clave, out valor))
            {
                return false;
            }

            return valor is bool && (bool)valor;
        }
    }
}

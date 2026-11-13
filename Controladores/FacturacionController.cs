using System;
using System.Linq;
using Lucero.Modelos;

namespace Lucero.Controladores
{
    public class FacturacionController
    {
        public const decimal TasaIva = 0.16m;

        public string ObtenerSiguienteFolio()
        {
            int mayor = 0;

            foreach (GuiaFactura guia in RepositorioDatos.Guias)
            {
                if (string.IsNullOrWhiteSpace(guia.Folio))
                {
                    continue;
                }

                string numero = guia.Folio.Trim();
                if (numero.StartsWith("G-", StringComparison.OrdinalIgnoreCase))
                {
                    numero = numero.Substring(2);
                }

                int valor;
                if (int.TryParse(numero, out valor) && valor > mayor)
                {
                    mayor = valor;
                }
            }

            return "G-" + (mayor + 1).ToString("D4");
        }

        public void CalcularTotales(GuiaFactura guia)
        {
            guia.Suma = guia.Flete + guia.Maniobras + guia.CobroPorSeguro + guia.Otros + guia.Alyt;
            guia.Subtotal = guia.Suma;
            guia.Iva = Math.Round(guia.Subtotal * TasaIva, 2);
            guia.Total = guia.Subtotal + guia.Iva - guia.RetenerIva;
        }

        public bool Guardar(GuiaFactura guia, out string mensaje)
        {
            if (guia == null)
            {
                mensaje = "No hay datos para guardar.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(guia.Folio))
            {
                mensaje = "El folio es obligatorio.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(guia.Origen))
            {
                mensaje = "El origen es obligatorio.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(guia.Remitente))
            {
                mensaje = "El remitente es obligatorio.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(guia.Destino))
            {
                mensaje = "El destino es obligatorio.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(guia.Destinatario))
            {
                mensaje = "El destinatario es obligatorio.";
                return false;
            }

            CalcularTotales(guia);

            GuiaFactura existente = RepositorioDatos.Guias.FirstOrDefault(g =>
                string.Equals(g.Folio, guia.Folio, StringComparison.OrdinalIgnoreCase));

            if (existente != null)
            {
                RepositorioDatos.Guias.Remove(existente);
            }

            RepositorioDatos.Guias.Add(guia);
            mensaje = "Guía guardada correctamente.";
            return true;
        }
    }
}

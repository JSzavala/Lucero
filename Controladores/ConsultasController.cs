using System;
using System.Collections.Generic;
using System.Linq;
using Lucero.Modelos;

namespace Lucero.Controladores
{
    public class ConsultasController
    {
        private static readonly string[] Criterios =
        {
            "Folio",
            "Fecha",
            "Remitente",
            "Destinatario",
            "Origen",
            "Destino"
        };

        public string[] ObtenerCriterios()
        {
            return Criterios;
        }

        public IList<GuiaFactura> Buscar(string criterio, string texto)
        {
            IEnumerable<GuiaFactura> guias = RepositorioDatos.Guias;

            if (!string.IsNullOrWhiteSpace(texto))
            {
                string valor = texto.Trim();

                switch (criterio)
                {
                    case "Folio":
                        guias = guias.Where(g => Contiene(g.Folio, valor));
                        break;
                    case "Fecha":
                        guias = guias.Where(g => Contiene(g.Fecha.ToString("dd/MM/yyyy"), valor));
                        break;
                    case "Remitente":
                        guias = guias.Where(g => Contiene(g.Remitente, valor));
                        break;
                    case "Destinatario":
                        guias = guias.Where(g => Contiene(g.Destinatario, valor));
                        break;
                    case "Origen":
                        guias = guias.Where(g => Contiene(g.Origen, valor));
                        break;
                    case "Destino":
                        guias = guias.Where(g => Contiene(g.Destino, valor));
                        break;
                }
            }

            return guias.OrderByDescending(g => g.Fecha).ThenBy(g => g.Folio).ToList();
        }

        private static bool Contiene(string valor, string texto)
        {
            return !string.IsNullOrEmpty(valor) &&
                   valor.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}

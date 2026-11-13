using System.Collections.Generic;
using System.Linq;
using Lucero.Modelos;

namespace Lucero.Controladores
{
    public class ReporteGuiaController
    {
        public IList<GuiaFactura> ObtenerGuias()
        {
            return RepositorioDatos.Guias
                .OrderByDescending(g => g.Fecha)
                .ThenBy(g => g.Folio)
                .ToList();
        }
    }
}

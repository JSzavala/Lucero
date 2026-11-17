using System.Collections.Generic;

namespace Lucero.Modelos
{
    /// <summary>
    /// Almacenamiento en memoria compartido por todos los controladores.
    /// Los usuarios y las facturas se guardan en el API; aquí solo se conservan
    /// las guías de la sesión para las consultas y los reportes.
    /// </summary>
    public static class RepositorioDatos
    {
        public static List<GuiaFactura> Guias { get; } = new List<GuiaFactura>();
    }
}

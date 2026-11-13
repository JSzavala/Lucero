using System.Collections.Generic;

namespace Lucero.Modelos
{
    /// <summary>
    /// Almacenamiento en memoria compartido por todos los controladores.
    /// </summary>
    public static class RepositorioDatos
    {
        public static List<Usuario> Usuarios { get; } = new List<Usuario>
        {
            new Usuario("admin", "admin", "Administrador")
        };

        public static List<GuiaFactura> Guias { get; } = new List<GuiaFactura>();
    }
}

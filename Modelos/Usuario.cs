namespace Lucero.Modelos
{
    public class Usuario
    {
        public string Clave { get; set; }
        public string Contrasena { get; set; }
        public string Nombre { get; set; }

        public Usuario()
        {
        }

        public Usuario(string clave, string contrasena, string nombre)
        {
            Clave = clave;
            Contrasena = contrasena;
            Nombre = nombre;
        }
    }
}

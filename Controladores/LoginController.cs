using Lucero.Modelos;
using Lucero.Servicios;

namespace Lucero.Controladores
{
    public class LoginController
    {
        public Usuario Autenticar(string clave, string contrasena)
        {
            string mensaje;
            return Autenticar(clave, contrasena, out mensaje);
        }

        public Usuario Autenticar(string clave, string contrasena, out string mensaje)
        {
            if (string.IsNullOrWhiteSpace(clave) || string.IsNullOrEmpty(contrasena))
            {
                mensaje = "Clave o contraseña incorrectas.";
                return null;
            }

            Usuario usuario;
            string mensajeApi;

            if (!ApiClient.IniciarSesion(clave.Trim(), contrasena, out usuario, out mensajeApi))
            {
                mensaje = string.IsNullOrWhiteSpace(mensajeApi)
                    ? "Clave o contraseña incorrectas."
                    : mensajeApi;
                return null;
            }

            Sesion.UsuarioActual = usuario;
            mensaje = null;
            return usuario;
        }
    }
}

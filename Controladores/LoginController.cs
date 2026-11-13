using System;
using System.Linq;
using Lucero.Modelos;

namespace Lucero.Controladores
{
    public class LoginController
    {
        public Usuario Autenticar(string clave, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(clave) || string.IsNullOrEmpty(contrasena))
            {
                return null;
            }

            Usuario usuario = RepositorioDatos.Usuarios.FirstOrDefault(u =>
                string.Equals(u.Clave, clave.Trim(), StringComparison.OrdinalIgnoreCase) &&
                u.Contrasena == contrasena);

            if (usuario != null)
            {
                Sesion.UsuarioActual = usuario;
            }

            return usuario;
        }
    }
}

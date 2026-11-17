using System;
using System.Windows.Forms;
using Lucero.Controladores;
using Lucero.Modelos;

namespace Lucero.Vistas
{
    public partial class frmLogin : Form
    {
        private readonly LoginController _loginController = new LoginController();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtClave.MaxLength = 30;
            txtContrasena.MaxLength = 255;
            txtClave.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarCredenciales())
            {
                return;
            }

            string mensaje;
            Usuario usuario = _loginController.Autenticar(txtClave.Text.Trim(), txtContrasena.Text, out mensaje);

            if (usuario == null)
            {
                MessageBox.Show(
                    string.IsNullOrWhiteSpace(mensaje) ? "Clave o contraseña incorrectas." : mensaje,
                    "Iniciar sesión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtContrasena.Clear();
                txtContrasena.Focus();
                return;
            }

            this.Hide();

            using (frmMenuPrincipal menuPrincipal = new frmMenuPrincipal())
            {
                menuPrincipal.ShowDialog();
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarCredenciales()
        {
            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show(
                    "La clave del usuario es obligatoria.",
                    "Iniciar sesión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtClave.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtContrasena.Text))
            {
                MessageBox.Show(
                    "La contraseña es obligatoria.",
                    "Iniciar sesión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtContrasena.Focus();
                return false;
            }

            return true;
        }
    }
}

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
            txtClave.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = _loginController.Autenticar(txtClave.Text, txtContrasena.Text);

            if (usuario == null)
            {
                MessageBox.Show("Clave o contraseña incorrectas.", "Iniciar sesión",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}

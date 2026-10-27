using System;
using System.Windows.Forms;

namespace Lucero.Vistas
{
    public partial class frmLogin : Form
    {
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

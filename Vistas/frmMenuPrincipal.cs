using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lucero.Vistas
{
    public partial class frmMenuPrincipal : Form
    {
        private readonly Color _buttonBaseColor = Color.FromArgb(0, 75, 135);
        private readonly Color _buttonHoverColor = Color.FromArgb(0, 92, 158);

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuButton_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.BackColor = _buttonHoverColor;
            }
        }

        private void MenuButton_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.BackColor = _buttonBaseColor;
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuarios usuarios = new frmUsuarios();
            usuarios.ShowDialog();
            this.Show();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultas consultas = new frmConsultas();
            consultas.ShowDialog();
            this.Show();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFacturacion facturacion = new frmFacturacion();
            facturacion.ShowDialog();
            this.Show();
        }

        private void btnAnexarFact_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnexarFactura anexarFact = new frmAnexarFactura();
            anexarFact.ShowDialog();
            this.Show();
        }

        private void btnReporteGuia_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReporteGuia reporteGuia = new frmReporteGuia();
            reporteGuia.ShowDialog();
            this.Show();
        }

        private void btnFactOtros_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFacturasOtros factOtros = new frmFacturasOtros();
            factOtros.ShowDialog();
            this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

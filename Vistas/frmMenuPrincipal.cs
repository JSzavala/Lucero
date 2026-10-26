using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucero.Vistas
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
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
    }
}

using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Lucero.Controladores;
using Lucero.Modelos;

namespace Lucero.Vistas
{
    public partial class frmReporteGuia : Form
    {
        private readonly ReporteGuiaController _reporteGuiaController = new ReporteGuiaController();

        public frmReporteGuia()
        {
            InitializeComponent();
            this.Load += frmReporteGuia_Load;
        }

        private void frmReporteGuia_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = new BindingList<GuiaFactura>(
                _reporteGuiaController.ObtenerGuias().ToList());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

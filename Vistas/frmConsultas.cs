using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Lucero.Controladores;
using Lucero.Modelos;

namespace Lucero.Vistas
{
    public partial class frmConsultas : Form
    {
        private readonly ConsultasController _consultasController = new ConsultasController();

        public frmConsultas()
        {
            InitializeComponent();
            this.Load += frmConsultas_Load;
            btnBuscar.Click += btnBuscar_Click;
            btnSalir.Click += btnSalir_Click;
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(_consultasController.ObtenerCriterios());

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = new BindingList<GuiaFactura>(
                _consultasController.Buscar(string.Empty, string.Empty).ToList());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = comboBox1.SelectedItem == null ? string.Empty : comboBox1.SelectedItem.ToString();
            dataGridView1.DataSource = new BindingList<GuiaFactura>(
                _consultasController.Buscar(criterio, textBox1.Text).ToList());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

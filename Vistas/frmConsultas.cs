using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Lucero.Controladores;
using Lucero.Modelos;

namespace Lucero.Vistas
{
    public partial class frmConsultas : Form
    {
        private static readonly string[] FormatosFecha =
        {
            "dd/MM/yyyy",
            "d/M/yyyy",
            "dd-MM-yyyy",
            "d-M-yyyy"
        };

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
            string texto = textBox1.Text;

            if (string.Equals(criterio, "Fecha", StringComparison.OrdinalIgnoreCase) &&
                !string.IsNullOrWhiteSpace(texto))
            {
                DateTime fecha;

                if (!TryParseFecha(texto, out fecha))
                {
                    MessageBox.Show(
                        "La fecha debe tener el formato dd/MM/aaaa.",
                        "Consultas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    textBox1.Focus();
                    textBox1.SelectAll();
                    return;
                }

                texto = fecha.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            }

            dataGridView1.DataSource = new BindingList<GuiaFactura>(
                _consultasController.Buscar(criterio, texto).ToList());
        }

        private static bool TryParseFecha(string texto, out DateTime fecha)
        {
            return DateTime.TryParseExact(
                (texto ?? string.Empty).Trim(),
                FormatosFecha,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out fecha);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

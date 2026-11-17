using System;
using System.ComponentModel;
using System.Drawing;
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
            this.DoubleBuffered = true;
            this.Load += frmConsultas_Load;
            btnBuscar.Click += btnBuscar_Click;
            btnMostrarTodos.Click += btnMostrarTodos_Click;
            btnSalir.Click += btnSalir_Click;
            textBox1.KeyDown += textBox1_KeyDown;
            this.KeyDown += frmConsultas_KeyDown;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(_consultasController.ObtenerCriterios());

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }

            dataGridView1.AutoGenerateColumns = false;
            CargarResultados(string.Empty, string.Empty);
            AjustarDisenoResponsive();
        }

        private void frmConsultas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnSalir.PerformClick();
                e.Handled = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
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

            CargarResultados(criterio, texto);
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            CargarResultados(string.Empty, string.Empty);
            textBox1.Focus();
        }

        private void CargarResultados(string criterio, string texto)
        {
            var resultados = _consultasController.Buscar(criterio, texto).ToList();
            dataGridView1.DataSource = new BindingList<GuiaFactura>(resultados);
            lblTotalRegistros.Text = $"📋 {resultados.Count} Guía(s) Encontrada(s)";
            ActualizarDetalleGuia();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count)
            {
                return;
            }

            GuiaFactura guia = dataGridView1.Rows[e.RowIndex].DataBoundItem as GuiaFactura;
            if (guia == null)
            {
                return;
            }

            string colName = dataGridView1.Columns[e.ColumnIndex].Name;

            if (colName == "colModalidad")
            {
                e.Value = guia.Pagado ? "Pagado" : "Por Cobrar";
                e.FormattingApplied = true;
            }
            else if (colName == "colFecha")
            {
                e.Value = guia.Fecha.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                e.FormattingApplied = true;
            }
            else if (colName == "colFlete" || colName == "colIva" || colName == "colTotal")
            {
                decimal monto = 0m;
                if (colName == "colFlete") monto = guia.Flete;
                else if (colName == "colIva") monto = guia.Iva;
                else if (colName == "colTotal") monto = guia.Total;

                e.Value = monto.ToString("N2", CultureInfo.CurrentCulture);
                e.FormattingApplied = true;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarDetalleGuia();
        }

        private void ActualizarDetalleGuia()
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.DataBoundItem == null)
            {
                lblDetalleRecogida.Text = "📦 Recoger en: - | Domicilio: -";
                lblDetalleEntrega.Text = "📍 Entregar en: - | Domicilio: -";
                lblDetalleRuta.Text = "🚛 Chofer Condujo: - | Conducirá: - | Reembarco: -";
                lblDetalleObs.Text = "📝 Observaciones: -";
                lblDetalleUsuario.Text = "👤 Operador: -";
                return;
            }

            GuiaFactura guia = dataGridView1.CurrentRow.DataBoundItem as GuiaFactura;
            if (guia == null)
            {
                return;
            }

            string recogida = string.IsNullOrWhiteSpace(guia.SeRecogeraEn) ? "N/A" : guia.SeRecogeraEn;
            string domRem = string.IsNullOrWhiteSpace(guia.DomicilioRemitente) ? "N/A" : guia.DomicilioRemitente;
            lblDetalleRecogida.Text = $"📦 Recoger en: {recogida}   |   Domicilio Remitente: {domRem}";

            string entrega = string.IsNullOrWhiteSpace(guia.SeEntregaraEn) ? "N/A" : guia.SeEntregaraEn;
            string domDest = string.IsNullOrWhiteSpace(guia.DomicilioDestinatario) ? "N/A" : guia.DomicilioDestinatario;
            lblDetalleEntrega.Text = $"📍 Entregar en: {entrega}   |   Domicilio Destino: {domDest}";

            string condujo = string.IsNullOrWhiteSpace(guia.Condujo) ? "N/A" : guia.Condujo;
            string conducira = string.IsNullOrWhiteSpace(guia.Conducira) ? "N/A" : guia.Conducira;
            string reembarco = string.IsNullOrWhiteSpace(guia.Reembarco) ? "N/A" : guia.Reembarco;
            lblDetalleRuta.Text = $"🚛 Chofer Condujo: {condujo}   |   Conducirá: {conducira}   |   Reembarco: {reembarco}";

            string obs = string.IsNullOrWhiteSpace(guia.Observaciones) ? "Sin observaciones" : guia.Observaciones;
            if (!string.IsNullOrWhiteSpace(guia.ObservacionesDdf))
            {
                obs += $"  [DDF: {guia.ObservacionesDdf}]";
            }
            lblDetalleObs.Text = $"📝 Observaciones: {obs}";

            string usr = string.IsNullOrWhiteSpace(guia.Usuario) ? "Sistema" : guia.Usuario;
            lblDetalleUsuario.Text = $"👤 Registrado por: {usr}";
        }

        private void frmConsultas_Resize(object sender, EventArgs e)
        {
            AjustarDisenoResponsive();
        }

        private void AjustarDisenoResponsive()
        {
            if (this.ClientSize.Width <= 0 || this.ClientSize.Height <= 0)
            {
                return;
            }

            this.SuspendLayout();

            int clientW = Math.Max(980, this.ClientSize.Width);
            int clientH = Math.Max(580, this.ClientSize.Height);
            int margin = 14;
            int usableW = clientW - (margin * 2);

            // 1. Header
            pnlHeader.Location = new Point(margin, 10);
            pnlHeader.Size = new Size(usableW, 58);
            lblTotalRegistros.Location = new Point(pnlHeader.Width - lblTotalRegistros.Width - 12, 14);

            // 2. Filtros
            pnlFiltros.Location = new Point(margin, 74);
            pnlFiltros.Size = new Size(usableW, 50);

            // 3. Área inferior (Detalle y Footer)
            int footerH = 38;
            int detalleH = 105;
            int footerTop = clientH - margin - footerH;
            int detalleTop = footerTop - 8 - detalleH;

            pnlFooter.Location = new Point(margin, footerTop);
            pnlFooter.Size = new Size(usableW, footerH);
            btnSalir.Location = new Point(pnlFooter.Width - btnSalir.Width, 2);

            gbDetalle.Location = new Point(margin, detalleTop);
            gbDetalle.Size = new Size(usableW, detalleH);

            // 4. DataGridView
            int gridTop = 130;
            int gridH = Math.Max(160, detalleTop - 8 - gridTop);
            dataGridView1.Location = new Point(margin, gridTop);
            dataGridView1.Size = new Size(usableW, gridH);

            // Ajustar columnas dinámicas de remitente y destinatario para llenar el ancho
            int fixedColsWidth = 85 + 90 + 90 + 100 + 100 + 95 + 80 + 75 + 95 + 25;
            int remainingW = Math.Max(260, usableW - fixedColsWidth);
            int halfRemDest = remainingW / 2;
            colRemitente.Width = halfRemDest;
            colDestinatario.Width = halfRemDest;

            this.ResumeLayout();
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

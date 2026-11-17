using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Lucero.Controladores;
using Lucero.Modelos;

namespace Lucero.Vistas
{
    public partial class frmReporteGuia : Form
    {
        private readonly ReporteGuiaController _reporteGuiaController = new ReporteGuiaController();
        private IList<GuiaFactura> _todasLasGuias = new List<GuiaFactura>();

        public frmReporteGuia()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Load += frmReporteGuia_Load;
            this.KeyDown += frmReporteGuia_KeyDown;
            this.Resize += frmReporteGuia_Resize;
            btnSalir.Click += btnSalir_Click;
            btnActualizar.Click += btnActualizar_Click;
            cmbOficinaFiltro.SelectedIndexChanged += cmbOficinaFiltro_SelectedIndexChanged;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        private void frmReporteGuia_Load(object sender, EventArgs e)
        {
            lblFechaEmision.Text = $"📅 MANIFIESTO DE RUTA\r\nFECHA: {DateTime.Today:dd/MM/yyyy}\r\nESTADO: ACTIVO";

            ConfigurarEstilosColumnas();

            dataGridView1.AutoGenerateColumns = false;

            if (cmbOficinaFiltro.Items.Count > 0 && cmbOficinaFiltro.SelectedIndex < 0)
            {
                cmbOficinaFiltro.SelectedIndex = 0;
            }

            CargarDatos();
            AjustarDisenoResponsive();
        }

        private void ConfigurarEstilosColumnas()
        {
            colFolio.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colBultos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colModalidad.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            colValor.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colPeso.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colSeguro.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colFlete.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colIva.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colTotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void CargarDatos()
        {
            _todasLasGuias = _reporteGuiaController.ObtenerGuias() ?? new List<GuiaFactura>();

            IEnumerable<GuiaFactura> filtradas = _todasLasGuias;

            if (cmbOficinaFiltro.SelectedIndex == 1)
            {
                filtradas = filtradas.Where(g => g.Oficina == Oficina.Mexico);
            }
            else if (cmbOficinaFiltro.SelectedIndex == 2)
            {
                filtradas = filtradas.Where(g => g.Oficina == Oficina.Chinconcuac);
            }

            var listaFinal = filtradas.ToList();
            dataGridView1.DataSource = new BindingList<GuiaFactura>(listaFinal);

            CalcularTotales(listaFinal);
        }

        private void CalcularTotales(IList<GuiaFactura> guias)
        {
            int totalGuias = guias.Count;
            int totalBultos = 0;
            decimal totalPeso = 0m;
            decimal totalFlete = 0m;
            decimal granTotal = 0m;

            foreach (var g in guias)
            {
                totalFlete += g.Flete;
                granTotal += g.Total;

                if (g.Detalles != null && g.Detalles.Count > 0)
                {
                    foreach (var d in g.Detalles)
                    {
                        totalPeso += d.Peso;
                        int n;
                        if (int.TryParse(d.Numero, out n))
                        {
                            totalBultos += n;
                        }
                        else
                        {
                            totalBultos += 1;
                        }
                    }
                }
                else
                {
                    totalBultos += 1;
                }
            }

            lblTotalGuias.Text = $"TOTAL GUÍAS\r\n{totalGuias} {(totalGuias == 1 ? "Guía" : "Guías")}";
            lblTotalBultos.Text = $"TOTAL BULTOS\r\n{totalBultos} {(totalBultos == 1 ? "Bulto" : "Bultos")}";
            lblTotalPeso.Text = $"PESO TOTAL\r\n{totalPeso:N0} kg";
            lblTotalFlete.Text = $"SUBTOTAL FLETES\r\n${totalFlete:N2}";
            lblGranTotal.Text = $"GRAN TOTAL: ${granTotal:N2}";
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count)
            {
                return;
            }

            var guia = dataGridView1.Rows[e.RowIndex].DataBoundItem as GuiaFactura;
            if (guia == null)
            {
                return;
            }

            string colName = dataGridView1.Columns[e.ColumnIndex].Name;

            if (colName == "colBultos")
            {
                int bultos = 0;
                if (guia.Detalles != null && guia.Detalles.Count > 0)
                {
                    foreach (var d in guia.Detalles)
                    {
                        int n;
                        if (int.TryParse(d.Numero, out n)) bultos += n;
                        else bultos += 1;
                    }
                }
                else
                {
                    bultos = 1;
                }
                e.Value = bultos.ToString();
                e.FormattingApplied = true;
            }
            else if (colName == "colContenido")
            {
                if (guia.Detalles != null && guia.Detalles.Count > 0)
                {
                    e.Value = string.Join(", ", guia.Detalles.Where(d => !string.IsNullOrWhiteSpace(d.Contenido)).Select(d => d.Contenido));
                }
                else
                {
                    e.Value = "-";
                }
                e.FormattingApplied = true;
            }
            else if (colName == "colValor")
            {
                e.Value = guia.ValorDeclarado > 0 ? guia.ValorDeclarado.ToString("N0", CultureInfo.CurrentCulture) : "0";
                e.FormattingApplied = true;
            }
            else if (colName == "colPeso")
            {
                decimal peso = guia.Detalles != null ? guia.Detalles.Sum(d => d.Peso) : 0m;
                e.Value = peso.ToString("N0", CultureInfo.CurrentCulture);
                e.FormattingApplied = true;
            }
            else if (colName == "colSeguro")
            {
                e.Value = guia.CobroPorSeguro.ToString("N2", CultureInfo.CurrentCulture);
                e.FormattingApplied = true;
            }
            else if (colName == "colModalidad")
            {
                e.Value = guia.Pagado ? "PAGADO" : "POR COBRAR";
                e.FormattingApplied = true;
            }
            else if (colName == "colFlete")
            {
                e.Value = guia.Flete.ToString("N2", CultureInfo.CurrentCulture);
                e.FormattingApplied = true;
            }
            else if (colName == "colIva")
            {
                e.Value = guia.Iva.ToString("N2", CultureInfo.CurrentCulture);
                e.FormattingApplied = true;
            }
            else if (colName == "colTotal")
            {
                e.Value = guia.Total.ToString("N2", CultureInfo.CurrentCulture);
                e.FormattingApplied = true;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void cmbOficinaFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReporteGuia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnSalir.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnActualizar.PerformClick();
                e.Handled = true;
            }
        }

        private void frmReporteGuia_Resize(object sender, EventArgs e)
        {
            AjustarDisenoResponsive();
        }

        private void AjustarDisenoResponsive()
        {
            int padding = 14;
            int fullWidth = this.ClientSize.Width - (padding * 2);
            if (fullWidth < 700) fullWidth = 700;

            // 1. Header
            pnlHeader.Location = new Point(padding, 10);
            pnlHeader.Width = fullWidth;
            lblFechaEmision.Location = new Point(pnlHeader.Width - lblFechaEmision.Width - 14, 14);

            // 2. Filtros
            pnlFiltros.Location = new Point(padding, pnlHeader.Bottom + 6);
            pnlFiltros.Width = fullWidth;
            btnActualizar.Location = new Point(pnlFiltros.Width - btnActualizar.Width - 12, 8);
            cmbOficinaFiltro.Location = new Point(btnActualizar.Left - cmbOficinaFiltro.Width - 10, 11);
            lblFiltroOficina.Location = new Point(cmbOficinaFiltro.Left - lblFiltroOficina.Width - 6, 13);

            // 3. Footer & Totales (anclados abajo)
            pnlFooter.Location = new Point(padding, this.ClientSize.Height - pnlFooter.Height - 10);
            pnlFooter.Width = fullWidth;
            btnSalir.Location = new Point(pnlFooter.Width - btnSalir.Width - 6, 3);

            pnlTotales.Location = new Point(padding, pnlFooter.Top - pnlTotales.Height - 6);
            pnlTotales.Width = fullWidth;

            // Tarjetas KPI
            lblGranTotal.Location = new Point(pnlTotales.Width - lblGranTotal.Width - 10, 6);
            int availableWidth = lblGranTotal.Left - 10;
            int itemWidth = Math.Max(120, availableWidth / 4);
            lblTotalGuias.SetBounds(10, 8, itemWidth - 6, 42);
            lblTotalBultos.SetBounds(10 + itemWidth, 8, itemWidth - 6, 42);
            lblTotalPeso.SetBounds(10 + itemWidth * 2, 8, itemWidth - 6, 42);
            lblTotalFlete.SetBounds(10 + itemWidth * 3, 8, itemWidth - 6, 42);

            // 4. Grid principal
            dataGridView1.Location = new Point(padding, pnlFiltros.Bottom + 6);
            dataGridView1.Width = fullWidth;
            int gridHeight = pnlTotales.Top - dataGridView1.Top - 6;
            if (gridHeight < 150) gridHeight = 150;
            dataGridView1.Height = gridHeight;
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}

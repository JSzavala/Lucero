using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Lucero.Controladores;
using Lucero.Modelos;

namespace Lucero.Vistas
{
    public partial class frmFacturacion : Form
    {
        private readonly FacturacionController _facturacionController = new FacturacionController();
        private readonly BindingList<DetalleGuia> _detalles = new BindingList<DetalleGuia>();

        public frmFacturacion()
        {
            InitializeComponent();
            btnGrabar.Click += btnGrabar_Click;
            btnSalir.Click += btnSalir_Click;
            button1.Click += btnEliminarRenglon_Click;
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFecha.Text))
            {
                txtFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
            }

            if (string.IsNullOrWhiteSpace(txtFolio.Text))
            {
                txtFolio.Text = _facturacionController.ObtenerSiguienteFolio();
            }

            if (Sesion.UsuarioActual != null && string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Text = Sesion.UsuarioActual.Nombre;
            }

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = _detalles;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();

            string mensaje;
            GuiaFactura guia = LeerGuia();

            if (!_facturacionController.Guardar(guia, out mensaje))
            {
                MessageBox.Show(mensaje, "Facturación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(mensaje, "Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtFolio.Text = _facturacionController.ObtenerSiguienteFolio();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarRenglon_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                return;
            }

            int indice = dataGridView1.CurrentRow.Index;
            if (indice >= 0 && indice < _detalles.Count)
            {
                _detalles.RemoveAt(indice);
            }
        }

        private GuiaFactura LeerGuia()
        {
            return new GuiaFactura
            {
                Fecha = ParseFecha(txtFecha.Text),
                Oficina = rbMexico.Checked ? Oficina.Mexico : Oficina.Chinconcuac,
                Lugar = tctLugar.Text.Trim(),
                Folio = txtFolio.Text.Trim(),
                Origen = txtOrigen.Text.Trim(),
                Remitente = txtRemitente.Text.Trim(),
                DomicilioRemitente = txtDomicilioremitente.Text.Trim(),
                RfcRemitente = txtRFC.Text.Trim(),
                SeRecogeraEn = txtSerecogeraen.Text.Trim(),
                Destino = txtDestino.Text.Trim(),
                Destinatario = txtDestinatario.Text.Trim(),
                DomicilioDestinatario = txtDomicilioDestinarario.Text.Trim(),
                RfcDestinatario = txtRFCDestinatario.Text.Trim(),
                SeEntregaraEn = txtSeEntregaraEn.Text.Trim(),
                ValorDeclarado = ParseDecimal(txtValorDeclarado.Text),
                Flete = ParseDecimal(txtFlete.Text),
                Maniobras = ParseDecimal(txtManiobras.Text),
                CobroPorSeguro = ParseDecimal(txtCobroPorSeguro.Text),
                Otros = ParseDecimal(txtOtros.Text),
                Alyt = ParseDecimal(txtALYT.Text),
                RetenerIva = ParseDecimal(txtRetenerIVA.Text),
                Pagado = rbPagado.Checked,
                SeguroPagado = rbSeguroPagado.Checked,
                ObservacionesDdf = txtObservacionesDDF.Text.Trim(),
                Reembarco = txtReembarco.Text.Trim(),
                Condujo = txtCondujo.Text.Trim(),
                Observaciones = txtObservaciones.Text.Trim(),
                ReembarcarseCon = txtReembarcarseCon.Text.Trim(),
                Conducira = txtConducira.Text.Trim(),
                Usuario = txtUsuario.Text.Trim(),
                Detalles = _detalles.ToList()
            };
        }

        private static decimal ParseDecimal(string texto)
        {
            decimal valor;

            if (decimal.TryParse(texto, NumberStyles.Number, CultureInfo.CurrentCulture, out valor))
            {
                return valor;
            }

            if (decimal.TryParse(texto, NumberStyles.Number, CultureInfo.InvariantCulture, out valor))
            {
                return valor;
            }

            return 0m;
        }

        private static DateTime ParseFecha(string texto)
        {
            DateTime fecha;
            return DateTime.TryParse(texto, out fecha) ? fecha : DateTime.Today;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void rbDDF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

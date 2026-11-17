using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Lucero.Controladores;
using Lucero.Modelos;

namespace Lucero.Vistas
{
    public partial class frmFacturacion : Form
    {
        private static readonly string[] FormatosFecha =
        {
            "dd/MM/yyyy",
            "d/M/yyyy",
            "dd-MM-yyyy",
            "d-M-yyyy"
        };

        private static readonly Regex FormatoRfc = new Regex(
            @"^[A-ZÑ&]{3,4}\d{6}[A-Z0-9]{3}$",
            RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);

        private readonly FacturacionController _facturacionController = new FacturacionController();
        private readonly BindingList<DetalleGuia> _detalles = new BindingList<DetalleGuia>();

        public frmFacturacion()
        {
            InitializeComponent();
            btnGrabar.Click += btnGrabar_Click;
            btnSalir.Click += btnSalir_Click;
            button1.Click += btnEliminarRenglon_Click;
            ConfigurarValidaciones();
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFecha.Text))
            {
                txtFecha.Text = DateTime.Today.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
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

            ConfigurarColumnasDetalle();
            RecalcularTotales();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();

            if (!ValidarFormulario())
            {
                return;
            }

            DateTime fecha;
            TryParseFecha(txtFecha.Text, out fecha);

            string mensaje;
            GuiaFactura guia = LeerGuia(fecha);

            if (!_facturacionController.Guardar(guia, out mensaje))
            {
                MessageBox.Show(mensaje, "Facturación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(mensaje, "Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtFolio.Text = _facturacionController.ObtenerSiguienteFolio();
            RecalcularTotales();
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

        private GuiaFactura LeerGuia(DateTime fecha)
        {
            return new GuiaFactura
            {
                Fecha = fecha,
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

        private void ConfigurarValidaciones()
        {
            TextBox[] resultados = { txtSuma, txtSubtotal, txtIVA, txtTotal };

            foreach (TextBox caja in resultados)
            {
                caja.ReadOnly = true;
                caja.TabStop = false;
                caja.BackColor = SystemColors.Control;
            }

            txtUsuario.ReadOnly = true;
            txtUsuario.TabStop = false;
            txtUsuario.BackColor = SystemColors.Control;

            TextBox[] numericos =
            {
                txtValorDeclarado,
                txtFlete,
                txtCobroPorSeguro,
                txtManiobras,
                txtALYT,
                txtOtros,
                txtRetenerIVA,
                txtPeso,
                txtValorUnitarioPorCuota
            };

            foreach (TextBox caja in numericos)
            {
                caja.KeyPress += txtNumerico_KeyPress;
                caja.TextChanged += txtImporte_TextChanged;
            }

            txtFecha.MaxLength = 10;
            txtFolio.MaxLength = 20;
            tctLugar.MaxLength = 100;
            txtOrigen.MaxLength = 100;
            txtRemitente.MaxLength = 150;
            txtDomicilioremitente.MaxLength = 255;
            txtRFC.MaxLength = 20;
            txtSerecogeraen.MaxLength = 255;
            txtDestino.MaxLength = 100;
            txtDestinatario.MaxLength = 150;
            txtDomicilioDestinarario.MaxLength = 255;
            txtRFCDestinatario.MaxLength = 20;
            txtSeEntregaraEn.MaxLength = 255;
            txtReembarco.MaxLength = 255;
            txtCondujo.MaxLength = 255;
            txtReembarcarseCon.MaxLength = 255;
            txtConducira.MaxLength = 255;
            txtUsuario.MaxLength = 100;

            txtNum.MaxLength = 50;
            txtContenido.MaxLength = 150;
            txtEmbalaje.MaxLength = 100;

            dataGridView1.CellValidating += dataGridView1_CellValidating;
            dataGridView1.DataError += dataGridView1_DataError;
        }

        private void ConfigurarColumnasDetalle()
        {
            foreach (DataGridViewColumn columna in dataGridView1.Columns)
            {
                DataGridViewTextBoxColumn texto = columna as DataGridViewTextBoxColumn;

                switch (columna.DataPropertyName)
                {
                    case nameof(DetalleGuia.Numero):
                        if (texto != null)
                        {
                            texto.MaxInputLength = 50;
                        }
                        break;
                    case nameof(DetalleGuia.Contenido):
                        if (texto != null)
                        {
                            texto.MaxInputLength = 150;
                        }
                        break;
                    case nameof(DetalleGuia.Embalaje):
                        if (texto != null)
                        {
                            texto.MaxInputLength = 100;
                        }
                        break;
                    case nameof(DetalleGuia.Importe):
                        columna.ReadOnly = true;
                        columna.DefaultCellStyle.BackColor = SystemColors.Control;
                        break;
                }
            }
        }

        private void RecalcularTotales()
        {
            GuiaFactura guia = new GuiaFactura
            {
                Flete = ParseDecimal(txtFlete.Text),
                Maniobras = ParseDecimal(txtManiobras.Text),
                CobroPorSeguro = ParseDecimal(txtCobroPorSeguro.Text),
                Otros = ParseDecimal(txtOtros.Text),
                Alyt = ParseDecimal(txtALYT.Text),
                RetenerIva = ParseDecimal(txtRetenerIVA.Text)
            };

            _facturacionController.CalcularTotales(guia);

            txtSuma.Text = guia.Suma.ToString("N2", CultureInfo.CurrentCulture);
            txtSubtotal.Text = guia.Subtotal.ToString("N2", CultureInfo.CurrentCulture);
            txtIVA.Text = guia.Iva.ToString("N2", CultureInfo.CurrentCulture);
            txtTotal.Text = guia.Total.ToString("N2", CultureInfo.CurrentCulture);
        }

        private bool ValidarFormulario()
        {
            DateTime fecha;

            if (!TryParseFecha(txtFecha.Text, out fecha))
            {
                return MostrarError("La fecha debe tener el formato dd/MM/aaaa.", txtFecha);
            }

            if (string.IsNullOrWhiteSpace(txtFolio.Text))
            {
                return MostrarError("El folio es obligatorio.", txtFolio);
            }

            if (!rbMexico.Checked && !rbChinconcuac.Checked)
            {
                return MostrarError("Selecciona la oficina: México o Chinconcuac.", rbMexico);
            }

            if (string.IsNullOrWhiteSpace(txtOrigen.Text))
            {
                return MostrarError("El origen es obligatorio.", txtOrigen);
            }

            if (string.IsNullOrWhiteSpace(txtRemitente.Text))
            {
                return MostrarError("El remitente es obligatorio.", txtRemitente);
            }

            if (string.IsNullOrWhiteSpace(txtDestino.Text))
            {
                return MostrarError("El destino es obligatorio.", txtDestino);
            }

            if (string.IsNullOrWhiteSpace(txtDestinatario.Text))
            {
                return MostrarError("El destinatario es obligatorio.", txtDestinatario);
            }

            if (!EsRfcValido(txtRFC.Text))
            {
                return MostrarError("El RFC del remitente no tiene un formato válido.", txtRFC);
            }

            if (!EsRfcValido(txtRFCDestinatario.Text))
            {
                return MostrarError("El RFC del destinatario no tiene un formato válido.", txtRFCDestinatario);
            }

            if (!ValidarImportes())
            {
                return false;
            }

            return ValidarDetalles();
        }

        private bool ValidarImportes()
        {
            TextBox[] campos =
            {
                txtValorDeclarado,
                txtFlete,
                txtCobroPorSeguro,
                txtManiobras,
                txtALYT,
                txtOtros,
                txtRetenerIVA
            };

            foreach (TextBox caja in campos)
            {
                decimal valor;

                if (!TryParseDecimal(caja.Text, out valor))
                {
                    return MostrarError(
                        "Captura un número válido en " + NombreCampo(caja) + ".",
                        caja);
                }

                if (valor < 0m)
                {
                    return MostrarError(
                        "El valor de " + NombreCampo(caja) + " no puede ser negativo.",
                        caja);
                }
            }

            decimal total;

            if (TryParseDecimal(txtTotal.Text, out total) && total < 0m)
            {
                return MostrarError(
                    "El total no puede ser negativo. Revisa la retención de IVA.",
                    txtRetenerIVA);
            }

            return true;
        }

        private bool ValidarDetalles()
        {
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.IsNewRow)
                {
                    continue;
                }

                DetalleGuia detalle = fila.DataBoundItem as DetalleGuia;

                if (detalle == null)
                {
                    continue;
                }

                if (detalle.Peso < 0m)
                {
                    return MostrarError(
                        "El peso del renglón " + (fila.Index + 1) + " no puede ser negativo.",
                        dataGridView1);
                }

                if (detalle.ValorUnitarioPorCuota < 0m)
                {
                    return MostrarError(
                        "El valor unitario del renglón " + (fila.Index + 1) + " no puede ser negativo.",
                        dataGridView1);
                }
            }

            return true;
        }

        private static bool MostrarError(string mensaje, Control control)
        {
            MessageBox.Show(
                mensaje,
                "Facturación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            if (control != null)
            {
                control.Focus();
            }

            return false;
        }

        private void txtNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            TextBox caja = sender as TextBox;

            if (caja == null)
            {
                return;
            }

            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                if (caja.Text.IndexOf('.') >= 0 || caja.Text.IndexOf(',') >= 0)
                {
                    e.Handled = true;
                }

                return;
            }

            e.Handled = true;
        }

        private void txtImporte_TextChanged(object sender, EventArgs e)
        {
            RecalcularTotales();
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                return;
            }

            string propiedad = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;
            string texto = Convert.ToString(e.FormattedValue, CultureInfo.CurrentCulture);

            if (propiedad == nameof(DetalleGuia.Peso) ||
                propiedad == nameof(DetalleGuia.ValorUnitarioPorCuota))
            {
                decimal valor;

                if (!TryParseDecimal(texto, out valor))
                {
                    e.Cancel = true;
                    MessageBox.Show(
                        "Captura un número válido en " +
                        (propiedad == nameof(DetalleGuia.Peso) ? "el peso." : "el valor unitario."),
                        "Facturación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (valor < 0m)
                {
                    e.Cancel = true;
                    MessageBox.Show(
                        (propiedad == nameof(DetalleGuia.Peso)
                            ? "El peso"
                            : "El valor unitario") + " no puede ser negativo.",
                        "Facturación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }

                return;
            }

            if (propiedad != nameof(DetalleGuia.Tipo) || string.IsNullOrWhiteSpace(texto))
            {
                return;
            }

            TipoGuia tipo;

            if (!Enum.TryParse(texto, true, out tipo) || !Enum.IsDefined(typeof(TipoGuia), tipo))
            {
                e.Cancel = true;
                MessageBox.Show(
                    "El tipo del renglón debe ser DDF o LIBRE.",
                    "Facturación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            MessageBox.Show(
                "El valor capturado en el renglón no es válido.",
                "Facturación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private static bool EsRfcValido(string rfc)
        {
            if (string.IsNullOrWhiteSpace(rfc))
            {
                return true;
            }

            return FormatoRfc.IsMatch(rfc.Trim());
        }

        private static string NombreCampo(TextBox caja)
        {
            switch (caja.Name)
            {
                case "txtValorDeclarado":
                    return "valor declarado";
                case "txtFlete":
                    return "flete";
                case "txtCobroPorSeguro":
                    return "cobro por seguro";
                case "txtManiobras":
                    return "maniobras";
                case "txtALYT":
                    return "A.L.Y.T";
                case "txtOtros":
                    return "otros";
                case "txtRetenerIVA":
                    return "retención de IVA";
                case "txtPeso":
                    return "peso";
                case "txtValorUnitarioPorCuota":
                    return "valor unitario por cuota";
                default:
                    return "el campo";
            }
        }

        private static decimal ParseDecimal(string texto)
        {
            decimal valor;
            return TryParseDecimal(texto, out valor) ? valor : 0m;
        }

        private static bool TryParseDecimal(string texto, out decimal valor)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                valor = 0m;
                return true;
            }

            return decimal.TryParse(texto, NumberStyles.Number, CultureInfo.CurrentCulture, out valor)
                || decimal.TryParse(texto, NumberStyles.Number, CultureInfo.InvariantCulture, out valor);
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

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
            this.DoubleBuffered = true;
            btnGrabar.Click += btnGrabar_Click;
            btnSalir.Click += btnSalir_Click;
            button1.Click += btnEliminarRenglon_Click;
            btnAgregarRenglon.Click += btnAgregarRenglon_Click;
            this.KeyDown += frmFacturacion_KeyDown;
            ConfigurarValidaciones();
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFecha.Text))
            {
                txtFecha.Text = DateTime.Today.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            }

            // No se precarga el folio aquí para evitar mostrarlo antes de tiempo o colisionar con registros en CDMX
            txtFolio.Text = string.Empty;

            if (Sesion.UsuarioActual != null && string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Text = Sesion.UsuarioActual.Nombre;
            }

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = _detalles;

            ConfigurarColumnasDetalle();
            RecalcularTotales();
            AjustarDisenoResponsive();
        }

        private void frmFacturacion_Resize(object sender, EventArgs e)
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

            int clientW = Math.Max(1160, this.ClientSize.Width);
            int clientH = Math.Max(670, this.ClientSize.Height);

            int marginX = 14;
            int marginY = 10;
            int gapX = 12;
            int gapY = 8;
            int rightColWidth = 300;

            // 1. Header (Superior)
            int headerH = 58;
            pnlHeader.Location = new Point(marginX, marginY);
            pnlHeader.Size = new Size(clientW - (marginX * 2), headerH);

            int headerW = pnlHeader.Width;
            txtUsuario.Location = new Point(headerW - 125, 26);
            label39.Location = new Point(headerW - 125, 8);

            lblFolioBadge.Location = new Point(headerW - 325, 26);
            label2.Location = new Point(headerW - 325, 8);
            txtFolio.Location = new Point(headerW - 325, 26);

            pnlOficina.Location = new Point(headerW - 530, 5);

            // 2. Remitente y Destinatario (Paralelos)
            int topClientes = marginY + headerH + gapY;
            int clientesH = 154;
            int clientesUsableW = clientW - (marginX * 2) - gapX;
            int mitadW = clientesUsableW / 2;

            gbRemitente.Location = new Point(marginX, topClientes);
            gbRemitente.Size = new Size(mitadW, clientesH);

            gbDestinatario.Location = new Point(marginX + mitadW + gapX, topClientes);
            gbDestinatario.Size = new Size(mitadW, clientesH);

            int inputRowW = Math.Max(180, mitadW - 200);
            txtRemitente.Size = new Size(inputRowW, 23);
            txtDomicilioremitente.Size = new Size(inputRowW, 23);
            txtSerecogeraen.Size = new Size(mitadW - 28, 23);

            txtDestinatario.Size = new Size(inputRowW, 23);
            txtDomicilioDestinarario.Size = new Size(inputRowW, 23);
            txtSeEntregaraEn.Size = new Size(mitadW - 28, 23);

            // 3. Control Operativo y Acciones (Inferior)
            int rutaH = 126;
            int rutaTop = clientH - marginY - rutaH;
            int leftColW = clientW - (marginX * 2) - gapX - rightColWidth;

            // 4. Área Central (Carga y Totales)
            int topCarga = topClientes + clientesH + gapY;
            int cargaH = Math.Max(260, rutaTop - gapY - topCarga);

            gbCarga.Location = new Point(marginX, topCarga);
            gbCarga.Size = new Size(leftColW, cargaH);

            gbTotales.Location = new Point(marginX + leftColW + gapX, topCarga);
            gbTotales.Size = new Size(rightColWidth, cargaH);

            // Ajustar elementos dentro de Carga
            button1.Location = new Point(gbCarga.Width - 14 - button1.Width, 20);
            pnlEntradaRenglon.Location = new Point(14, 52);
            pnlEntradaRenglon.Size = new Size(gbCarga.Width - 28, 52);

            btnAgregarRenglon.Location = new Point(pnlEntradaRenglon.Width - btnAgregarRenglon.Width - 6, 14);

            int quickFixedW = 12 + 115 + 4 + 48 + 4 + 105 + 4;
            int quickRightW = 65 + 4 + 85 + 4 + 95 + 6 + btnAgregarRenglon.Width + 10;
            int contenidoW = Math.Max(160, pnlEntradaRenglon.Width - quickFixedW - quickRightW);
            txtContenido.Size = new Size(contenidoW, 23);

            int nextX = txtContenido.Location.X + contenidoW + 6;
            label15.Location = new Point(nextX, 4);
            txtPeso.Location = new Point(nextX, 20);

            nextX += txtPeso.Width + 6;
            label14.Location = new Point(nextX, 4);
            txtValorUnitarioPorCuota.Location = new Point(nextX, 20);

            nextX += txtValorUnitarioPorCuota.Width + 6;
            label16.Location = new Point(nextX, 4);
            pnlRetIVA.Location = new Point(nextX, 18);

            int gridTop = 110;
            dataGridView1.Location = new Point(14, gridTop);
            dataGridView1.Size = new Size(gbCarga.Width - 28, Math.Max(130, gbCarga.Height - gridTop - 12));

            // Totales
            pnlTotalHighlight.Location = new Point(14, gbTotales.Height - pnlTotalHighlight.Height - 12);
            pnlTotalHighlight.Size = new Size(gbTotales.Width - 28, pnlTotalHighlight.Height);
            label29.Width = pnlTotalHighlight.Width;
            txtTotal.Location = new Point(8, 30);
            txtTotal.Width = pnlTotalHighlight.Width - 16;

            // Ruta y Acciones
            gbRuta.Location = new Point(marginX, rutaTop);
            gbRuta.Size = new Size(leftColW, rutaH);

            pnlAcciones.Location = new Point(marginX + leftColW + gapX, rutaTop);
            pnlAcciones.Size = new Size(rightColWidth, rutaH);

            btnGrabar.Size = new Size(rightColWidth, 64);
            btnSalir.Location = new Point(0, 72);
            btnSalir.Size = new Size(rightColWidth, 44);

            int colRutaW = (gbRuta.Width - 28 - (3 * 8)) / 4;
            txtReembarco.Location = new Point(14, 38);
            txtReembarco.Size = new Size(colRutaW, 23);
            label34.Location = new Point(14, 22);

            int x2 = 14 + colRutaW + 8;
            label37.Location = new Point(x2, 22);
            txtReembarcarseCon.Location = new Point(x2, 38);
            txtReembarcarseCon.Size = new Size(colRutaW, 23);

            int x3 = x2 + colRutaW + 8;
            label35.Location = new Point(x3, 22);
            txtCondujo.Location = new Point(x3, 38);
            txtCondujo.Size = new Size(colRutaW, 23);

            int x4 = x3 + colRutaW + 8;
            label38.Location = new Point(x4, 22);
            txtConducira.Location = new Point(x4, 38);
            txtConducira.Size = new Size(colRutaW, 23);

            int obsW = (gbRuta.Width - 28 - 12) / 2;
            label36.Location = new Point(14, 66);
            txtObservaciones.Location = new Point(14, 82);
            txtObservaciones.Size = new Size(obsW, 36);

            int obs2X = 14 + obsW + 12;
            label33.Location = new Point(obs2X, 66);
            txtObservacionesDDF.Location = new Point(obs2X, 82);
            txtObservacionesDDF.Size = new Size(obsW, 36);

            this.ResumeLayout();
        }

        private void frmFacturacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnGrabar.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnSalir.PerformClick();
                e.Handled = true;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();

            // Asignar el siguiente folio real justo en este instante para evitar colisiones con CDMX
            if (string.IsNullOrWhiteSpace(txtFolio.Text))
            {
                txtFolio.Text = _facturacionController.ObtenerSiguienteFolio();
            }

            if (!ValidarFormulario())
            {
                // Limpiar el folio para no dejarlo congelado si la validación falla
                txtFolio.Text = string.Empty;
                return;
            }

            DateTime fecha;
            TryParseFecha(txtFecha.Text, out fecha);

            string mensaje;
            GuiaFactura guia = LeerGuia(fecha);

            if (!_facturacionController.Guardar(guia, out mensaje))
            {
                // Limpiar el folio para reintentar con uno fresco al corregir
                txtFolio.Text = string.Empty;
                MessageBox.Show(mensaje, "Facturación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(
                $"{mensaje}\n\nFolio asignado: {guia.Folio}",
                "Facturación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Preparar para la siguiente captura sin mostrar folio previo
            txtFolio.Text = string.Empty;
            _detalles.Clear();
            LimpiarCamposDespuesDeGuardar();
            RecalcularTotales();
        }

        private void LimpiarCamposDespuesDeGuardar()
        {
            txtOrigen.Clear();
            txtRemitente.Clear();
            txtRFC.Clear();
            txtDomicilioremitente.Clear();
            txtSerecogeraen.Clear();

            txtDestino.Clear();
            txtDestinatario.Clear();
            txtRFCDestinatario.Clear();
            txtDomicilioDestinarario.Clear();
            txtSeEntregaraEn.Clear();

            txtValorDeclarado.Text = "0.00";
            txtFlete.Text = "0.00";
            txtManiobras.Text = "0.00";
            txtCobroPorSeguro.Text = "0.00";
            txtALYT.Text = "0.00";
            txtOtros.Text = "0.00";
            txtRetenerIVA.Text = "0.00";

            txtReembarco.Clear();
            txtReembarcarseCon.Clear();
            txtCondujo.Clear();
            txtConducira.Clear();
            txtObservaciones.Clear();
            txtObservacionesDDF.Clear();

            txtOrigen.Focus();
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

        private void btnAgregarRenglon_Click(object sender, EventArgs e)
        {
            decimal peso = ParseDecimal(txtPeso.Text);
            decimal cuota = ParseDecimal(txtValorUnitarioPorCuota.Text);
            string contenido = txtContenido.Text.Trim();
            string numero = txtNum.Text.Trim();
            string embalaje = txtEmbalaje.Text.Trim();

            if (string.IsNullOrWhiteSpace(contenido) && peso <= 0m && cuota <= 0m)
            {
                MessageBox.Show(
                    "Ingresa al menos el contenido, peso o cuota del bulto.",
                    "Detalle de Carga",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtContenido.Focus();
                return;
            }

            TipoGuia tipo = rbLibre.Checked ? TipoGuia.Libre : TipoGuia.DDF;

            _detalles.Add(new DetalleGuia
            {
                Tipo = tipo,
                Numero = numero,
                Embalaje = embalaje,
                Contenido = contenido,
                Peso = peso,
                ValorUnitarioPorCuota = cuota,
                RetieneIva = rbSiIVA.Checked
            });

            // Sugerir flete automático si está en 0
            decimal totalRenglones = _detalles.Sum(d => d.Importe);
            if (ParseDecimal(txtFlete.Text) == 0m && totalRenglones > 0m)
            {
                txtFlete.Text = totalRenglones.ToString("0.00", CultureInfo.InvariantCulture);
            }

            txtNum.Clear();
            txtEmbalaje.Clear();
            txtContenido.Clear();
            txtPeso.Clear();
            txtValorUnitarioPorCuota.Clear();
            rbNoiva.Checked = true;
            txtNum.Focus();
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
            }

            txtUsuario.ReadOnly = true;
            txtUsuario.TabStop = false;

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
                    case nameof(DetalleGuia.Tipo):
                        columna.HeaderText = "Tipo";
                        columna.FillWeight = 50;
                        break;
                    case nameof(DetalleGuia.Numero):
                        columna.HeaderText = "Cant.";
                        columna.FillWeight = 45;
                        if (texto != null)
                        {
                            texto.MaxInputLength = 50;
                        }
                        break;
                    case nameof(DetalleGuia.Embalaje):
                        columna.HeaderText = "Embalaje";
                        columna.FillWeight = 75;
                        if (texto != null)
                        {
                            texto.MaxInputLength = 100;
                        }
                        break;
                    case nameof(DetalleGuia.Contenido):
                        columna.HeaderText = "Contenido";
                        columna.FillWeight = 140;
                        if (texto != null)
                        {
                            texto.MaxInputLength = 150;
                        }
                        break;
                    case nameof(DetalleGuia.Peso):
                        columna.HeaderText = "Peso (Kg)";
                        columna.FillWeight = 60;
                        columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        columna.DefaultCellStyle.Format = "N2";
                        break;
                    case nameof(DetalleGuia.ValorUnitarioPorCuota):
                        columna.HeaderText = "Cuota Unit. ($)";
                        columna.FillWeight = 70;
                        columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        columna.DefaultCellStyle.Format = "N2";
                        break;
                    case nameof(DetalleGuia.RetieneIva):
                        columna.HeaderText = "Ret. IVA";
                        columna.FillWeight = 45;
                        break;
                    case nameof(DetalleGuia.Importe):
                        columna.HeaderText = "Importe ($)";
                        columna.FillWeight = 70;
                        columna.ReadOnly = true;
                        columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        columna.DefaultCellStyle.Format = "N2";
                        columna.DefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
                        columna.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
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

            if (control != null && control.Visible)
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

        // Métodos de evento para compatibilidad con firmas previas
        private void label6_Click(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void radioButton3_CheckedChanged(object sender, EventArgs e) { }
        private void label29_Click(object sender, EventArgs e) { }
        private void rbDDF_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton7_CheckedChanged(object sender, EventArgs e) { }
    }
}

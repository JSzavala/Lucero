using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lucero.Vistas
{
    public partial class frmFacturacion : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dgvCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            // Paneles principales
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.tctLugar = new System.Windows.Forms.TextBox();
            this.pnlOficina = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.rbMexico = new System.Windows.Forms.RadioButton();
            this.rbChinconcuac = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFolioBadge = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();

            // Tarjetas Remitente y Destinatario
            this.gbRemitente = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemitente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDomicilioremitente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSerecogeraen = new System.Windows.Forms.TextBox();

            this.gbDestinatario = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRFCDestinatario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDomicilioDestinarario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSeEntregaraEn = new System.Windows.Forms.TextBox();

            // Tarjeta Carga y Mercancía
            this.gbCarga = new System.Windows.Forms.GroupBox();
            this.pnlFleteModalidad = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.rbPorCobrar = new System.Windows.Forms.RadioButton();
            this.rbPagado = new System.Windows.Forms.RadioButton();

            this.pnlSeguro = new System.Windows.Forms.Panel();
            this.label40 = new System.Windows.Forms.Label();
            this.rbSeguroNoPagado = new System.Windows.Forms.RadioButton();
            this.rbSeguroPagado = new System.Windows.Forms.RadioButton();

            this.label22 = new System.Windows.Forms.Label();
            this.txtValorDeclarado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();

            this.pnlEntradaRenglon = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.pnlTipo = new System.Windows.Forms.Panel();
            this.rbDDF = new System.Windows.Forms.RadioButton();
            this.rbLibre = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtEmbalaje = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtValorUnitarioPorCuota = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlRetIVA = new System.Windows.Forms.Panel();
            this.rbNoiva = new System.Windows.Forms.RadioButton();
            this.rbSiIVA = new System.Windows.Forms.RadioButton();
            this.btnAgregarRenglon = new System.Windows.Forms.Button();

            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            // Tarjeta Totales
            this.gbTotales = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtFlete = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtManiobras = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtCobroPorSeguro = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtALYT = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtOtros = new System.Windows.Forms.TextBox();
            this.pnlLineaTotales = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtRetenerIVA = new System.Windows.Forms.TextBox();
            this.pnlTotalHighlight = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();

            // Tarjeta Control de Ruta y Observaciones
            this.gbRuta = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txtReembarco = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.txtReembarcarseCon = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.txtCondujo = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txtConducira = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.txtObservacionesDDF = new System.Windows.Forms.TextBox();

            // Botones de Acción
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();

            // Control no visible para compatibilidad
            this.radioButton1 = new System.Windows.Forms.RadioButton();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlOficina.SuspendLayout();
            this.gbRemitente.SuspendLayout();
            this.gbDestinatario.SuspendLayout();
            this.gbCarga.SuspendLayout();
            this.pnlFleteModalidad.SuspendLayout();
            this.pnlSeguro.SuspendLayout();
            this.pnlEntradaRenglon.SuspendLayout();
            this.pnlTipo.SuspendLayout();
            this.pnlRetIVA.SuspendLayout();
            this.gbTotales.SuspendLayout();
            this.pnlTotalHighlight.SuspendLayout();
            this.gbRuta.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.SuspendLayout();

            // -------------------------------------------------------------
            // pnlHeader (Encabezado superior)
            // -------------------------------------------------------------
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblEmpresa);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.txtFecha);
            this.pnlHeader.Controls.Add(this.lblLugar);
            this.pnlHeader.Controls.Add(this.tctLugar);
            this.pnlHeader.Controls.Add(this.pnlOficina);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.lblFolioBadge);
            this.pnlHeader.Controls.Add(this.txtFolio);
            this.pnlHeader.Controls.Add(this.label39);
            this.pnlHeader.Controls.Add(this.txtUsuario);
            this.pnlHeader.Location = new System.Drawing.Point(16, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1208, 66);
            this.pnlHeader.TabIndex = 0;

            // lblEmpresa
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblEmpresa.ForeColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.lblEmpresa.Location = new System.Drawing.Point(12, 9);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(374, 21);
            this.lblEmpresa.Text = "AUTOTRANSPORTACIONES DE CARGA LUCERO";

            // lblSubtitulo
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSubtitulo.Location = new System.Drawing.Point(13, 34);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(326, 13);
            this.lblSubtitulo.Text = "SERVICIO PÚBLICO FEDERAL • GUÍA DE EMBARQUE Y FACTURACIÓN";

            // label1 (FECHA)
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.label1.Location = new System.Drawing.Point(405, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FECHA";

            // txtFecha
            this.txtFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFecha.Location = new System.Drawing.Point(405, 29);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(95, 23);
            this.txtFecha.TabIndex = 2;

            // lblLugar (LUGAR)
            this.lblLugar.AutoSize = true;
            this.lblLugar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblLugar.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblLugar.Location = new System.Drawing.Point(512, 11);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(126, 13);
            this.lblLugar.TabIndex = 3;
            this.lblLugar.Text = "LUGAR DE EXPEDICIÓN";

            // tctLugar
            this.tctLugar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tctLugar.Location = new System.Drawing.Point(512, 29);
            this.tctLugar.Name = "tctLugar";
            this.tctLugar.Size = new System.Drawing.Size(145, 23);
            this.tctLugar.TabIndex = 4;

            // pnlOficina
            this.pnlOficina.Controls.Add(this.label3);
            this.pnlOficina.Controls.Add(this.rbMexico);
            this.pnlOficina.Controls.Add(this.rbChinconcuac);
            this.pnlOficina.Location = new System.Drawing.Point(670, 7);
            this.pnlOficina.Name = "pnlOficina";
            this.pnlOficina.Size = new System.Drawing.Size(195, 48);
            this.pnlOficina.TabIndex = 5;

            // label3 (OFICINA)
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.label3.Location = new System.Drawing.Point(2, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "OFICINA DE EMISIÓN";

            // rbMexico
            this.rbMexico.AutoSize = true;
            this.rbMexico.Checked = true;
            this.rbMexico.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.rbMexico.Location = new System.Drawing.Point(4, 23);
            this.rbMexico.Name = "rbMexico";
            this.rbMexico.Size = new System.Drawing.Size(65, 19);
            this.rbMexico.TabIndex = 1;
            this.rbMexico.TabStop = true;
            this.rbMexico.Text = "México";
            this.rbMexico.UseVisualStyleBackColor = true;

            // rbChinconcuac
            this.rbChinconcuac.AutoSize = true;
            this.rbChinconcuac.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.rbChinconcuac.Location = new System.Drawing.Point(85, 23);
            this.rbChinconcuac.Name = "rbChinconcuac";
            this.rbChinconcuac.Size = new System.Drawing.Size(95, 19);
            this.rbChinconcuac.TabIndex = 2;
            this.rbChinconcuac.Text = "Chinconcuac";
            this.rbChinconcuac.UseVisualStyleBackColor = true;

            // label2 (FOLIO)
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.label2.Location = new System.Drawing.Point(880, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "FOLIO";

            // lblFolioBadge
            this.lblFolioBadge.BackColor = System.Drawing.Color.FromArgb(239, 246, 255);
            this.lblFolioBadge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFolioBadge.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblFolioBadge.ForeColor = System.Drawing.Color.FromArgb(29, 78, 216);
            this.lblFolioBadge.Location = new System.Drawing.Point(880, 29);
            this.lblFolioBadge.Name = "lblFolioBadge";
            this.lblFolioBadge.Size = new System.Drawing.Size(185, 23);
            this.lblFolioBadge.TabIndex = 7;
            this.lblFolioBadge.Text = "(Automático al guardar)";
            this.lblFolioBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // txtFolio (Oculto para asignar en backend al guardar sin causar colisión)
            this.txtFolio.Location = new System.Drawing.Point(880, 29);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(20, 20);
            this.txtFolio.TabIndex = 8;
            this.txtFolio.Visible = false;

            // label39 (USUARIO)
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label39.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.label39.Location = new System.Drawing.Point(1078, 11);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(56, 13);
            this.label39.TabIndex = 9;
            this.label39.Text = "USUARIO";

            // txtUsuario
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtUsuario.Location = new System.Drawing.Point(1078, 29);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(115, 23);
            this.txtUsuario.TabIndex = 10;

            // -------------------------------------------------------------
            // gbRemitente (Tarjeta Remitente - Origen)
            // -------------------------------------------------------------
            this.gbRemitente.BackColor = System.Drawing.Color.White;
            this.gbRemitente.Controls.Add(this.label4);
            this.gbRemitente.Controls.Add(this.txtOrigen);
            this.gbRemitente.Controls.Add(this.label5);
            this.gbRemitente.Controls.Add(this.txtRemitente);
            this.gbRemitente.Controls.Add(this.label6);
            this.gbRemitente.Controls.Add(this.txtRFC);
            this.gbRemitente.Controls.Add(this.label8);
            this.gbRemitente.Controls.Add(this.txtDomicilioremitente);
            this.gbRemitente.Controls.Add(this.label7);
            this.gbRemitente.Controls.Add(this.txtSerecogeraen);
            this.gbRemitente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbRemitente.ForeColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.gbRemitente.Location = new System.Drawing.Point(16, 84);
            this.gbRemitente.Name = "gbRemitente";
            this.gbRemitente.Size = new System.Drawing.Size(596, 178);
            this.gbRemitente.TabIndex = 1;
            this.gbRemitente.TabStop = false;
            this.gbRemitente.Text = "  DATOS DEL REMITENTE (ORIGEN)  ";

            // label4 (Origen)
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label4.Location = new System.Drawing.Point(14, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Origen *";

            // txtOrigen
            this.txtOrigen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOrigen.Location = new System.Drawing.Point(14, 42);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(170, 23);
            this.txtOrigen.TabIndex = 1;

            // label5 (Remitente)
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label5.Location = new System.Drawing.Point(195, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Remitente / Razón Social *";

            // txtRemitente
            this.txtRemitente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRemitente.Location = new System.Drawing.Point(195, 42);
            this.txtRemitente.Name = "txtRemitente";
            this.txtRemitente.Size = new System.Drawing.Size(385, 23);
            this.txtRemitente.TabIndex = 3;

            // label6 (RFC)
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label6.Location = new System.Drawing.Point(14, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "R.F.C.";

            // txtRFC
            this.txtRFC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRFC.Location = new System.Drawing.Point(14, 90);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(170, 23);
            this.txtRFC.TabIndex = 5;

            // label8 (Domicilio)
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label8.Location = new System.Drawing.Point(195, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Domicilio:";

            // txtDomicilioremitente
            this.txtDomicilioremitente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDomicilioremitente.Location = new System.Drawing.Point(195, 90);
            this.txtDomicilioremitente.Name = "txtDomicilioremitente";
            this.txtDomicilioremitente.Size = new System.Drawing.Size(385, 23);
            this.txtDomicilioremitente.TabIndex = 7;

            // label7 (Se recogerá en)
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label7.Location = new System.Drawing.Point(14, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Se recogerá en:";

            // txtSerecogeraen
            this.txtSerecogeraen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSerecogeraen.Location = new System.Drawing.Point(14, 139);
            this.txtSerecogeraen.Name = "txtSerecogeraen";
            this.txtSerecogeraen.Size = new System.Drawing.Size(566, 23);
            this.txtSerecogeraen.TabIndex = 9;

            // -------------------------------------------------------------
            // gbDestinatario (Tarjeta Destinatario - Destino)
            // -------------------------------------------------------------
            this.gbDestinatario.BackColor = System.Drawing.Color.White;
            this.gbDestinatario.Controls.Add(this.label13);
            this.gbDestinatario.Controls.Add(this.txtDestino);
            this.gbDestinatario.Controls.Add(this.label12);
            this.gbDestinatario.Controls.Add(this.txtDestinatario);
            this.gbDestinatario.Controls.Add(this.label11);
            this.gbDestinatario.Controls.Add(this.txtRFCDestinatario);
            this.gbDestinatario.Controls.Add(this.label10);
            this.gbDestinatario.Controls.Add(this.txtDomicilioDestinarario);
            this.gbDestinatario.Controls.Add(this.label9);
            this.gbDestinatario.Controls.Add(this.txtSeEntregaraEn);
            this.gbDestinatario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbDestinatario.ForeColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.gbDestinatario.Location = new System.Drawing.Point(628, 84);
            this.gbDestinatario.Name = "gbDestinatario";
            this.gbDestinatario.Size = new System.Drawing.Size(596, 178);
            this.gbDestinatario.TabIndex = 2;
            this.gbDestinatario.TabStop = false;
            this.gbDestinatario.Text = "  DATOS DEL DESTINATARIO (DESTINO)  ";

            // label13 (Destino)
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label13.Location = new System.Drawing.Point(14, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Destino *";

            // txtDestino
            this.txtDestino.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDestino.Location = new System.Drawing.Point(14, 42);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(170, 23);
            this.txtDestino.TabIndex = 1;

            // label12 (Destinatario)
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label12.Location = new System.Drawing.Point(195, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Destinatario / Razón Social *";

            // txtDestinatario
            this.txtDestinatario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDestinatario.Location = new System.Drawing.Point(195, 42);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(385, 23);
            this.txtDestinatario.TabIndex = 3;

            // label11 (RFC Destinatario)
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label11.Location = new System.Drawing.Point(14, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "R.F.C.";

            // txtRFCDestinatario
            this.txtRFCDestinatario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRFCDestinatario.Location = new System.Drawing.Point(14, 90);
            this.txtRFCDestinatario.Name = "txtRFCDestinatario";
            this.txtRFCDestinatario.Size = new System.Drawing.Size(170, 23);
            this.txtRFCDestinatario.TabIndex = 5;

            // label10 (Domicilio)
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label10.Location = new System.Drawing.Point(195, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Domicilio:";

            // txtDomicilioDestinarario
            this.txtDomicilioDestinarario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDomicilioDestinarario.Location = new System.Drawing.Point(195, 90);
            this.txtDomicilioDestinarario.Name = "txtDomicilioDestinarario";
            this.txtDomicilioDestinarario.Size = new System.Drawing.Size(385, 23);
            this.txtDomicilioDestinarario.TabIndex = 7;

            // label9 (Se entregará en)
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label9.Location = new System.Drawing.Point(14, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Se entregará en:";

            // txtSeEntregaraEn
            this.txtSeEntregaraEn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSeEntregaraEn.Location = new System.Drawing.Point(14, 139);
            this.txtSeEntregaraEn.Name = "txtSeEntregaraEn";
            this.txtSeEntregaraEn.Size = new System.Drawing.Size(566, 23);
            this.txtSeEntregaraEn.TabIndex = 9;

            // -------------------------------------------------------------
            // gbCarga (Tarjeta Mercancía y Bultos)
            // -------------------------------------------------------------
            this.gbCarga.BackColor = System.Drawing.Color.White;
            this.gbCarga.Controls.Add(this.pnlFleteModalidad);
            this.gbCarga.Controls.Add(this.pnlSeguro);
            this.gbCarga.Controls.Add(this.label22);
            this.gbCarga.Controls.Add(this.txtValorDeclarado);
            this.gbCarga.Controls.Add(this.button1);
            this.gbCarga.Controls.Add(this.pnlEntradaRenglon);
            this.gbCarga.Controls.Add(this.dataGridView1);
            this.gbCarga.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbCarga.ForeColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.gbCarga.Location = new System.Drawing.Point(16, 268);
            this.gbCarga.Name = "gbCarga";
            this.gbCarga.Size = new System.Drawing.Size(895, 385);
            this.gbCarga.TabIndex = 3;
            this.gbCarga.TabStop = false;
            this.gbCarga.Text = "  MERCANCÍA Y DETALLE DE BULTOS  ";

            // pnlFleteModalidad
            this.pnlFleteModalidad.Controls.Add(this.label21);
            this.pnlFleteModalidad.Controls.Add(this.rbPorCobrar);
            this.pnlFleteModalidad.Controls.Add(this.rbPagado);
            this.pnlFleteModalidad.Location = new System.Drawing.Point(14, 21);
            this.pnlFleteModalidad.Name = "pnlFleteModalidad";
            this.pnlFleteModalidad.Size = new System.Drawing.Size(235, 27);
            this.pnlFleteModalidad.TabIndex = 0;

            // label21 (Flete Modalidad)
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label21.Location = new System.Drawing.Point(2, 6);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "FLETE:";

            // rbPorCobrar
            this.rbPorCobrar.AutoSize = true;
            this.rbPorCobrar.Checked = true;
            this.rbPorCobrar.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.rbPorCobrar.Location = new System.Drawing.Point(47, 4);
            this.rbPorCobrar.Name = "rbPorCobrar";
            this.rbPorCobrar.Size = new System.Drawing.Size(83, 19);
            this.rbPorCobrar.TabIndex = 1;
            this.rbPorCobrar.TabStop = true;
            this.rbPorCobrar.Text = "Por Cobrar";
            this.rbPorCobrar.UseVisualStyleBackColor = true;

            // rbPagado
            this.rbPagado.AutoSize = true;
            this.rbPagado.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.rbPagado.Location = new System.Drawing.Point(145, 4);
            this.rbPagado.Name = "rbPagado";
            this.rbPagado.Size = new System.Drawing.Size(65, 19);
            this.rbPagado.TabIndex = 2;
            this.rbPagado.Text = "Pagado";
            this.rbPagado.UseVisualStyleBackColor = true;

            // pnlSeguro
            this.pnlSeguro.Controls.Add(this.label40);
            this.pnlSeguro.Controls.Add(this.rbSeguroNoPagado);
            this.pnlSeguro.Controls.Add(this.rbSeguroPagado);
            this.pnlSeguro.Location = new System.Drawing.Point(255, 21);
            this.pnlSeguro.Name = "pnlSeguro";
            this.pnlSeguro.Size = new System.Drawing.Size(245, 27);
            this.pnlSeguro.TabIndex = 1;

            // label40 (Seguro)
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label40.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label40.Location = new System.Drawing.Point(2, 6);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(53, 13);
            this.label40.TabIndex = 0;
            this.label40.Text = "SEGURO:";

            // rbSeguroNoPagado
            this.rbSeguroNoPagado.AutoSize = true;
            this.rbSeguroNoPagado.Checked = true;
            this.rbSeguroNoPagado.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.rbSeguroNoPagado.Location = new System.Drawing.Point(60, 4);
            this.rbSeguroNoPagado.Name = "rbSeguroNoPagado";
            this.rbSeguroNoPagado.Size = new System.Drawing.Size(86, 19);
            this.rbSeguroNoPagado.TabIndex = 1;
            this.rbSeguroNoPagado.TabStop = true;
            this.rbSeguroNoPagado.Text = "No Pagado";
            this.rbSeguroNoPagado.UseVisualStyleBackColor = true;

            // rbSeguroPagado
            this.rbSeguroPagado.AutoSize = true;
            this.rbSeguroPagado.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.rbSeguroPagado.Location = new System.Drawing.Point(155, 4);
            this.rbSeguroPagado.Name = "rbSeguroPagado";
            this.rbSeguroPagado.Size = new System.Drawing.Size(65, 19);
            this.rbSeguroPagado.TabIndex = 2;
            this.rbSeguroPagado.Text = "Pagado";
            this.rbSeguroPagado.UseVisualStyleBackColor = true;

            // label22 (Valor Declarado)
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label22.Location = new System.Drawing.Point(510, 27);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(126, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "VALOR DECLARADO ($):";

            // txtValorDeclarado
            this.txtValorDeclarado.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtValorDeclarado.Location = new System.Drawing.Point(640, 23);
            this.txtValorDeclarado.Name = "txtValorDeclarado";
            this.txtValorDeclarado.Size = new System.Drawing.Size(95, 23);
            this.txtValorDeclarado.TabIndex = 3;
            this.txtValorDeclarado.Text = "0.00";
            this.txtValorDeclarado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // button1 (ELIMINAR RENGLON)
            this.button1.BackColor = System.Drawing.Color.FromArgb(254, 242, 242);
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.button1.Location = new System.Drawing.Point(748, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "🗑️ Eliminar Renglón";
            this.button1.UseVisualStyleBackColor = false;

            // -------------------------------------------------------------
            // pnlEntradaRenglon (Barra rápida de captura de bulto)
            // -------------------------------------------------------------
            this.pnlEntradaRenglon.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlEntradaRenglon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEntradaRenglon.Controls.Add(this.label17);
            this.pnlEntradaRenglon.Controls.Add(this.pnlTipo);
            this.pnlEntradaRenglon.Controls.Add(this.label18);
            this.pnlEntradaRenglon.Controls.Add(this.txtNum);
            this.pnlEntradaRenglon.Controls.Add(this.label20);
            this.pnlEntradaRenglon.Controls.Add(this.txtEmbalaje);
            this.pnlEntradaRenglon.Controls.Add(this.label19);
            this.pnlEntradaRenglon.Controls.Add(this.txtContenido);
            this.pnlEntradaRenglon.Controls.Add(this.label15);
            this.pnlEntradaRenglon.Controls.Add(this.txtPeso);
            this.pnlEntradaRenglon.Controls.Add(this.label14);
            this.pnlEntradaRenglon.Controls.Add(this.txtValorUnitarioPorCuota);
            this.pnlEntradaRenglon.Controls.Add(this.label16);
            this.pnlEntradaRenglon.Controls.Add(this.pnlRetIVA);
            this.pnlEntradaRenglon.Controls.Add(this.btnAgregarRenglon);
            this.pnlEntradaRenglon.Location = new System.Drawing.Point(14, 53);
            this.pnlEntradaRenglon.Name = "pnlEntradaRenglon";
            this.pnlEntradaRenglon.Size = new System.Drawing.Size(867, 54);
            this.pnlEntradaRenglon.TabIndex = 5;

            // label17 (TIPO)
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.label17.Location = new System.Drawing.Point(6, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 12);
            this.label17.TabIndex = 0;
            this.label17.Text = "TIPO";

            // pnlTipo
            this.pnlTipo.Controls.Add(this.rbDDF);
            this.pnlTipo.Controls.Add(this.rbLibre);
            this.pnlTipo.Location = new System.Drawing.Point(6, 19);
            this.pnlTipo.Name = "pnlTipo";
            this.pnlTipo.Size = new System.Drawing.Size(115, 27);
            this.pnlTipo.TabIndex = 1;

            // rbDDF
            this.rbDDF.AutoSize = true;
            this.rbDDF.Checked = true;
            this.rbDDF.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.rbDDF.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.rbDDF.Location = new System.Drawing.Point(2, 4);
            this.rbDDF.Name = "rbDDF";
            this.rbDDF.Size = new System.Drawing.Size(49, 17);
            this.rbDDF.TabIndex = 0;
            this.rbDDF.TabStop = true;
            this.rbDDF.Text = "D.D.F";
            this.rbDDF.UseVisualStyleBackColor = true;

            // rbLibre
            this.rbLibre.AutoSize = true;
            this.rbLibre.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.rbLibre.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.rbLibre.Location = new System.Drawing.Point(54, 4);
            this.rbLibre.Name = "rbLibre";
            this.rbLibre.Size = new System.Drawing.Size(53, 17);
            this.rbLibre.TabIndex = 1;
            this.rbLibre.Text = "LIBRE";
            this.rbLibre.UseVisualStyleBackColor = true;

            // label18 (NUM / CANT)
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.label18.Location = new System.Drawing.Point(126, 4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 12);
            this.label18.TabIndex = 2;
            this.label18.Text = "CANT.";

            // txtNum
            this.txtNum.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtNum.Location = new System.Drawing.Point(126, 21);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(48, 23);
            this.txtNum.TabIndex = 3;

            // label20 (EMBALAJE)
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.label20.Location = new System.Drawing.Point(180, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 12);
            this.label20.TabIndex = 4;
            this.label20.Text = "EMBALAJE";

            // txtEmbalaje
            this.txtEmbalaje.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtEmbalaje.Location = new System.Drawing.Point(180, 21);
            this.txtEmbalaje.Name = "txtEmbalaje";
            this.txtEmbalaje.Size = new System.Drawing.Size(105, 23);
            this.txtEmbalaje.TabIndex = 5;

            // label19 (CONTENIDO)
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.label19.Location = new System.Drawing.Point(291, 4);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 6;
            this.label19.Text = "CONTENIDO";

            // txtContenido
            this.txtContenido.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtContenido.Location = new System.Drawing.Point(291, 21);
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(205, 23);
            this.txtContenido.TabIndex = 7;

            // label15 (PESO)
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.label15.Location = new System.Drawing.Point(502, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 12);
            this.label15.TabIndex = 8;
            this.label15.Text = "PESO (KG)";

            // txtPeso
            this.txtPeso.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtPeso.Location = new System.Drawing.Point(502, 21);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(65, 23);
            this.txtPeso.TabIndex = 9;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // label14 (VALOR UNITARIO)
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.label14.Location = new System.Drawing.Point(573, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 12);
            this.label14.TabIndex = 10;
            this.label14.Text = "CUOTA UNIT. ($)";

            // txtValorUnitarioPorCuota
            this.txtValorUnitarioPorCuota.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtValorUnitarioPorCuota.Location = new System.Drawing.Point(573, 21);
            this.txtValorUnitarioPorCuota.Name = "txtValorUnitarioPorCuota";
            this.txtValorUnitarioPorCuota.Size = new System.Drawing.Size(85, 23);
            this.txtValorUnitarioPorCuota.TabIndex = 11;
            this.txtValorUnitarioPorCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // label16 (RET IVA)
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.label16.Location = new System.Drawing.Point(664, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 12);
            this.label16.TabIndex = 12;
            this.label16.Text = "RET. IVA";

            // pnlRetIVA
            this.pnlRetIVA.Controls.Add(this.rbNoiva);
            this.pnlRetIVA.Controls.Add(this.rbSiIVA);
            this.pnlRetIVA.Location = new System.Drawing.Point(664, 19);
            this.pnlRetIVA.Name = "pnlRetIVA";
            this.pnlRetIVA.Size = new System.Drawing.Size(95, 27);
            this.pnlRetIVA.TabIndex = 13;

            // rbNoiva
            this.rbNoiva.AutoSize = true;
            this.rbNoiva.Checked = true;
            this.rbNoiva.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.rbNoiva.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.rbNoiva.Location = new System.Drawing.Point(2, 4);
            this.rbNoiva.Name = "rbNoiva";
            this.rbNoiva.Size = new System.Drawing.Size(40, 17);
            this.rbNoiva.TabIndex = 0;
            this.rbNoiva.TabStop = true;
            this.rbNoiva.Text = "No";
            this.rbNoiva.UseVisualStyleBackColor = true;

            // rbSiIVA
            this.rbSiIVA.AutoSize = true;
            this.rbSiIVA.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.rbSiIVA.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.rbSiIVA.Location = new System.Drawing.Point(46, 4);
            this.rbSiIVA.Name = "rbSiIVA";
            this.rbSiIVA.Size = new System.Drawing.Size(34, 17);
            this.rbSiIVA.TabIndex = 1;
            this.rbSiIVA.Text = "Sí";
            this.rbSiIVA.UseVisualStyleBackColor = true;

            // btnAgregarRenglon
            this.btnAgregarRenglon.BackColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.btnAgregarRenglon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRenglon.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnAgregarRenglon.ForeColor = System.Drawing.Color.White;
            this.btnAgregarRenglon.Location = new System.Drawing.Point(766, 16);
            this.btnAgregarRenglon.Name = "btnAgregarRenglon";
            this.btnAgregarRenglon.Size = new System.Drawing.Size(93, 29);
            this.btnAgregarRenglon.TabIndex = 14;
            this.btnAgregarRenglon.Text = "➕ Agregar";
            this.btnAgregarRenglon.UseVisualStyleBackColor = false;

            // -------------------------------------------------------------
            // dataGridView1 (Tabla de Bultos / Renglones)
            // -------------------------------------------------------------
            dgvCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dgvCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvCellStyle2.BackColor = System.Drawing.Color.FromArgb(0, 75, 135);
            dgvCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            dgvCellStyle2.ForeColor = System.Drawing.Color.White;
            dgvCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dgvCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dgvCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dgvCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 28;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dgvCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            dgvCellStyle3.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dgvCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(0, 75, 135);
            dgvCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dgvCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dgvCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dataGridView1.Location = new System.Drawing.Point(14, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(867, 258);
            this.dataGridView1.TabIndex = 6;

            // -------------------------------------------------------------
            // gbTotales (Tarjeta Desglose Económico)
            // -------------------------------------------------------------
            this.gbTotales.BackColor = System.Drawing.Color.White;
            this.gbTotales.Controls.Add(this.label23);
            this.gbTotales.Controls.Add(this.txtFlete);
            this.gbTotales.Controls.Add(this.label24);
            this.gbTotales.Controls.Add(this.txtManiobras);
            this.gbTotales.Controls.Add(this.label25);
            this.gbTotales.Controls.Add(this.txtCobroPorSeguro);
            this.gbTotales.Controls.Add(this.label28);
            this.gbTotales.Controls.Add(this.txtALYT);
            this.gbTotales.Controls.Add(this.label27);
            this.gbTotales.Controls.Add(this.txtOtros);
            this.gbTotales.Controls.Add(this.pnlLineaTotales);
            this.gbTotales.Controls.Add(this.label26);
            this.gbTotales.Controls.Add(this.txtSuma);
            this.gbTotales.Controls.Add(this.label32);
            this.gbTotales.Controls.Add(this.txtIVA);
            this.gbTotales.Controls.Add(this.label31);
            this.gbTotales.Controls.Add(this.txtSubtotal);
            this.gbTotales.Controls.Add(this.label30);
            this.gbTotales.Controls.Add(this.txtRetenerIVA);
            this.gbTotales.Controls.Add(this.pnlTotalHighlight);
            this.gbTotales.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbTotales.ForeColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.gbTotales.Location = new System.Drawing.Point(920, 268);
            this.gbTotales.Name = "gbTotales";
            this.gbTotales.Size = new System.Drawing.Size(304, 385);
            this.gbTotales.TabIndex = 4;
            this.gbTotales.TabStop = false;
            this.gbTotales.Text = "  DESGLOSE DE COBRO  ";

            // label23 (Flete)
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label23.Location = new System.Drawing.Point(14, 25);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Flete ($):";

            // txtFlete
            this.txtFlete.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtFlete.Location = new System.Drawing.Point(165, 21);
            this.txtFlete.Name = "txtFlete";
            this.txtFlete.Size = new System.Drawing.Size(125, 23);
            this.txtFlete.TabIndex = 1;
            this.txtFlete.Text = "0.00";
            this.txtFlete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // label24 (Maniobras)
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label24.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label24.Location = new System.Drawing.Point(14, 51);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "Maniobras ($):";

            // txtManiobras
            this.txtManiobras.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtManiobras.Location = new System.Drawing.Point(165, 47);
            this.txtManiobras.Name = "txtManiobras";
            this.txtManiobras.Size = new System.Drawing.Size(125, 23);
            this.txtManiobras.TabIndex = 3;
            this.txtManiobras.Text = "0.00";
            this.txtManiobras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // label25 (Cobro por Seguro)
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label25.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label25.Location = new System.Drawing.Point(14, 77);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(89, 13);
            this.label25.TabIndex = 4;
            this.label25.Text = "C. x Seguro ($):";

            // txtCobroPorSeguro
            this.txtCobroPorSeguro.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtCobroPorSeguro.Location = new System.Drawing.Point(165, 73);
            this.txtCobroPorSeguro.Name = "txtCobroPorSeguro";
            this.txtCobroPorSeguro.Size = new System.Drawing.Size(125, 23);
            this.txtCobroPorSeguro.TabIndex = 5;
            this.txtCobroPorSeguro.Text = "0.00";
            this.txtCobroPorSeguro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // label28 (ALYT)
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label28.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label28.Location = new System.Drawing.Point(14, 103);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(63, 13);
            this.label28.TabIndex = 6;
            this.label28.Text = "A.L.Y.T. ($):";

            // txtALYT
            this.txtALYT.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtALYT.Location = new System.Drawing.Point(165, 99);
            this.txtALYT.Name = "txtALYT";
            this.txtALYT.Size = new System.Drawing.Size(125, 23);
            this.txtALYT.TabIndex = 7;
            this.txtALYT.Text = "0.00";
            this.txtALYT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // label27 (Otros)
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label27.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label27.Location = new System.Drawing.Point(14, 129);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(56, 13);
            this.label27.TabIndex = 8;
            this.label27.Text = "Otros ($):";

            // txtOtros
            this.txtOtros.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtOtros.Location = new System.Drawing.Point(165, 125);
            this.txtOtros.Name = "txtOtros";
            this.txtOtros.Size = new System.Drawing.Size(125, 23);
            this.txtOtros.TabIndex = 9;
            this.txtOtros.Text = "0.00";
            this.txtOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // pnlLineaTotales
            this.pnlLineaTotales.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.pnlLineaTotales.Location = new System.Drawing.Point(14, 156);
            this.pnlLineaTotales.Name = "pnlLineaTotales";
            this.pnlLineaTotales.Size = new System.Drawing.Size(276, 1);
            this.pnlLineaTotales.TabIndex = 10;

            // label26 (SUMA)
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label26.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.label26.Location = new System.Drawing.Point(14, 166);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(43, 13);
            this.label26.TabIndex = 11;
            this.label26.Text = "SUMA:";

            // txtSuma
            this.txtSuma.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtSuma.Location = new System.Drawing.Point(165, 162);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.ReadOnly = true;
            this.txtSuma.Size = new System.Drawing.Size(125, 23);
            this.txtSuma.TabIndex = 12;
            this.txtSuma.TabStop = false;
            this.txtSuma.Text = "0.00";
            this.txtSuma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // label32 (IVA)
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label32.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.label32.Location = new System.Drawing.Point(14, 192);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(65, 13);
            this.label32.TabIndex = 13;
            this.label32.Text = "I.V.A. (16%):";

            // txtIVA
            this.txtIVA.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtIVA.Location = new System.Drawing.Point(165, 188);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(125, 23);
            this.txtIVA.TabIndex = 14;
            this.txtIVA.TabStop = false;
            this.txtIVA.Text = "0.00";
            this.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // label31 (SUBTOTAL)
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label31.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.label31.Location = new System.Drawing.Point(14, 218);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(64, 13);
            this.label31.TabIndex = 15;
            this.label31.Text = "SUBTOTAL:";

            // txtSubtotal
            this.txtSubtotal.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtSubtotal.Location = new System.Drawing.Point(165, 214);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(125, 23);
            this.txtSubtotal.TabIndex = 16;
            this.txtSubtotal.TabStop = false;
            this.txtSubtotal.Text = "0.00";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // label30 (RETEN IVA)
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label30.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.label30.Location = new System.Drawing.Point(14, 244);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(107, 13);
            this.label30.TabIndex = 17;
            this.label30.Text = "- RETENCIÓN I.V.A.:";

            // txtRetenerIVA
            this.txtRetenerIVA.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtRetenerIVA.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.txtRetenerIVA.Location = new System.Drawing.Point(165, 240);
            this.txtRetenerIVA.Name = "txtRetenerIVA";
            this.txtRetenerIVA.Size = new System.Drawing.Size(125, 23);
            this.txtRetenerIVA.TabIndex = 18;
            this.txtRetenerIVA.Text = "0.00";
            this.txtRetenerIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // -------------------------------------------------------------
            // pnlTotalHighlight (Tarjeta Azul con TOTAL en grande)
            // -------------------------------------------------------------
            this.pnlTotalHighlight.BackColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.pnlTotalHighlight.Controls.Add(this.label29);
            this.pnlTotalHighlight.Controls.Add(this.txtTotal);
            this.pnlTotalHighlight.Location = new System.Drawing.Point(14, 276);
            this.pnlTotalHighlight.Name = "pnlTotalHighlight";
            this.pnlTotalHighlight.Size = new System.Drawing.Size(276, 96);
            this.pnlTotalHighlight.TabIndex = 19;

            // label29 (TOTAL)
            this.label29.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.label29.ForeColor = System.Drawing.Color.FromArgb(191, 219, 254);
            this.label29.Location = new System.Drawing.Point(0, 8);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(276, 17);
            this.label29.TabIndex = 0;
            this.label29.Text = "TOTAL A PAGAR (MXN)";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // txtTotal
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.txtTotal.ForeColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(8, 32);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(260, 36);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.TabStop = false;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // -------------------------------------------------------------
            // gbRuta (Tarjeta Control Operativo y Observaciones)
            // -------------------------------------------------------------
            this.gbRuta.BackColor = System.Drawing.Color.White;
            this.gbRuta.Controls.Add(this.label34);
            this.gbRuta.Controls.Add(this.txtReembarco);
            this.gbRuta.Controls.Add(this.label37);
            this.gbRuta.Controls.Add(this.txtReembarcarseCon);
            this.gbRuta.Controls.Add(this.label35);
            this.gbRuta.Controls.Add(this.txtCondujo);
            this.gbRuta.Controls.Add(this.label38);
            this.gbRuta.Controls.Add(this.txtConducira);
            this.gbRuta.Controls.Add(this.label36);
            this.gbRuta.Controls.Add(this.txtObservaciones);
            this.gbRuta.Controls.Add(this.label33);
            this.gbRuta.Controls.Add(this.txtObservacionesDDF);
            this.gbRuta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbRuta.ForeColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.gbRuta.Location = new System.Drawing.Point(16, 661);
            this.gbRuta.Name = "gbRuta";
            this.gbRuta.Size = new System.Drawing.Size(895, 142);
            this.gbRuta.TabIndex = 5;
            this.gbRuta.TabStop = false;
            this.gbRuta.Text = "  CONTROL OPERATIVO, RUTA Y OBSERVACIONES  ";

            // label34 (Reembarco)
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label34.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label34.Location = new System.Drawing.Point(14, 22);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(68, 13);
            this.label34.TabIndex = 0;
            this.label34.Text = "Reembarco:";

            // txtReembarco
            this.txtReembarco.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtReembarco.Location = new System.Drawing.Point(14, 38);
            this.txtReembarco.Name = "txtReembarco";
            this.txtReembarco.Size = new System.Drawing.Size(195, 23);
            this.txtReembarco.TabIndex = 1;

            // label37 (Reembarcarse con)
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label37.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label37.Location = new System.Drawing.Point(220, 22);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(107, 13);
            this.label37.TabIndex = 2;
            this.label37.Text = "Reembarcarse con:";

            // txtReembarcarseCon
            this.txtReembarcarseCon.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtReembarcarseCon.Location = new System.Drawing.Point(220, 38);
            this.txtReembarcarseCon.Name = "txtReembarcarseCon";
            this.txtReembarcarseCon.Size = new System.Drawing.Size(200, 23);
            this.txtReembarcarseCon.TabIndex = 3;

            // label35 (Condujo)
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label35.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label35.Location = new System.Drawing.Point(432, 22);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(55, 13);
            this.label35.TabIndex = 4;
            this.label35.Text = "Condujo:";

            // txtCondujo
            this.txtCondujo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtCondujo.Location = new System.Drawing.Point(432, 38);
            this.txtCondujo.Name = "txtCondujo";
            this.txtCondujo.Size = new System.Drawing.Size(210, 23);
            this.txtCondujo.TabIndex = 5;

            // label38 (Conducirá)
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label38.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label38.Location = new System.Drawing.Point(652, 22);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(63, 13);
            this.label38.TabIndex = 6;
            this.label38.Text = "Conducirá:";

            // txtConducira
            this.txtConducira.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtConducira.Location = new System.Drawing.Point(652, 38);
            this.txtConducira.Name = "txtConducira";
            this.txtConducira.Size = new System.Drawing.Size(229, 23);
            this.txtConducira.TabIndex = 7;

            // label36 (Observaciones Generales)
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label36.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label36.Location = new System.Drawing.Point(14, 69);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(134, 13);
            this.label36.TabIndex = 8;
            this.label36.Text = "Observaciones Generales:";

            // txtObservaciones
            this.txtObservaciones.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtObservaciones.Location = new System.Drawing.Point(14, 86);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(406, 44);
            this.txtObservaciones.TabIndex = 9;

            // label33 (Observaciones DDF)
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label33.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.label33.Location = new System.Drawing.Point(432, 69);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(115, 13);
            this.label33.TabIndex = 10;
            this.label33.Text = "Observaciones D.D.F.:";

            // txtObservacionesDDF
            this.txtObservacionesDDF.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtObservacionesDDF.Location = new System.Drawing.Point(432, 86);
            this.txtObservacionesDDF.Multiline = true;
            this.txtObservacionesDDF.Name = "txtObservacionesDDF";
            this.txtObservacionesDDF.Size = new System.Drawing.Size(449, 44);
            this.txtObservacionesDDF.TabIndex = 11;

            // -------------------------------------------------------------
            // pnlAcciones (Botones de Acción principales)
            // -------------------------------------------------------------
            this.pnlAcciones.Controls.Add(this.btnGrabar);
            this.pnlAcciones.Controls.Add(this.btnSalir);
            this.pnlAcciones.Location = new System.Drawing.Point(920, 661);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(304, 142);
            this.pnlAcciones.TabIndex = 6;

            // btnGrabar
            this.btnGrabar.BackColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.btnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGrabar.ForeColor = System.Drawing.Color.White;
            this.btnGrabar.Location = new System.Drawing.Point(0, 8);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(304, 62);
            this.btnGrabar.TabIndex = 0;
            this.btnGrabar.Text = "💾  GUARDAR FACTURA  (F5)";
            this.btnGrabar.UseVisualStyleBackColor = false;

            // btnSalir
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnSalir.Location = new System.Drawing.Point(0, 80);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(304, 50);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "❌  SALIR  (ESC)";
            this.btnSalir.UseVisualStyleBackColor = false;

            // radioButton1 (Oculto para compatibilidad)
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(0, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 99;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;

            // -------------------------------------------------------------
            // frmFacturacion
            // -------------------------------------------------------------
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(240, 243, 246);
            this.ClientSize = new System.Drawing.Size(1240, 720);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.gbRuta);
            this.Controls.Add(this.gbTotales);
            this.Controls.Add(this.gbCarga);
            this.Controls.Add(this.gbDestinatario);
            this.Controls.Add(this.gbRemitente);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.radioButton1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.KeyPreview = true;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.MinimumSize = new System.Drawing.Size(1024, 650);
            this.Name = "frmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emisión de Guías de Embarque y Facturación - Autotransportaciones Lucero";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            this.Resize += new System.EventHandler(this.frmFacturacion_Resize);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlOficina.ResumeLayout(false);
            this.pnlOficina.PerformLayout();
            this.gbRemitente.ResumeLayout(false);
            this.gbRemitente.PerformLayout();
            this.gbDestinatario.ResumeLayout(false);
            this.gbDestinatario.PerformLayout();
            this.gbCarga.ResumeLayout(false);
            this.gbCarga.PerformLayout();
            this.pnlFleteModalidad.ResumeLayout(false);
            this.pnlFleteModalidad.PerformLayout();
            this.pnlSeguro.ResumeLayout(false);
            this.pnlSeguro.PerformLayout();
            this.pnlEntradaRenglon.ResumeLayout(false);
            this.pnlEntradaRenglon.PerformLayout();
            this.pnlTipo.ResumeLayout(false);
            this.pnlTipo.PerformLayout();
            this.pnlRetIVA.ResumeLayout(false);
            this.pnlRetIVA.PerformLayout();
            this.gbTotales.ResumeLayout(false);
            this.gbTotales.PerformLayout();
            this.pnlTotalHighlight.ResumeLayout(false);
            this.pnlTotalHighlight.PerformLayout();
            this.gbRuta.ResumeLayout(false);
            this.gbRuta.PerformLayout();
            this.pnlAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Declaraciones de controles
        private Panel pnlHeader;
        private Label lblEmpresa;
        private Label lblSubtitulo;
        private Label label1;
        private TextBox txtFecha;
        private Label lblLugar;
        private TextBox tctLugar;
        private Panel pnlOficina;
        private Label label3;
        private RadioButton rbMexico;
        private RadioButton rbChinconcuac;
        private Label label2;
        private Label lblFolioBadge;
        private TextBox txtFolio;
        private Label label39;
        private TextBox txtUsuario;

        private GroupBox gbRemitente;
        private Label label4;
        private TextBox txtOrigen;
        private Label label5;
        private TextBox txtRemitente;
        private Label label6;
        private TextBox txtRFC;
        private Label label8;
        private TextBox txtDomicilioremitente;
        private Label label7;
        private TextBox txtSerecogeraen;

        private GroupBox gbDestinatario;
        private Label label13;
        private TextBox txtDestino;
        private Label label12;
        private TextBox txtDestinatario;
        private Label label11;
        private TextBox txtRFCDestinatario;
        private Label label10;
        private TextBox txtDomicilioDestinarario;
        private Label label9;
        private TextBox txtSeEntregaraEn;

        private GroupBox gbCarga;
        private Panel pnlFleteModalidad;
        private Label label21;
        private RadioButton rbPorCobrar;
        private RadioButton rbPagado;
        private Panel pnlSeguro;
        private Label label40;
        private RadioButton rbSeguroNoPagado;
        private RadioButton rbSeguroPagado;
        private Label label22;
        private TextBox txtValorDeclarado;
        private Button button1;

        private Panel pnlEntradaRenglon;
        private Label label17;
        private Panel pnlTipo;
        private RadioButton rbDDF;
        private RadioButton rbLibre;
        private Label label18;
        private TextBox txtNum;
        private Label label20;
        private TextBox txtEmbalaje;
        private Label label19;
        private TextBox txtContenido;
        private Label label15;
        private TextBox txtPeso;
        private Label label14;
        private TextBox txtValorUnitarioPorCuota;
        private Label label16;
        private Panel pnlRetIVA;
        private RadioButton rbNoiva;
        private RadioButton rbSiIVA;
        private Button btnAgregarRenglon;

        private DataGridView dataGridView1;

        private GroupBox gbTotales;
        private Label label23;
        private TextBox txtFlete;
        private Label label24;
        private TextBox txtManiobras;
        private Label label25;
        private TextBox txtCobroPorSeguro;
        private Label label28;
        private TextBox txtALYT;
        private Label label27;
        private TextBox txtOtros;
        private Panel pnlLineaTotales;
        private Label label26;
        private TextBox txtSuma;
        private Label label32;
        private TextBox txtIVA;
        private Label label31;
        private TextBox txtSubtotal;
        private Label label30;
        private TextBox txtRetenerIVA;
        private Panel pnlTotalHighlight;
        private Label label29;
        private TextBox txtTotal;

        private GroupBox gbRuta;
        private Label label34;
        private TextBox txtReembarco;
        private Label label37;
        private TextBox txtReembarcarseCon;
        private Label label35;
        private TextBox txtCondujo;
        private Label label38;
        private TextBox txtConducira;
        private Label label36;
        private TextBox txtObservaciones;
        private Label label33;
        private TextBox txtObservacionesDDF;

        private Panel pnlAcciones;
        private Button btnGrabar;
        private Button btnSalir;

        private RadioButton radioButton1;
    }
}

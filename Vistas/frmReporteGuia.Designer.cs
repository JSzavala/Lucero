namespace Lucero.Vistas
{
    partial class frmReporteGuia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dgvCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFechaEmision = new System.Windows.Forms.Label();

            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.lblFiltroOficina = new System.Windows.Forms.Label();
            this.cmbOficinaFiltro = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblRutaInfo = new System.Windows.Forms.Label();

            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colFolio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemitente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestinatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBultos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContenido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeguro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFlete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlTotales = new System.Windows.Forms.Panel();
            this.lblTotalGuias = new System.Windows.Forms.Label();
            this.lblTotalBultos = new System.Windows.Forms.Label();
            this.lblTotalPeso = new System.Windows.Forms.Label();
            this.lblTotalFlete = new System.Windows.Forms.Label();
            this.lblGranTotal = new System.Windows.Forms.Label();

            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFooterMsg = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.pnlTotales.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelIzquierdo (Mantenido para compatibilidad de firma, oculto)
            // 
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(1, 1);
            this.panelIzquierdo.TabIndex = 99;
            this.panelIzquierdo.Visible = false;

            // 
            // pnlHeader (Encabezado corporativo oficial)
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.label4);
            this.pnlHeader.Controls.Add(this.label5);
            this.pnlHeader.Controls.Add(this.lblFechaEmision);
            this.pnlHeader.Location = new System.Drawing.Point(14, 10);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1172, 86);
            this.pnlHeader.TabIndex = 0;

            // label1 (Título empresa)
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "AUTOTRANSPORTACIONES DE CARGA \"LUCERO\", S.A. DE C.V.";

            // label2 (Servicio)
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.label2.Location = new System.Drawing.Point(14, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SERVICIO PÚBLICO FEDERAL DE CARGA REGULAR";

            // label3 (Caminos)
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.label3.Location = new System.Drawing.Point(276, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "• CAMINOS NACIONALES";

            // label4 (Oficinas generales etiqueta)
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.label4.Location = new System.Drawing.Point(14, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "OFICINAS GENERALES:";

            // label5 (Dirección)
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.label5.Location = new System.Drawing.Point(135, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(434, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "5 DE MAYO No. 17, TEL. (445) 45-7-11-81 MOROLEÓN, GTO. • ORFEBRERÍA 91, CDMX";

            // lblFechaEmision
            this.lblFechaEmision.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.lblFechaEmision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFechaEmision.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblFechaEmision.ForeColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.lblFechaEmision.Location = new System.Drawing.Point(920, 12);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(236, 58);
            this.lblFechaEmision.TabIndex = 5;
            this.lblFechaEmision.Text = "📅 MANIFIESTO DE RUTA\r\nFECHA: 16/11/2026\r\nESTADO: ACTIVO";
            this.lblFechaEmision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // pnlFiltros (Barra de unidad, ruta y filtros)
            // 
            this.pnlFiltros.BackColor = System.Drawing.Color.White;
            this.pnlFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFiltros.Controls.Add(this.lblRutaInfo);
            this.pnlFiltros.Controls.Add(this.lblFiltroOficina);
            this.pnlFiltros.Controls.Add(this.cmbOficinaFiltro);
            this.pnlFiltros.Controls.Add(this.btnActualizar);
            this.pnlFiltros.Location = new System.Drawing.Point(14, 102);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(1172, 44);
            this.pnlFiltros.TabIndex = 1;

            // lblRutaInfo
            this.lblRutaInfo.AutoSize = true;
            this.lblRutaInfo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblRutaInfo.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblRutaInfo.Location = new System.Drawing.Point(12, 13);
            this.lblRutaInfo.Name = "lblRutaInfo";
            this.lblRutaInfo.Size = new System.Drawing.Size(434, 15);
            this.lblRutaInfo.TabIndex = 0;
            this.lblRutaInfo.Text = "🚛 RUTA / CONCENTRADO GENERAL DE EMBARQUES • MOROLEÓN / MÉXICO";

            // lblFiltroOficina
            this.lblFiltroOficina.AutoSize = true;
            this.lblFiltroOficina.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblFiltroOficina.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblFiltroOficina.Location = new System.Drawing.Point(800, 13);
            this.lblFiltroOficina.Name = "lblFiltroOficina";
            this.lblFiltroOficina.Size = new System.Drawing.Size(56, 15);
            this.lblFiltroOficina.TabIndex = 1;
            this.lblFiltroOficina.Text = "OFICINA:";

            // cmbOficinaFiltro
            this.cmbOficinaFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOficinaFiltro.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.cmbOficinaFiltro.FormattingEnabled = true;
            this.cmbOficinaFiltro.Items.AddRange(new object[] {
            "Todas las Oficinas",
            "México",
            "Chinconcuac"});
            this.cmbOficinaFiltro.Location = new System.Drawing.Point(862, 10);
            this.cmbOficinaFiltro.Name = "cmbOficinaFiltro";
            this.cmbOficinaFiltro.Size = new System.Drawing.Size(155, 21);
            this.cmbOficinaFiltro.TabIndex = 2;

            // btnActualizar
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(1028, 8);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(130, 26);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "🔄 ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;

            // 
            // dataGridView1 (Tabla con las 13 columnas del papel)
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dgvCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dgvCellStyle1;
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
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFolio,
            this.colRemitente,
            this.colDestinatario,
            this.colDestino,
            this.colBultos,
            this.colContenido,
            this.colValor,
            this.colPeso,
            this.colSeguro,
            this.colModalidad,
            this.colFlete,
            this.colIva,
            this.colTotal});
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
            this.dataGridView1.Location = new System.Drawing.Point(14, 152);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1172, 360);
            this.dataGridView1.TabIndex = 2;

            // colFolio
            this.colFolio.DataPropertyName = "Folio";
            this.colFolio.HeaderText = "Folio";
            this.colFolio.Name = "colFolio";
            this.colFolio.ReadOnly = true;
            this.colFolio.Width = 80;

            // colRemitente
            this.colRemitente.DataPropertyName = "Remitente";
            this.colRemitente.HeaderText = "Remitente";
            this.colRemitente.Name = "colRemitente";
            this.colRemitente.ReadOnly = true;
            this.colRemitente.Width = 150;

            // colDestinatario
            this.colDestinatario.DataPropertyName = "Destinatario";
            this.colDestinatario.HeaderText = "Destinatario";
            this.colDestinatario.Name = "colDestinatario";
            this.colDestinatario.ReadOnly = true;
            this.colDestinatario.Width = 150;

            // colDestino
            this.colDestino.DataPropertyName = "Destino";
            this.colDestino.HeaderText = "Destino";
            this.colDestino.Name = "colDestino";
            this.colDestino.ReadOnly = true;
            this.colDestino.Width = 90;

            // colBultos
            this.colBultos.HeaderText = "Bultos";
            this.colBultos.Name = "colBultos";
            this.colBultos.ReadOnly = true;
            this.colBultos.Width = 55;

            // colContenido
            this.colContenido.HeaderText = "Contenido";
            this.colContenido.Name = "colContenido";
            this.colContenido.ReadOnly = true;
            this.colContenido.Width = 120;

            // colValor
            this.colValor.HeaderText = "Valor ($)";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            this.colValor.Width = 75;

            // colPeso
            this.colPeso.HeaderText = "Peso (kg)";
            this.colPeso.Name = "colPeso";
            this.colPeso.ReadOnly = true;
            this.colPeso.Width = 70;

            // colSeguro
            this.colSeguro.HeaderText = "Seguro";
            this.colSeguro.Name = "colSeguro";
            this.colSeguro.ReadOnly = true;
            this.colSeguro.Width = 65;

            // colModalidad
            this.colModalidad.HeaderText = "Modalidad";
            this.colModalidad.Name = "colModalidad";
            this.colModalidad.ReadOnly = true;
            this.colModalidad.Width = 85;

            // colFlete
            this.colFlete.DataPropertyName = "Flete";
            this.colFlete.HeaderText = "Flete ($)";
            this.colFlete.Name = "colFlete";
            this.colFlete.ReadOnly = true;
            this.colFlete.Width = 75;

            // colIva
            this.colIva.DataPropertyName = "Iva";
            this.colIva.HeaderText = "IVA ($)";
            this.colIva.Name = "colIva";
            this.colIva.ReadOnly = true;
            this.colIva.Width = 70;

            // colTotal
            this.colTotal.DataPropertyName = "Total";
            this.colTotal.HeaderText = "Total ($)";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 85;

            // 
            // pnlTotales (Barra de KPIs de totales del manifiesto)
            // 
            this.pnlTotales.BackColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.pnlTotales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotales.Controls.Add(this.lblTotalGuias);
            this.pnlTotales.Controls.Add(this.lblTotalBultos);
            this.pnlTotales.Controls.Add(this.lblTotalPeso);
            this.pnlTotales.Controls.Add(this.lblTotalFlete);
            this.pnlTotales.Controls.Add(this.lblGranTotal);
            this.pnlTotales.Location = new System.Drawing.Point(14, 518);
            this.pnlTotales.Name = "pnlTotales";
            this.pnlTotales.Size = new System.Drawing.Size(1172, 60);
            this.pnlTotales.TabIndex = 3;

            // lblTotalGuias
            this.lblTotalGuias.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalGuias.ForeColor = System.Drawing.Color.White;
            this.lblTotalGuias.Location = new System.Drawing.Point(10, 8);
            this.lblTotalGuias.Name = "lblTotalGuias";
            this.lblTotalGuias.Size = new System.Drawing.Size(180, 42);
            this.lblTotalGuias.TabIndex = 0;
            this.lblTotalGuias.Text = "TOTAL GUÍAS\r\n0 Guías";
            this.lblTotalGuias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblTotalBultos
            this.lblTotalBultos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalBultos.ForeColor = System.Drawing.Color.White;
            this.lblTotalBultos.Location = new System.Drawing.Point(200, 8);
            this.lblTotalBultos.Name = "lblTotalBultos";
            this.lblTotalBultos.Size = new System.Drawing.Size(180, 42);
            this.lblTotalBultos.TabIndex = 1;
            this.lblTotalBultos.Text = "TOTAL BULTOS\r\n0 Bultos";
            this.lblTotalBultos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblTotalPeso
            this.lblTotalPeso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalPeso.ForeColor = System.Drawing.Color.White;
            this.lblTotalPeso.Location = new System.Drawing.Point(390, 8);
            this.lblTotalPeso.Name = "lblTotalPeso";
            this.lblTotalPeso.Size = new System.Drawing.Size(190, 42);
            this.lblTotalPeso.TabIndex = 2;
            this.lblTotalPeso.Text = "PESO TOTAL\r\n0.00 kg";
            this.lblTotalPeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblTotalFlete
            this.lblTotalFlete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalFlete.ForeColor = System.Drawing.Color.White;
            this.lblTotalFlete.Location = new System.Drawing.Point(590, 8);
            this.lblTotalFlete.Name = "lblTotalFlete";
            this.lblTotalFlete.Size = new System.Drawing.Size(210, 42);
            this.lblTotalFlete.TabIndex = 3;
            this.lblTotalFlete.Text = "SUBTOTAL FLETES\r\n$0.00";
            this.lblTotalFlete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblGranTotal
            this.lblGranTotal.BackColor = System.Drawing.Color.FromArgb(0, 50, 95);
            this.lblGranTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGranTotal.ForeColor = System.Drawing.Color.FromArgb(254, 240, 138);
            this.lblGranTotal.Location = new System.Drawing.Point(820, 6);
            this.lblGranTotal.Name = "lblGranTotal";
            this.lblGranTotal.Size = new System.Drawing.Size(340, 46);
            this.lblGranTotal.TabIndex = 4;
            this.lblGranTotal.Text = "GRAN TOTAL: $0.00";
            this.lblGranTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.Transparent;
            this.pnlFooter.Controls.Add(this.lblFooterMsg);
            this.pnlFooter.Controls.Add(this.btnSalir);
            this.pnlFooter.Location = new System.Drawing.Point(14, 584);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1172, 38);
            this.pnlFooter.TabIndex = 4;

            // lblFooterMsg
            this.lblFooterMsg.AutoSize = true;
            this.lblFooterMsg.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFooterMsg.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblFooterMsg.Location = new System.Drawing.Point(4, 11);
            this.lblFooterMsg.Name = "lblFooterMsg";
            this.lblFooterMsg.Size = new System.Drawing.Size(374, 15);
            this.lblFooterMsg.TabIndex = 0;
            this.lblFooterMsg.Text = "📄 Manifiesto conforme a las disposiciones de Servicio Público Federal";

            // btnSalir
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnSalir.Location = new System.Drawing.Point(992, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(180, 32);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "❌  CERRAR  (ESC)";
            this.btnSalir.UseVisualStyleBackColor = false;

            // 
            // frmReporteGuia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(240, 243, 246);
            this.ClientSize = new System.Drawing.Size(1200, 630);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlTotales);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.panelIzquierdo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.KeyPreview = true;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "frmReporteGuia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manifiesto y Reporte de Guías de Embarque - Autotransportaciones Lucero";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.frmReporteGuia_Resize);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.pnlTotales.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFechaEmision;

        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label lblRutaInfo;
        private System.Windows.Forms.Label lblFiltroOficina;
        private System.Windows.Forms.ComboBox cmbOficinaFiltro;
        private System.Windows.Forms.Button btnActualizar;

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFolio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemitente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBultos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContenido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeguro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFlete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;

        private System.Windows.Forms.Panel pnlTotales;
        private System.Windows.Forms.Label lblTotalGuias;
        private System.Windows.Forms.Label lblTotalBultos;
        private System.Windows.Forms.Label lblTotalPeso;
        private System.Windows.Forms.Label lblTotalFlete;
        private System.Windows.Forms.Label lblGranTotal;

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblFooterMsg;
        private System.Windows.Forms.Button btnSalir;
    }
}

namespace Lucero.Vistas
{
    partial class frmMenuPrincipal
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.lblUsuarioRol = new System.Windows.Forms.Label();
            this.lblUsuarioNombre = new System.Windows.Forms.Label();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnAnexarFact = new System.Windows.Forms.Button();
            this.btnReporteGuia = new System.Windows.Forms.Button();
            this.btnFactOtros = new System.Windows.Forms.Button();
            this.lblStatusFooter = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblLogo);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.pnlUsuario);
            this.pnlHeader.Location = new System.Drawing.Point(20, 16);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(820, 72);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.BackColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(12, 12);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(46, 46);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "AL";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.label1.Location = new System.Drawing.Point(68, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "AUTOTRANSPORTACIONES LUCERO, S.A. DE C.V.";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSubtitulo.Location = new System.Drawing.Point(70, 39);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(342, 13);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "SERVICIO PÚBLICO FEDERAL • SISTEMA DE CONTROL Y FACTURACIÓN";
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUsuario.Controls.Add(this.lblUsuarioRol);
            this.pnlUsuario.Controls.Add(this.lblUsuarioNombre);
            this.pnlUsuario.Location = new System.Drawing.Point(598, 13);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(208, 44);
            this.pnlUsuario.TabIndex = 3;
            // 
            // lblUsuarioRol
            // 
            this.lblUsuarioRol.AutoSize = true;
            this.lblUsuarioRol.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioRol.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblUsuarioRol.Location = new System.Drawing.Point(8, 4);
            this.lblUsuarioRol.Name = "lblUsuarioRol";
            this.lblUsuarioRol.Size = new System.Drawing.Size(89, 12);
            this.lblUsuarioRol.TabIndex = 0;
            this.lblUsuarioRol.Text = "🟢 SESIÓN ACTIVA";
            // 
            // lblUsuarioNombre
            // 
            this.lblUsuarioNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioNombre.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblUsuarioNombre.Location = new System.Drawing.Point(8, 20);
            this.lblUsuarioNombre.Name = "lblUsuarioNombre";
            this.lblUsuarioNombre.Size = new System.Drawing.Size(190, 18);
            this.lblUsuarioNombre.TabIndex = 1;
            this.lblUsuarioNombre.Text = "Usuario de Prueba";
            // 
            // tlpBotones
            // 
            this.tlpBotones.BackColor = System.Drawing.Color.Transparent;
            this.tlpBotones.ColumnCount = 3;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpBotones.Controls.Add(this.btnUsuarios, 0, 0);
            this.tlpBotones.Controls.Add(this.btnConsultas, 1, 0);
            this.tlpBotones.Controls.Add(this.btnFacturacion, 2, 0);
            this.tlpBotones.Controls.Add(this.btnAnexarFact, 0, 1);
            this.tlpBotones.Controls.Add(this.btnReporteGuia, 1, 1);
            this.tlpBotones.Controls.Add(this.btnFactOtros, 2, 1);
            this.tlpBotones.Location = new System.Drawing.Point(20, 102);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 2;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Size = new System.Drawing.Size(820, 348);
            this.tlpBotones.TabIndex = 1;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(6, 6);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(6);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(261, 162);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "👥  USUARIOS\r\n\r\nGestión de accesos y operadores";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            this.btnUsuarios.MouseEnter += new System.EventHandler(this.MenuButton_MouseEnter);
            this.btnUsuarios.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.btnConsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConsultas.ForeColor = System.Drawing.Color.White;
            this.btnConsultas.Location = new System.Drawing.Point(279, 6);
            this.btnConsultas.Margin = new System.Windows.Forms.Padding(6);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(261, 162);
            this.btnConsultas.TabIndex = 1;
            this.btnConsultas.Text = "🔍  CONSULTAS\r\n\r\nBúsqueda e historial de guías";
            this.btnConsultas.UseVisualStyleBackColor = false;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            this.btnConsultas.MouseEnter += new System.EventHandler(this.MenuButton_MouseEnter);
            this.btnConsultas.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.BackColor = System.Drawing.Color.FromArgb(0, 60, 110);
            this.btnFacturacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnFacturacion.ForeColor = System.Drawing.Color.White;
            this.btnFacturacion.Location = new System.Drawing.Point(552, 6);
            this.btnFacturacion.Margin = new System.Windows.Forms.Padding(6);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(262, 162);
            this.btnFacturacion.TabIndex = 2;
            this.btnFacturacion.Text = "📋  FACTURACIÓN  ★\r\n\r\nEmisión de guías de embarque";
            this.btnFacturacion.UseVisualStyleBackColor = false;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            this.btnFacturacion.MouseEnter += new System.EventHandler(this.MenuButton_MouseEnter);
            this.btnFacturacion.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            // 
            // btnAnexarFact
            // 
            this.btnAnexarFact.BackColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.btnAnexarFact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnexarFact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnexarFact.FlatAppearance.BorderSize = 0;
            this.btnAnexarFact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnexarFact.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAnexarFact.ForeColor = System.Drawing.Color.White;
            this.btnAnexarFact.Location = new System.Drawing.Point(6, 180);
            this.btnAnexarFact.Margin = new System.Windows.Forms.Padding(6);
            this.btnAnexarFact.Name = "btnAnexarFact";
            this.btnAnexarFact.Size = new System.Drawing.Size(261, 162);
            this.btnAnexarFact.TabIndex = 3;
            this.btnAnexarFact.Text = "📎  ANEXAR FACTURA\r\n\r\nVincular comprobantes fiscales";
            this.btnAnexarFact.UseVisualStyleBackColor = false;
            this.btnAnexarFact.Click += new System.EventHandler(this.btnAnexarFact_Click);
            this.btnAnexarFact.MouseEnter += new System.EventHandler(this.MenuButton_MouseEnter);
            this.btnAnexarFact.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            // 
            // btnReporteGuia
            // 
            this.btnReporteGuia.BackColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.btnReporteGuia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteGuia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReporteGuia.FlatAppearance.BorderSize = 0;
            this.btnReporteGuia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteGuia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReporteGuia.ForeColor = System.Drawing.Color.White;
            this.btnReporteGuia.Location = new System.Drawing.Point(279, 180);
            this.btnReporteGuia.Margin = new System.Windows.Forms.Padding(6);
            this.btnReporteGuia.Name = "btnReporteGuia";
            this.btnReporteGuia.Size = new System.Drawing.Size(261, 162);
            this.btnReporteGuia.TabIndex = 4;
            this.btnReporteGuia.Text = "📊  REPORTE DE GUÍAS\r\n\r\nConcentrado operativo y totales";
            this.btnReporteGuia.UseVisualStyleBackColor = false;
            this.btnReporteGuia.Click += new System.EventHandler(this.btnReporteGuia_Click);
            this.btnReporteGuia.MouseEnter += new System.EventHandler(this.MenuButton_MouseEnter);
            this.btnReporteGuia.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            // 
            // btnFactOtros
            // 
            this.btnFactOtros.BackColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.btnFactOtros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFactOtros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFactOtros.FlatAppearance.BorderSize = 0;
            this.btnFactOtros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactOtros.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFactOtros.ForeColor = System.Drawing.Color.White;
            this.btnFactOtros.Location = new System.Drawing.Point(552, 180);
            this.btnFactOtros.Margin = new System.Windows.Forms.Padding(6);
            this.btnFactOtros.Name = "btnFactOtros";
            this.btnFactOtros.Size = new System.Drawing.Size(262, 162);
            this.btnFactOtros.TabIndex = 5;
            this.btnFactOtros.Text = "📑  FACTURACIÓN OTROS\r\n\r\nServicios especiales y adicionales";
            this.btnFactOtros.UseVisualStyleBackColor = false;
            this.btnFactOtros.Click += new System.EventHandler(this.btnFactOtros_Click);
            this.btnFactOtros.MouseEnter += new System.EventHandler(this.MenuButton_MouseEnter);
            this.btnFactOtros.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            // 
            // lblStatusFooter
            // 
            this.lblStatusFooter.AutoSize = true;
            this.lblStatusFooter.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblStatusFooter.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblStatusFooter.Location = new System.Drawing.Point(22, 471);
            this.lblStatusFooter.Name = "lblStatusFooter";
            this.lblStatusFooter.Size = new System.Drawing.Size(273, 15);
            this.lblStatusFooter.TabIndex = 2;
            this.lblStatusFooter.Text = "🟢 Conexión con el servidor activa • Terminal Moroleón / México";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(640, 461);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(200, 36);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "🚪  Cerrar Sesión  (ESC)";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 243, 246);
            this.ClientSize = new System.Drawing.Size(860, 515);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblStatusFooter);
            this.Controls.Add(this.tlpBotones);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control y Facturación - Autotransportaciones Lucero";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            this.tlpBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Label lblUsuarioRol;
        private System.Windows.Forms.Label lblUsuarioNombre;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnAnexarFact;
        private System.Windows.Forms.Button btnReporteGuia;
        private System.Windows.Forms.Button btnFactOtros;
        private System.Windows.Forms.Label lblStatusFooter;
        private System.Windows.Forms.Button btnSalir;
    }
}

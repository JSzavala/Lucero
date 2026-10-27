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
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnAnexarFact = new System.Windows.Forms.Button();
            this.btnReporteGuia = new System.Windows.Forms.Button();
            this.btnFactOtros = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tlpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBotones
            // 
            this.tlpBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right));
            this.tlpBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.tlpBotones.ColumnCount = 3;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tlpBotones.Controls.Add(this.btnUsuarios, 0, 0);
            this.tlpBotones.Controls.Add(this.btnConsultas, 1, 0);
            this.tlpBotones.Controls.Add(this.btnFacturacion, 2, 0);
            this.tlpBotones.Controls.Add(this.btnAnexarFact, 0, 1);
            this.tlpBotones.Controls.Add(this.btnReporteGuia, 1, 1);
            this.tlpBotones.Controls.Add(this.btnFactOtros, 2, 1);
            this.tlpBotones.Location = new System.Drawing.Point(50, 140);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.Padding = new System.Windows.Forms.Padding(10);
            this.tlpBotones.RowCount = 2;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Size = new System.Drawing.Size(700, 260);
            this.tlpBotones.TabIndex = 0;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsuarios.AutoSize = true;
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(135)))));
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(20, 20);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(10);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(206, 100);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "USUARIOS";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            this.btnUsuarios.MouseEnter += new System.EventHandler(this.MenuButton_MouseEnter);
            this.btnUsuarios.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            // 
            // btnConsultas
            // 
            this.btnConsultas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultas.AutoSize = true;
            this.btnConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(135)))));
            this.btnConsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnConsultas.ForeColor = System.Drawing.Color.White;
            this.btnConsultas.Location = new System.Drawing.Point(246, 20);
            this.btnConsultas.Margin = new System.Windows.Forms.Padding(10);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(206, 100);
            this.btnConsultas.TabIndex = 1;
            this.btnConsultas.Text = "CONSULTAS";
            this.btnConsultas.UseVisualStyleBackColor = false;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            this.btnConsultas.MouseEnter += new System.EventHandler(this.MenuButton_MouseEnter);
            this.btnConsultas.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFacturacion.AutoSize = true;
            this.btnFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(135)))));
            this.btnFacturacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnFacturacion.ForeColor = System.Drawing.Color.White;
            this.btnFacturacion.Location = new System.Drawing.Point(472, 20);
            this.btnFacturacion.Margin = new System.Windows.Forms.Padding(10);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(208, 100);
            this.btnFacturacion.TabIndex = 2;
            this.btnFacturacion.Text = "FACTURACION";
            this.btnFacturacion.UseVisualStyleBackColor = false;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            this.btnFacturacion.MouseEnter += new System.EventHandler(this.MenuButton_MouseEnter);
            this.btnFacturacion.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            // 
            // btnAnexarFact
            // 
            this.btnAnexarFact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnexarFact.AutoSize = true;
            this.btnAnexarFact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(135)))));
            this.btnAnexarFact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnexarFact.FlatAppearance.BorderSize = 0;
            this.btnAnexarFact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnexarFact.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAnexarFact.ForeColor = System.Drawing.Color.White;
            this.btnAnexarFact.Location = new System.Drawing.Point(20, 140);
            this.btnAnexarFact.Margin = new System.Windows.Forms.Padding(10);
            this.btnAnexarFact.Name = "btnAnexarFact";
            this.btnAnexarFact.Size = new System.Drawing.Size(206, 100);
            this.btnAnexarFact.TabIndex = 3;
            this.btnAnexarFact.Text = "ANEXAR FACTURA";
            this.btnAnexarFact.UseVisualStyleBackColor = false;
            this.btnAnexarFact.Click += new System.EventHandler(this.btnAnexarFact_Click);
            this.btnAnexarFact.MouseEnter += new System.EventHandler(this.MenuButton_MouseEnter);
            this.btnAnexarFact.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            // 
            // btnReporteGuia
            // 
            this.btnReporteGuia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReporteGuia.AutoSize = true;
            this.btnReporteGuia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(135)))));
            this.btnReporteGuia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteGuia.FlatAppearance.BorderSize = 0;
            this.btnReporteGuia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteGuia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnReporteGuia.ForeColor = System.Drawing.Color.White;
            this.btnReporteGuia.Location = new System.Drawing.Point(246, 140);
            this.btnReporteGuia.Margin = new System.Windows.Forms.Padding(10);
            this.btnReporteGuia.Name = "btnReporteGuia";
            this.btnReporteGuia.Size = new System.Drawing.Size(206, 100);
            this.btnReporteGuia.TabIndex = 4;
            this.btnReporteGuia.Text = "REPORTE GUIAS";
            this.btnReporteGuia.UseVisualStyleBackColor = false;
            this.btnReporteGuia.Click += new System.EventHandler(this.btnReporteGuia_Click);
            this.btnReporteGuia.MouseEnter += new System.EventHandler(this.MenuButton_MouseEnter);
            this.btnReporteGuia.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            // 
            // btnFactOtros
            // 
            this.btnFactOtros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFactOtros.AutoSize = true;
            this.btnFactOtros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(135)))));
            this.btnFactOtros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFactOtros.FlatAppearance.BorderSize = 0;
            this.btnFactOtros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactOtros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnFactOtros.ForeColor = System.Drawing.Color.White;
            this.btnFactOtros.Location = new System.Drawing.Point(472, 140);
            this.btnFactOtros.Margin = new System.Windows.Forms.Padding(10);
            this.btnFactOtros.Name = "btnFactOtros";
            this.btnFactOtros.Size = new System.Drawing.Size(208, 100);
            this.btnFactOtros.TabIndex = 5;
            this.btnFactOtros.Text = "FACTURACION OTROS";
            this.btnFactOtros.UseVisualStyleBackColor = false;
            this.btnFactOtros.Click += new System.EventHandler(this.btnFactOtros_Click);
            this.btnFactOtros.MouseEnter += new System.EventHandler(this.MenuButton_MouseEnter);
            this.btnFactOtros.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(640, 410);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 30);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(135)))));
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(700, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transportes Lucero";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tlpBotones);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.tlpBotones.ResumeLayout(false);
            this.tlpBotones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnAnexarFact;
        private System.Windows.Forms.Button btnReporteGuia;
        private System.Windows.Forms.Button btnFactOtros;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
    }
}

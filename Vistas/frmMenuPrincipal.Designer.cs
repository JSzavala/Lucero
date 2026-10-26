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
            this.label1 = new System.Windows.Forms.Label();
            this.tlpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBotones
            // 
            this.tlpBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBotones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tlpBotones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
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
            this.tlpBotones.Location = new System.Drawing.Point(57, 188);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 2;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Size = new System.Drawing.Size(680, 219);
            this.tlpBotones.TabIndex = 0;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsuarios.AutoSize = true;
            this.btnUsuarios.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(10, 10);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(10);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(206, 89);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "USUARIOS";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultas.AutoSize = true;
            this.btnConsultas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.Location = new System.Drawing.Point(236, 10);
            this.btnConsultas.Margin = new System.Windows.Forms.Padding(10);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(206, 89);
            this.btnConsultas.TabIndex = 1;
            this.btnConsultas.Text = "CONSULTAS";
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFacturacion.AutoSize = true;
            this.btnFacturacion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.Location = new System.Drawing.Point(462, 10);
            this.btnFacturacion.Margin = new System.Windows.Forms.Padding(10);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(208, 89);
            this.btnFacturacion.TabIndex = 2;
            this.btnFacturacion.Text = "FACTURACION";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // btnAnexarFact
            // 
            this.btnAnexarFact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnexarFact.AutoSize = true;
            this.btnAnexarFact.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnexarFact.Location = new System.Drawing.Point(10, 119);
            this.btnAnexarFact.Margin = new System.Windows.Forms.Padding(10);
            this.btnAnexarFact.Name = "btnAnexarFact";
            this.btnAnexarFact.Size = new System.Drawing.Size(206, 90);
            this.btnAnexarFact.TabIndex = 3;
            this.btnAnexarFact.Text = "ANEXAR FACTURA";
            this.btnAnexarFact.UseVisualStyleBackColor = true;
            this.btnAnexarFact.Click += new System.EventHandler(this.btnAnexarFact_Click);
            // 
            // btnReporteGuia
            // 
            this.btnReporteGuia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReporteGuia.AutoSize = true;
            this.btnReporteGuia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteGuia.Location = new System.Drawing.Point(236, 119);
            this.btnReporteGuia.Margin = new System.Windows.Forms.Padding(10);
            this.btnReporteGuia.Name = "btnReporteGuia";
            this.btnReporteGuia.Size = new System.Drawing.Size(206, 90);
            this.btnReporteGuia.TabIndex = 4;
            this.btnReporteGuia.Text = "REPORTE GUIAS";
            this.btnReporteGuia.UseVisualStyleBackColor = true;
            this.btnReporteGuia.Click += new System.EventHandler(this.btnReporteGuia_Click);
            // 
            // btnFactOtros
            // 
            this.btnFactOtros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFactOtros.AutoSize = true;
            this.btnFactOtros.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactOtros.Location = new System.Drawing.Point(462, 119);
            this.btnFactOtros.Margin = new System.Windows.Forms.Padding(10);
            this.btnFactOtros.Name = "btnFactOtros";
            this.btnFactOtros.Size = new System.Drawing.Size(208, 90);
            this.btnFactOtros.TabIndex = 5;
            this.btnFactOtros.Text = "FACTURACION OTROS";
            this.btnFactOtros.UseVisualStyleBackColor = true;
            this.btnFactOtros.Click += new System.EventHandler(this.btnFactOtros_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transportes Lucero";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tlpBotones);
            this.Name = "frmMenuPrincipal";
            this.Text = "MenuPrincipal";
            this.tlpBotones.ResumeLayout(false);
            this.tlpBotones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnAnexarFact;
        private System.Windows.Forms.Button btnReporteGuia;
        private System.Windows.Forms.Button btnFactOtros;
        private System.Windows.Forms.Label label1;
    }
}
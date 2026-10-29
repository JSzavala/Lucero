using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lucero.Vistas
{
    public partial class frmFacturacion : Form
    {
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tctLugar = new System.Windows.Forms.TextBox();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtRemitente = new System.Windows.Forms.TextBox();
            this.txtDomicilioremitente = new System.Windows.Forms.TextBox();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.txtValorUnitarioPorCuota = new System.Windows.Forms.TextBox();
            this.txtSerecogeraen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSeEntregaraEn = new System.Windows.Forms.TextBox();
            this.txtDomicilioDestinarario = new System.Windows.Forms.TextBox();
            this.txtRFCDestinatario = new System.Windows.Forms.TextBox();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbDDF = new System.Windows.Forms.RadioButton();
            this.rbLibre = new System.Windows.Forms.RadioButton();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.rbNoiva = new System.Windows.Forms.RadioButton();
            this.rbSiIVA = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.txtEmbalaje = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.rbPorCobrar = new System.Windows.Forms.RadioButton();
            this.rbPagado = new System.Windows.Forms.RadioButton();
            this.label22 = new System.Windows.Forms.Label();
            this.txtValorDeclarado = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtFlete = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtManiobras = new System.Windows.Forms.TextBox();
            this.txtCobroPorSeguro = new System.Windows.Forms.TextBox();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.txtOtros = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtALYT = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtRetenerIVA = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.txtObservacionesDDF = new System.Windows.Forms.TextBox();
            this.txtReembarco = new System.Windows.Forms.TextBox();
            this.txtCondujo = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.txtConducira = new System.Windows.Forms.TextBox();
            this.txtReembarcarseCon = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.rbSeguroNoPagado = new System.Windows.Forms.RadioButton();
            this.rbSeguroPagado = new System.Windows.Forms.RadioButton();
            this.rbMexico = new System.Windows.Forms.RadioButton();
            this.rbChinconcuac = new System.Windows.Forms.RadioButton();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "FECHA";
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFecha.Location = new System.Drawing.Point(109, 44);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(113, 30);
            this.txtFecha.TabIndex = 1;
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLugar.Location = new System.Drawing.Point(244, 47);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(79, 25);
            this.lblLugar.TabIndex = 2;
            this.lblLugar.Text = "LUGAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(504, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "FOLIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(767, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "DESTINO";
            // 
            // tctLugar
            // 
            this.tctLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tctLugar.Location = new System.Drawing.Point(329, 44);
            this.tctLugar.Name = "tctLugar";
            this.tctLugar.Size = new System.Drawing.Size(152, 30);
            this.tctLugar.TabIndex = 5;
            // 
            // txtFolio
            // 
            this.txtFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFolio.Location = new System.Drawing.Point(582, 47);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(152, 30);
            this.txtFolio.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(23, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "ORIGEN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(23, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "REMITENTE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(23, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "R.F.C";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(23, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "SE RECOGERÁ EN:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(23, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "DOMICILIO";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtOrigen
            // 
            this.txtOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtOrigen.Location = new System.Drawing.Point(167, 97);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(404, 30);
            this.txtOrigen.TabIndex = 12;
            // 
            // txtRemitente
            // 
            this.txtRemitente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRemitente.Location = new System.Drawing.Point(167, 140);
            this.txtRemitente.Name = "txtRemitente";
            this.txtRemitente.Size = new System.Drawing.Size(404, 30);
            this.txtRemitente.TabIndex = 13;
            // 
            // txtDomicilioremitente
            // 
            this.txtDomicilioremitente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDomicilioremitente.Location = new System.Drawing.Point(167, 224);
            this.txtDomicilioremitente.Name = "txtDomicilioremitente";
            this.txtDomicilioremitente.Size = new System.Drawing.Size(404, 30);
            this.txtDomicilioremitente.TabIndex = 15;
            this.txtDomicilioremitente.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtRFC
            // 
            this.txtRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRFC.Location = new System.Drawing.Point(167, 182);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(404, 30);
            this.txtRFC.TabIndex = 14;
            this.txtRFC.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtValorUnitarioPorCuota
            // 
            this.txtValorUnitarioPorCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtValorUnitarioPorCuota.Location = new System.Drawing.Point(329, 311);
            this.txtValorUnitarioPorCuota.Name = "txtValorUnitarioPorCuota";
            this.txtValorUnitarioPorCuota.Size = new System.Drawing.Size(164, 30);
            this.txtValorUnitarioPorCuota.TabIndex = 17;
            // 
            // txtSerecogeraen
            // 
            this.txtSerecogeraen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSerecogeraen.Location = new System.Drawing.Point(223, 265);
            this.txtSerecogeraen.Name = "txtSerecogeraen";
            this.txtSerecogeraen.Size = new System.Drawing.Size(348, 30);
            this.txtSerecogeraen.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(624, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "SE ENTREGARÁ EN:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(624, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "DOMICILIO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(624, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "R.F.C";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(624, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 25);
            this.label12.TabIndex = 19;
            this.label12.Text = "DESTINATARIO";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(624, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 25);
            this.label13.TabIndex = 18;
            this.label13.Text = "DESTINO";
            // 
            // txtSeEntregaraEn
            // 
            this.txtSeEntregaraEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSeEntregaraEn.Location = new System.Drawing.Point(834, 265);
            this.txtSeEntregaraEn.Name = "txtSeEntregaraEn";
            this.txtSeEntregaraEn.Size = new System.Drawing.Size(357, 30);
            this.txtSeEntregaraEn.TabIndex = 27;
            // 
            // txtDomicilioDestinarario
            // 
            this.txtDomicilioDestinarario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDomicilioDestinarario.Location = new System.Drawing.Point(787, 224);
            this.txtDomicilioDestinarario.Name = "txtDomicilioDestinarario";
            this.txtDomicilioDestinarario.Size = new System.Drawing.Size(404, 30);
            this.txtDomicilioDestinarario.TabIndex = 26;
            // 
            // txtRFCDestinatario
            // 
            this.txtRFCDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRFCDestinatario.Location = new System.Drawing.Point(787, 182);
            this.txtRFCDestinatario.Name = "txtRFCDestinatario";
            this.txtRFCDestinatario.Size = new System.Drawing.Size(404, 30);
            this.txtRFCDestinatario.TabIndex = 25;
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDestinatario.Location = new System.Drawing.Point(787, 140);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(404, 30);
            this.txtDestinatario.TabIndex = 24;
            // 
            // txtDestino
            // 
            this.txtDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDestino.Location = new System.Drawing.Point(787, 97);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(404, 30);
            this.txtDestino.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(18, 316);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(303, 25);
            this.label14.TabIndex = 28;
            this.label14.Text = "VALOR UNITARIO POR CUOTA";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(508, 398);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 25);
            this.label15.TabIndex = 29;
            this.label15.Text = "PESO";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.Location = new System.Drawing.Point(18, 396);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 25);
            this.label16.TabIndex = 30;
            this.label16.Text = "RET. IVA";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label17.Location = new System.Drawing.Point(19, 355);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 25);
            this.label17.TabIndex = 31;
            this.label17.Text = "TIPO";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label18.Location = new System.Drawing.Point(267, 357);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 25);
            this.label18.TabIndex = 32;
            this.label18.Text = "NUM.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label19.Location = new System.Drawing.Point(508, 358);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(132, 25);
            this.label19.TabIndex = 33;
            this.label19.Text = "CONTENIDO";
            // 
            // txtContenido
            // 
            this.txtContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtContenido.Location = new System.Drawing.Point(646, 353);
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(236, 30);
            this.txtContenido.TabIndex = 34;
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPeso.Location = new System.Drawing.Point(647, 396);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(235, 30);
            this.txtPeso.TabIndex = 35;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(0, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 20);
            this.radioButton1.TabIndex = 36;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 435);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(932, 187);
            this.dataGridView1.TabIndex = 39;
            // 
            // rbDDF
            // 
            this.rbDDF.AutoSize = true;
            this.rbDDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbDDF.Location = new System.Drawing.Point(74, 353);
            this.rbDDF.Name = "rbDDF";
            this.rbDDF.Size = new System.Drawing.Size(83, 29);
            this.rbDDF.TabIndex = 40;
            this.rbDDF.TabStop = true;
            this.rbDDF.Text = "D.D.F";
            this.rbDDF.UseVisualStyleBackColor = true;
            this.rbDDF.CheckedChanged += new System.EventHandler(this.rbDDF_CheckedChanged);
            // 
            // rbLibre
            // 
            this.rbLibre.AutoSize = true;
            this.rbLibre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbLibre.Location = new System.Drawing.Point(173, 353);
            this.rbLibre.Name = "rbLibre";
            this.rbLibre.Size = new System.Drawing.Size(88, 29);
            this.rbLibre.TabIndex = 41;
            this.rbLibre.TabStop = true;
            this.rbLibre.Text = "LIBRE";
            this.rbLibre.UseVisualStyleBackColor = true;
            this.rbLibre.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNum.Location = new System.Drawing.Point(330, 355);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(163, 30);
            this.txtNum.TabIndex = 42;
            // 
            // rbNoiva
            // 
            this.rbNoiva.AutoSize = true;
            this.rbNoiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbNoiva.Location = new System.Drawing.Point(104, 394);
            this.rbNoiva.Name = "rbNoiva";
            this.rbNoiva.Size = new System.Drawing.Size(63, 29);
            this.rbNoiva.TabIndex = 43;
            this.rbNoiva.TabStop = true;
            this.rbNoiva.Text = "NO";
            this.rbNoiva.UseVisualStyleBackColor = true;
            // 
            // rbSiIVA
            // 
            this.rbSiIVA.AutoSize = true;
            this.rbSiIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbSiIVA.Location = new System.Drawing.Point(173, 394);
            this.rbSiIVA.Name = "rbSiIVA";
            this.rbSiIVA.Size = new System.Drawing.Size(52, 29);
            this.rbSiIVA.TabIndex = 44;
            this.rbSiIVA.TabStop = true;
            this.rbSiIVA.Text = "SÍ";
            this.rbSiIVA.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label20.Location = new System.Drawing.Point(231, 394);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(118, 25);
            this.label20.TabIndex = 45;
            this.label20.Text = "EMBALAJE";
            // 
            // txtEmbalaje
            // 
            this.txtEmbalaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmbalaje.Location = new System.Drawing.Point(358, 396);
            this.txtEmbalaje.Name = "txtEmbalaje";
            this.txtEmbalaje.Size = new System.Drawing.Size(135, 30);
            this.txtEmbalaje.TabIndex = 46;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label21.Location = new System.Drawing.Point(508, 314);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 25);
            this.label21.TabIndex = 47;
            this.label21.Text = "FLETE";
            // 
            // rbPorCobrar
            // 
            this.rbPorCobrar.AutoSize = true;
            this.rbPorCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbPorCobrar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.rbPorCobrar.Location = new System.Drawing.Point(593, 312);
            this.rbPorCobrar.Name = "rbPorCobrar";
            this.rbPorCobrar.Size = new System.Drawing.Size(164, 29);
            this.rbPorCobrar.TabIndex = 48;
            this.rbPorCobrar.TabStop = true;
            this.rbPorCobrar.Text = "POR COBRAR";
            this.rbPorCobrar.UseVisualStyleBackColor = true;
            // 
            // rbPagado
            // 
            this.rbPagado.AutoSize = true;
            this.rbPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbPagado.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.rbPagado.Location = new System.Drawing.Point(763, 312);
            this.rbPagado.Name = "rbPagado";
            this.rbPagado.Size = new System.Drawing.Size(119, 29);
            this.rbPagado.TabIndex = 49;
            this.rbPagado.TabStop = true;
            this.rbPagado.Text = "PAGADO";
            this.rbPagado.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label22.Location = new System.Drawing.Point(922, 314);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(209, 25);
            this.label22.TabIndex = 50;
            this.label22.Text = "VALOR DECLARADO";
            // 
            // txtValorDeclarado
            // 
            this.txtValorDeclarado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtValorDeclarado.Location = new System.Drawing.Point(1137, 311);
            this.txtValorDeclarado.Name = "txtValorDeclarado";
            this.txtValorDeclarado.Size = new System.Drawing.Size(136, 30);
            this.txtValorDeclarado.TabIndex = 51;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label23.Location = new System.Drawing.Point(1057, 349);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(74, 25);
            this.label23.TabIndex = 52;
            this.label23.Text = "FLETE";
            // 
            // txtFlete
            // 
            this.txtFlete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFlete.Location = new System.Drawing.Point(1137, 349);
            this.txtFlete.Name = "txtFlete";
            this.txtFlete.Size = new System.Drawing.Size(136, 30);
            this.txtFlete.TabIndex = 53;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label24.Location = new System.Drawing.Point(999, 429);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(132, 25);
            this.label24.TabIndex = 55;
            this.label24.Text = "MANIOBRAS";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label25.Location = new System.Drawing.Point(994, 388);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(137, 25);
            this.label25.TabIndex = 54;
            this.label25.Text = "C. x SEGURO";
            // 
            // txtManiobras
            // 
            this.txtManiobras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtManiobras.Location = new System.Drawing.Point(1137, 426);
            this.txtManiobras.Name = "txtManiobras";
            this.txtManiobras.Size = new System.Drawing.Size(136, 30);
            this.txtManiobras.TabIndex = 57;
            // 
            // txtCobroPorSeguro
            // 
            this.txtCobroPorSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCobroPorSeguro.Location = new System.Drawing.Point(1137, 387);
            this.txtCobroPorSeguro.Name = "txtCobroPorSeguro";
            this.txtCobroPorSeguro.Size = new System.Drawing.Size(136, 30);
            this.txtCobroPorSeguro.TabIndex = 56;
            // 
            // txtSuma
            // 
            this.txtSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSuma.Location = new System.Drawing.Point(1137, 544);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(136, 30);
            this.txtSuma.TabIndex = 63;
            // 
            // txtOtros
            // 
            this.txtOtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtOtros.Location = new System.Drawing.Point(1137, 505);
            this.txtOtros.Name = "txtOtros";
            this.txtOtros.Size = new System.Drawing.Size(136, 30);
            this.txtOtros.TabIndex = 62;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label26.Location = new System.Drawing.Point(1060, 547);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(71, 25);
            this.label26.TabIndex = 61;
            this.label26.Text = "SUMA";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label27.Location = new System.Drawing.Point(1047, 510);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(84, 25);
            this.label27.TabIndex = 60;
            this.label27.Text = "OTROS";
            // 
            // txtALYT
            // 
            this.txtALYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtALYT.Location = new System.Drawing.Point(1137, 467);
            this.txtALYT.Name = "txtALYT";
            this.txtALYT.Size = new System.Drawing.Size(136, 30);
            this.txtALYT.TabIndex = 59;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label28.Location = new System.Drawing.Point(1057, 467);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(78, 25);
            this.label28.TabIndex = 58;
            this.label28.Text = "A.L.Y.T";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTotal.Location = new System.Drawing.Point(1137, 704);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(136, 30);
            this.txtTotal.TabIndex = 71;
            // 
            // txtRetenerIVA
            // 
            this.txtRetenerIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRetenerIVA.Location = new System.Drawing.Point(1137, 665);
            this.txtRetenerIVA.Name = "txtRetenerIVA";
            this.txtRetenerIVA.Size = new System.Drawing.Size(136, 30);
            this.txtRetenerIVA.TabIndex = 70;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label29.Location = new System.Drawing.Point(1052, 707);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(79, 25);
            this.label29.TabIndex = 69;
            this.label29.Text = "TOTAL";
            this.label29.Click += new System.EventHandler(this.label29_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label30.Location = new System.Drawing.Point(1010, 670);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(121, 25);
            this.label30.TabIndex = 68;
            this.label30.Text = "RETEN. IVA";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSubtotal.Location = new System.Drawing.Point(1137, 627);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(136, 30);
            this.txtSubtotal.TabIndex = 67;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label31.Location = new System.Drawing.Point(1011, 632);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(120, 25);
            this.label31.TabIndex = 66;
            this.label31.Text = "SUBTOTAL";
            // 
            // txtIVA
            // 
            this.txtIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtIVA.Location = new System.Drawing.Point(1137, 586);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(136, 30);
            this.txtIVA.TabIndex = 65;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label32.Location = new System.Drawing.Point(1086, 586);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(45, 25);
            this.label32.TabIndex = 64;
            this.label32.Text = "IVA";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label33.Location = new System.Drawing.Point(23, 637);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(145, 25);
            this.label33.TabIndex = 72;
            this.label33.Text = "OBSERV. DDF";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label34.Location = new System.Drawing.Point(23, 672);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(139, 25);
            this.label34.TabIndex = 73;
            this.label34.Text = "REEMBARCO";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label35.Location = new System.Drawing.Point(23, 708);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(112, 25);
            this.label35.TabIndex = 74;
            this.label35.Text = "CONDUJO";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label36.Location = new System.Drawing.Point(499, 637);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(186, 25);
            this.label36.TabIndex = 75;
            this.label36.Text = "OBSERVACIONES";
            // 
            // txtObservacionesDDF
            // 
            this.txtObservacionesDDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtObservacionesDDF.Location = new System.Drawing.Point(173, 635);
            this.txtObservacionesDDF.Name = "txtObservacionesDDF";
            this.txtObservacionesDDF.Size = new System.Drawing.Size(320, 30);
            this.txtObservacionesDDF.TabIndex = 76;
            // 
            // txtReembarco
            // 
            this.txtReembarco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtReembarco.Location = new System.Drawing.Point(173, 672);
            this.txtReembarco.Name = "txtReembarco";
            this.txtReembarco.Size = new System.Drawing.Size(320, 30);
            this.txtReembarco.TabIndex = 77;
            // 
            // txtCondujo
            // 
            this.txtCondujo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCondujo.Location = new System.Drawing.Point(173, 711);
            this.txtCondujo.Name = "txtCondujo";
            this.txtCondujo.Size = new System.Drawing.Size(320, 30);
            this.txtCondujo.TabIndex = 78;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtObservaciones.Location = new System.Drawing.Point(684, 637);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(309, 30);
            this.txtObservaciones.TabIndex = 79;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label37.Location = new System.Drawing.Point(499, 677);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(227, 25);
            this.label37.TabIndex = 80;
            this.label37.Text = "REEMBARCARSE CON";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label38.Location = new System.Drawing.Point(504, 716);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(132, 25);
            this.label38.TabIndex = 81;
            this.label38.Text = "CONDUCIRÁ";
            // 
            // txtConducira
            // 
            this.txtConducira.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtConducira.Location = new System.Drawing.Point(642, 713);
            this.txtConducira.Name = "txtConducira";
            this.txtConducira.Size = new System.Drawing.Size(351, 30);
            this.txtConducira.TabIndex = 83;
            // 
            // txtReembarcarseCon
            // 
            this.txtReembarcarseCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtReembarcarseCon.Location = new System.Drawing.Point(732, 674);
            this.txtReembarcarseCon.Name = "txtReembarcarseCon";
            this.txtReembarcarseCon.Size = new System.Drawing.Size(261, 30);
            this.txtReembarcarseCon.TabIndex = 82;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label39.Location = new System.Drawing.Point(27, 755);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(102, 25);
            this.label39.TabIndex = 84;
            this.label39.Text = "USUARIO";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label40.Location = new System.Drawing.Point(401, 757);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(97, 25);
            this.label40.TabIndex = 85;
            this.label40.Text = "SEGURO";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUsuario.Location = new System.Drawing.Point(167, 752);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(135, 30);
            this.txtUsuario.TabIndex = 86;
            // 
            // rbSeguroNoPagado
            // 
            this.rbSeguroNoPagado.AutoSize = true;
            this.rbSeguroNoPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbSeguroNoPagado.Location = new System.Drawing.Point(508, 757);
            this.rbSeguroNoPagado.Name = "rbSeguroNoPagado";
            this.rbSeguroNoPagado.Size = new System.Drawing.Size(154, 29);
            this.rbSeguroNoPagado.TabIndex = 87;
            this.rbSeguroNoPagado.TabStop = true;
            this.rbSeguroNoPagado.Text = "NO PAGADO";
            this.rbSeguroNoPagado.UseVisualStyleBackColor = true;
            // 
            // rbSeguroPagado
            // 
            this.rbSeguroPagado.AutoSize = true;
            this.rbSeguroPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbSeguroPagado.Location = new System.Drawing.Point(669, 757);
            this.rbSeguroPagado.Name = "rbSeguroPagado";
            this.rbSeguroPagado.Size = new System.Drawing.Size(119, 29);
            this.rbSeguroPagado.TabIndex = 88;
            this.rbSeguroPagado.TabStop = true;
            this.rbSeguroPagado.Text = "PAGADO";
            this.rbSeguroPagado.UseVisualStyleBackColor = true;
            this.rbSeguroPagado.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // rbMexico
            // 
            this.rbMexico.AutoSize = true;
            this.rbMexico.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.rbMexico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbMexico.Location = new System.Drawing.Point(887, 48);
            this.rbMexico.Name = "rbMexico";
            this.rbMexico.Size = new System.Drawing.Size(113, 29);
            this.rbMexico.TabIndex = 89;
            this.rbMexico.TabStop = true;
            this.rbMexico.Text = "MÉXICO";
            this.rbMexico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbMexico.UseVisualStyleBackColor = true;
            // 
            // rbChinconcuac
            // 
            this.rbChinconcuac.AutoSize = true;
            this.rbChinconcuac.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.rbChinconcuac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbChinconcuac.Location = new System.Drawing.Point(1006, 50);
            this.rbChinconcuac.Name = "rbChinconcuac";
            this.rbChinconcuac.Size = new System.Drawing.Size(184, 29);
            this.rbChinconcuac.TabIndex = 90;
            this.rbChinconcuac.TabStop = true;
            this.rbChinconcuac.Text = "CHINCONCUAC";
            this.rbChinconcuac.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGrabar.Location = new System.Drawing.Point(1028, 744);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(102, 34);
            this.btnGrabar.TabIndex = 91;
            this.btnGrabar.Text = "GRABAR";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSalir.Location = new System.Drawing.Point(1159, 744);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 34);
            this.btnSalir.TabIndex = 92;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(1030, 784);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 33);
            this.button1.TabIndex = 93;
            this.button1.Text = "ELIMINAR RENGLON";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmFacturacion
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1285, 819);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.rbChinconcuac);
            this.Controls.Add(this.rbMexico);
            this.Controls.Add(this.rbSeguroPagado);
            this.Controls.Add(this.rbSeguroNoPagado);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.txtConducira);
            this.Controls.Add(this.txtReembarcarseCon);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtCondujo);
            this.Controls.Add(this.txtReembarco);
            this.Controls.Add(this.txtObservacionesDDF);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtRetenerIVA);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.txtOtros);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtALYT);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.txtManiobras);
            this.Controls.Add(this.txtCobroPorSeguro);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtFlete);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtValorDeclarado);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.rbPagado);
            this.Controls.Add(this.rbPorCobrar);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtEmbalaje);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.rbSiIVA);
            this.Controls.Add(this.rbNoiva);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.rbLibre);
            this.Controls.Add(this.rbDDF);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtSeEntregaraEn);
            this.Controls.Add(this.txtDomicilioDestinarario);
            this.Controls.Add(this.txtRFCDestinatario);
            this.Controls.Add(this.txtDestinatario);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtValorUnitarioPorCuota);
            this.Controls.Add(this.txtSerecogeraen);
            this.Controls.Add(this.txtDomicilioremitente);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.txtRemitente);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFolio);
            this.Controls.Add(this.tctLugar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label1);
            this.Name = "frmFacturacion";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
        private TextBox txtFecha;
        private Label lblLugar;
        private Label label2;
        private Label label3;
        private TextBox tctLugar;
        private TextBox txtFolio;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtOrigen;
        private TextBox txtRemitente;
        private TextBox txtDomicilioremitente;
        private TextBox txtRFC;
        private TextBox txtValorUnitarioPorCuota;
        private TextBox txtSerecogeraen;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtSeEntregaraEn;
        private TextBox txtDomicilioDestinarario;
        private TextBox txtRFCDestinatario;
        private TextBox txtDestinatario;
        private TextBox txtDestino;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private TextBox txtContenido;
        private TextBox txtPeso;
        private RadioButton radioButton1;
        private DataGridView dataGridView1;
        private RadioButton rbDDF;
        private RadioButton rbLibre;
        private TextBox txtNum;
        private RadioButton rbNoiva;
        private RadioButton rbSiIVA;
        private Label label20;
        private TextBox txtEmbalaje;
        private Label label21;
        private RadioButton rbPorCobrar;
        private RadioButton rbPagado;
        private Label label22;
        private TextBox txtValorDeclarado;
        private Label label23;
        private TextBox txtFlete;
        private Label label24;
        private Label label25;
        private TextBox txtManiobras;
        private TextBox txtCobroPorSeguro;
        private TextBox txtSuma;
        private TextBox txtOtros;
        private Label label26;
        private Label label27;
        private TextBox txtALYT;
        private Label label28;
        private TextBox txtTotal;
        private TextBox txtRetenerIVA;
        private Label label29;
        private Label label30;
        private TextBox txtSubtotal;
        private Label label31;
        private TextBox txtIVA;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label36;
        private TextBox txtObservacionesDDF;
        private TextBox txtReembarco;
        private TextBox txtCondujo;
        private TextBox txtObservaciones;
        private Label label37;
        private Label label38;
        private TextBox txtConducira;
        private TextBox txtReembarcarseCon;
        private Label label39;
        private Label label40;
        private TextBox txtUsuario;
        private RadioButton rbSeguroNoPagado;
        private RadioButton rbSeguroPagado;
        private RadioButton rbMexico;
        private RadioButton rbChinconcuac;
        private Button btnGrabar;
        private Button btnSalir;
        private Button button1;
    }
}
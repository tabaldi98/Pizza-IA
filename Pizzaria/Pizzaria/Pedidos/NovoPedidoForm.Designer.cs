﻿namespace Pizzaria.Pedidos
{
    partial class NovoPedidoForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxBebida = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.dgResumo = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBoxTroco = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBoxPagamento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxTroco = new System.Windows.Forms.CheckBox();
            this.groupBebida = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tamanhoLata = new System.Windows.Forms.RadioButton();
            this.tamanhoGarrafa = new System.Windows.Forms.RadioButton();
            this.tamanhoLitrão = new System.Windows.Forms.RadioButton();
            this.tamanhoLitro = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tamanhoPequena = new System.Windows.Forms.RadioButton();
            this.tamanhoExtraGigante = new System.Windows.Forms.RadioButton();
            this.tamanhoMedia = new System.Windows.Forms.RadioButton();
            this.tamanhoGigante = new System.Windows.Forms.RadioButton();
            this.tamanhoGrande = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResumo)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBoxTroco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBebida.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxBebida);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.groupBox11);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.groupBox9);
            this.groupBox1.Controls.Add(this.groupBebida);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 616);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Pedido";
            // 
            // checkBoxBebida
            // 
            this.checkBoxBebida.AutoSize = true;
            this.checkBoxBebida.Location = new System.Drawing.Point(6, 293);
            this.checkBoxBebida.Name = "checkBoxBebida";
            this.checkBoxBebida.Size = new System.Drawing.Size(65, 17);
            this.checkBoxBebida.TabIndex = 0;
            this.checkBoxBebida.Text = "Bebida?";
            this.checkBoxBebida.UseVisualStyleBackColor = true;
            this.checkBoxBebida.CheckedChanged += new System.EventHandler(this.checkBoxBebida_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(499, 583);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "50";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.dgResumo);
            this.groupBox11.Location = new System.Drawing.Point(6, 489);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(541, 98);
            this.groupBox11.TabIndex = 4;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Resumo";
            // 
            // dgResumo
            // 
            this.dgResumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResumo.Location = new System.Drawing.Point(6, 19);
            this.dgResumo.Name = "dgResumo";
            this.dgResumo.Size = new System.Drawing.Size(525, 72);
            this.dgResumo.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(388, 590);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Total: R$ ";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.groupBoxTroco);
            this.groupBox9.Controls.Add(this.comboBoxPagamento);
            this.groupBox9.Controls.Add(this.label5);
            this.groupBox9.Controls.Add(this.checkBoxTroco);
            this.groupBox9.Location = new System.Drawing.Point(342, 304);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(195, 179);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Pagamento";
            // 
            // groupBoxTroco
            // 
            this.groupBoxTroco.Controls.Add(this.label9);
            this.groupBoxTroco.Controls.Add(this.label6);
            this.groupBoxTroco.Controls.Add(this.label7);
            this.groupBoxTroco.Controls.Add(this.numericUpDown1);
            this.groupBoxTroco.Location = new System.Drawing.Point(11, 87);
            this.groupBoxTroco.Name = "groupBoxTroco";
            this.groupBoxTroco.Size = new System.Drawing.Size(178, 83);
            this.groupBoxTroco.TabIndex = 7;
            this.groupBoxTroco.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(92, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "50";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Para Quanto: R$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Devolver: R$ ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(96, 16);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(78, 20);
            this.numericUpDown1.TabIndex = 11;
            // 
            // comboBoxPagamento
            // 
            this.comboBoxPagamento.FormattingEnabled = true;
            this.comboBoxPagamento.Location = new System.Drawing.Point(11, 37);
            this.comboBoxPagamento.Name = "comboBoxPagamento";
            this.comboBoxPagamento.Size = new System.Drawing.Size(178, 21);
            this.comboBoxPagamento.TabIndex = 6;
            this.comboBoxPagamento.SelectedIndexChanged += new System.EventHandler(this.comboBoxPagamento_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo";
            // 
            // checkBoxTroco
            // 
            this.checkBoxTroco.AutoSize = true;
            this.checkBoxTroco.Location = new System.Drawing.Point(11, 64);
            this.checkBoxTroco.Name = "checkBoxTroco";
            this.checkBoxTroco.Size = new System.Drawing.Size(60, 17);
            this.checkBoxTroco.TabIndex = 9;
            this.checkBoxTroco.Text = "Troco?";
            this.checkBoxTroco.UseVisualStyleBackColor = true;
            this.checkBoxTroco.CheckedChanged += new System.EventHandler(this.checkBoxTroco_CheckedChanged);
            // 
            // groupBebida
            // 
            this.groupBebida.Controls.Add(this.groupBox8);
            this.groupBebida.Controls.Add(this.groupBox7);
            this.groupBebida.Location = new System.Drawing.Point(6, 304);
            this.groupBebida.Name = "groupBebida";
            this.groupBebida.Size = new System.Drawing.Size(330, 179);
            this.groupBebida.TabIndex = 2;
            this.groupBebida.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.comboBox8);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Location = new System.Drawing.Point(139, 18);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(179, 144);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Sabores";
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(10, 42);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(158, 21);
            this.comboBox8.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sabor 1";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tamanhoLata);
            this.groupBox7.Controls.Add(this.tamanhoGarrafa);
            this.groupBox7.Controls.Add(this.tamanhoLitrão);
            this.groupBox7.Controls.Add(this.tamanhoLitro);
            this.groupBox7.Location = new System.Drawing.Point(6, 18);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(127, 147);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tamanho";
            // 
            // tamanhoLata
            // 
            this.tamanhoLata.AutoSize = true;
            this.tamanhoLata.Location = new System.Drawing.Point(19, 19);
            this.tamanhoLata.Name = "tamanhoLata";
            this.tamanhoLata.Size = new System.Drawing.Size(46, 17);
            this.tamanhoLata.TabIndex = 0;
            this.tamanhoLata.Text = "Lata";
            this.tamanhoLata.UseVisualStyleBackColor = true;
            this.tamanhoLata.CheckedChanged += new System.EventHandler(this.tamanhoLata_CheckedChanged);
            // 
            // tamanhoGarrafa
            // 
            this.tamanhoGarrafa.AutoSize = true;
            this.tamanhoGarrafa.Location = new System.Drawing.Point(19, 42);
            this.tamanhoGarrafa.Name = "tamanhoGarrafa";
            this.tamanhoGarrafa.Size = new System.Drawing.Size(60, 17);
            this.tamanhoGarrafa.TabIndex = 1;
            this.tamanhoGarrafa.Text = "Garrafa";
            this.tamanhoGarrafa.UseVisualStyleBackColor = true;
            this.tamanhoGarrafa.CheckedChanged += new System.EventHandler(this.tamanhoGarrafa_CheckedChanged);
            // 
            // tamanhoLitrão
            // 
            this.tamanhoLitrão.AutoSize = true;
            this.tamanhoLitrão.Checked = true;
            this.tamanhoLitrão.Location = new System.Drawing.Point(19, 88);
            this.tamanhoLitrão.Name = "tamanhoLitrão";
            this.tamanhoLitrão.Size = new System.Drawing.Size(51, 17);
            this.tamanhoLitrão.TabIndex = 3;
            this.tamanhoLitrão.TabStop = true;
            this.tamanhoLitrão.Text = "Litrão";
            this.tamanhoLitrão.UseVisualStyleBackColor = true;
            this.tamanhoLitrão.CheckedChanged += new System.EventHandler(this.tamanhoLitrão_CheckedChanged);
            // 
            // tamanhoLitro
            // 
            this.tamanhoLitro.AutoSize = true;
            this.tamanhoLitro.Location = new System.Drawing.Point(19, 65);
            this.tamanhoLitro.Name = "tamanhoLitro";
            this.tamanhoLitro.Size = new System.Drawing.Size(45, 17);
            this.tamanhoLitro.TabIndex = 2;
            this.tamanhoLitro.Text = "Litro";
            this.tamanhoLitro.UseVisualStyleBackColor = true;
            this.tamanhoLitro.CheckedChanged += new System.EventHandler(this.tamanhoLitro_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(6, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(531, 179);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pizza";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBox4);
            this.groupBox5.Controls.Add(this.comboBox3);
            this.groupBox5.Controls.Add(this.comboBox2);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(149, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(372, 147);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sabores";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(198, 104);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(158, 21);
            this.comboBox4.TabIndex = 7;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(10, 104);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(158, 21);
            this.comboBox3.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(198, 42);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(158, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sabor 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sabor 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sabor 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sabor 1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tamanhoPequena);
            this.groupBox4.Controls.Add(this.tamanhoExtraGigante);
            this.groupBox4.Controls.Add(this.tamanhoMedia);
            this.groupBox4.Controls.Add(this.tamanhoGigante);
            this.groupBox4.Controls.Add(this.tamanhoGrande);
            this.groupBox4.Location = new System.Drawing.Point(15, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(127, 147);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tamanho";
            // 
            // tamanhoPequena
            // 
            this.tamanhoPequena.AutoSize = true;
            this.tamanhoPequena.Location = new System.Drawing.Point(19, 19);
            this.tamanhoPequena.Name = "tamanhoPequena";
            this.tamanhoPequena.Size = new System.Drawing.Size(68, 17);
            this.tamanhoPequena.TabIndex = 0;
            this.tamanhoPequena.Text = "Pequena";
            this.tamanhoPequena.UseVisualStyleBackColor = true;
            this.tamanhoPequena.CheckedChanged += new System.EventHandler(this.tamanhoPequena_CheckedChanged);
            // 
            // tamanhoExtraGigante
            // 
            this.tamanhoExtraGigante.AutoSize = true;
            this.tamanhoExtraGigante.Location = new System.Drawing.Point(19, 111);
            this.tamanhoExtraGigante.Name = "tamanhoExtraGigante";
            this.tamanhoExtraGigante.Size = new System.Drawing.Size(89, 17);
            this.tamanhoExtraGigante.TabIndex = 4;
            this.tamanhoExtraGigante.Text = "Extra Gigante";
            this.tamanhoExtraGigante.UseVisualStyleBackColor = true;
            this.tamanhoExtraGigante.CheckedChanged += new System.EventHandler(this.tamanhoExtraGigante_CheckedChanged);
            // 
            // tamanhoMedia
            // 
            this.tamanhoMedia.AutoSize = true;
            this.tamanhoMedia.Location = new System.Drawing.Point(19, 42);
            this.tamanhoMedia.Name = "tamanhoMedia";
            this.tamanhoMedia.Size = new System.Drawing.Size(54, 17);
            this.tamanhoMedia.TabIndex = 1;
            this.tamanhoMedia.Text = "Media";
            this.tamanhoMedia.UseVisualStyleBackColor = true;
            this.tamanhoMedia.CheckedChanged += new System.EventHandler(this.tamanhoMedia_CheckedChanged);
            // 
            // tamanhoGigante
            // 
            this.tamanhoGigante.AutoSize = true;
            this.tamanhoGigante.Checked = true;
            this.tamanhoGigante.Location = new System.Drawing.Point(19, 88);
            this.tamanhoGigante.Name = "tamanhoGigante";
            this.tamanhoGigante.Size = new System.Drawing.Size(62, 17);
            this.tamanhoGigante.TabIndex = 3;
            this.tamanhoGigante.TabStop = true;
            this.tamanhoGigante.Text = "Gigante";
            this.tamanhoGigante.UseVisualStyleBackColor = true;
            this.tamanhoGigante.CheckedChanged += new System.EventHandler(this.tamanhoGigante_CheckedChanged);
            // 
            // tamanhoGrande
            // 
            this.tamanhoGrande.AutoSize = true;
            this.tamanhoGrande.Location = new System.Drawing.Point(19, 65);
            this.tamanhoGrande.Name = "tamanhoGrande";
            this.tamanhoGrande.Size = new System.Drawing.Size(60, 17);
            this.tamanhoGrande.TabIndex = 2;
            this.tamanhoGrande.Text = "Grande";
            this.tamanhoGrande.UseVisualStyleBackColor = true;
            this.tamanhoGrande.CheckedChanged += new System.EventHandler(this.tamanhoGrande_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtNomeCliente);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 80);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Selecionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Location = new System.Drawing.Point(6, 31);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(387, 20);
            this.txtNomeCliente.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(489, 631);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Finalizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(411, 631);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // NovoPedidoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 666);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NovoPedidoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovoPedidoForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgResumo)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBoxTroco.ResumeLayout(false);
            this.groupBoxTroco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBebida.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBoxTroco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxTroco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBoxPagamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBebida;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton tamanhoLata;
        private System.Windows.Forms.RadioButton tamanhoGarrafa;
        private System.Windows.Forms.RadioButton tamanhoLitrão;
        private System.Windows.Forms.RadioButton tamanhoLitro;
        private System.Windows.Forms.CheckBox checkBoxBebida;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton tamanhoPequena;
        private System.Windows.Forms.RadioButton tamanhoExtraGigante;
        private System.Windows.Forms.RadioButton tamanhoMedia;
        private System.Windows.Forms.RadioButton tamanhoGigante;
        private System.Windows.Forms.RadioButton tamanhoGrande;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgResumo;
    }
}
namespace Pizzaria.Features.Bebidas
{
    partial class BebidaPopUp
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
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.valorLitrao = new System.Windows.Forms.NumericUpDown();
            this.labelValorLitrao = new System.Windows.Forms.Label();
            this.valorLitro = new System.Windows.Forms.NumericUpDown();
            this.labelValorLitro = new System.Windows.Forms.Label();
            this.valorGarrafa = new System.Windows.Forms.NumericUpDown();
            this.labelValorGarrafa = new System.Windows.Forms.Label();
            this.valorLata = new System.Windows.Forms.NumericUpDown();
            this.labelValorLata = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxLitrao = new System.Windows.Forms.CheckBox();
            this.checkBoxLitro = new System.Windows.Forms.CheckBox();
            this.checkBoxGarrafa = new System.Windows.Forms.CheckBox();
            this.checkBoxLata = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSabor = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valorLitrao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorLitro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorGarrafa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorLata)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSalvar.Location = new System.Drawing.Point(172, 294);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 9;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(253, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.valorLitrao);
            this.groupBox3.Controls.Add(this.labelValorLitrao);
            this.groupBox3.Controls.Add(this.valorLitro);
            this.groupBox3.Controls.Add(this.labelValorLitro);
            this.groupBox3.Controls.Add(this.valorGarrafa);
            this.groupBox3.Controls.Add(this.labelValorGarrafa);
            this.groupBox3.Controls.Add(this.valorLata);
            this.groupBox3.Controls.Add(this.labelValorLata);
            this.groupBox3.Location = new System.Drawing.Point(13, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 115);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Valor";
            // 
            // valorLitrao
            // 
            this.valorLitrao.DecimalPlaces = 2;
            this.valorLitrao.Location = new System.Drawing.Point(110, 76);
            this.valorLitrao.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.valorLitrao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valorLitrao.Name = "valorLitrao";
            this.valorLitrao.Size = new System.Drawing.Size(74, 20);
            this.valorLitrao.TabIndex = 7;
            this.valorLitrao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valorLitrao.Visible = false;
            // 
            // labelValorLitrao
            // 
            this.labelValorLitrao.AutoSize = true;
            this.labelValorLitrao.Location = new System.Drawing.Point(107, 59);
            this.labelValorLitrao.Name = "labelValorLitrao";
            this.labelValorLitrao.Size = new System.Drawing.Size(60, 13);
            this.labelValorLitrao.TabIndex = 6;
            this.labelValorLitrao.Text = "Valor Litrao";
            this.labelValorLitrao.Visible = false;
            // 
            // valorLitro
            // 
            this.valorLitro.DecimalPlaces = 2;
            this.valorLitro.Location = new System.Drawing.Point(9, 76);
            this.valorLitro.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.valorLitro.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valorLitro.Name = "valorLitro";
            this.valorLitro.Size = new System.Drawing.Size(74, 20);
            this.valorLitro.TabIndex = 5;
            this.valorLitro.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valorLitro.Visible = false;
            // 
            // labelValorLitro
            // 
            this.labelValorLitro.AutoSize = true;
            this.labelValorLitro.Location = new System.Drawing.Point(6, 59);
            this.labelValorLitro.Name = "labelValorLitro";
            this.labelValorLitro.Size = new System.Drawing.Size(54, 13);
            this.labelValorLitro.TabIndex = 4;
            this.labelValorLitro.Text = "Valor Litro";
            this.labelValorLitro.Visible = false;
            // 
            // valorGarrafa
            // 
            this.valorGarrafa.DecimalPlaces = 2;
            this.valorGarrafa.Location = new System.Drawing.Point(110, 33);
            this.valorGarrafa.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.valorGarrafa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valorGarrafa.Name = "valorGarrafa";
            this.valorGarrafa.Size = new System.Drawing.Size(74, 20);
            this.valorGarrafa.TabIndex = 3;
            this.valorGarrafa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valorGarrafa.Visible = false;
            // 
            // labelValorGarrafa
            // 
            this.labelValorGarrafa.AutoSize = true;
            this.labelValorGarrafa.Location = new System.Drawing.Point(107, 16);
            this.labelValorGarrafa.Name = "labelValorGarrafa";
            this.labelValorGarrafa.Size = new System.Drawing.Size(69, 13);
            this.labelValorGarrafa.TabIndex = 2;
            this.labelValorGarrafa.Text = "Valor Garrafa";
            this.labelValorGarrafa.Visible = false;
            // 
            // valorLata
            // 
            this.valorLata.DecimalPlaces = 2;
            this.valorLata.Location = new System.Drawing.Point(9, 33);
            this.valorLata.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.valorLata.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valorLata.Name = "valorLata";
            this.valorLata.Size = new System.Drawing.Size(74, 20);
            this.valorLata.TabIndex = 1;
            this.valorLata.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valorLata.Visible = false;
            // 
            // labelValorLata
            // 
            this.labelValorLata.AutoSize = true;
            this.labelValorLata.Location = new System.Drawing.Point(6, 16);
            this.labelValorLata.Name = "labelValorLata";
            this.labelValorLata.Size = new System.Drawing.Size(55, 13);
            this.labelValorLata.TabIndex = 0;
            this.labelValorLata.Text = "Valor Lata";
            this.labelValorLata.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxLitrao);
            this.groupBox2.Controls.Add(this.checkBoxLitro);
            this.groupBox2.Controls.Add(this.checkBoxGarrafa);
            this.groupBox2.Controls.Add(this.checkBoxLata);
            this.groupBox2.Location = new System.Drawing.Point(11, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 72);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tamanhos";
            // 
            // checkBoxLitrao
            // 
            this.checkBoxLitrao.AutoSize = true;
            this.checkBoxLitrao.Location = new System.Drawing.Point(112, 41);
            this.checkBoxLitrao.Name = "checkBoxLitrao";
            this.checkBoxLitrao.Size = new System.Drawing.Size(52, 17);
            this.checkBoxLitrao.TabIndex = 4;
            this.checkBoxLitrao.Text = "Litrão";
            this.checkBoxLitrao.UseVisualStyleBackColor = true;
            this.checkBoxLitrao.CheckedChanged += new System.EventHandler(this.checkBoxLitrao_CheckedChanged);
            // 
            // checkBoxLitro
            // 
            this.checkBoxLitro.AutoSize = true;
            this.checkBoxLitro.Location = new System.Drawing.Point(112, 19);
            this.checkBoxLitro.Name = "checkBoxLitro";
            this.checkBoxLitro.Size = new System.Drawing.Size(46, 17);
            this.checkBoxLitro.TabIndex = 3;
            this.checkBoxLitro.Text = "Litro";
            this.checkBoxLitro.UseVisualStyleBackColor = true;
            this.checkBoxLitro.CheckedChanged += new System.EventHandler(this.checkBoxLitro_CheckedChanged);
            // 
            // checkBoxGarrafa
            // 
            this.checkBoxGarrafa.AutoSize = true;
            this.checkBoxGarrafa.Location = new System.Drawing.Point(6, 41);
            this.checkBoxGarrafa.Name = "checkBoxGarrafa";
            this.checkBoxGarrafa.Size = new System.Drawing.Size(61, 17);
            this.checkBoxGarrafa.TabIndex = 1;
            this.checkBoxGarrafa.Text = "Garrafa";
            this.checkBoxGarrafa.UseVisualStyleBackColor = true;
            this.checkBoxGarrafa.CheckedChanged += new System.EventHandler(this.checkBoxGarrafa_CheckedChanged);
            // 
            // checkBoxLata
            // 
            this.checkBoxLata.AutoSize = true;
            this.checkBoxLata.Location = new System.Drawing.Point(6, 19);
            this.checkBoxLata.Name = "checkBoxLata";
            this.checkBoxLata.Size = new System.Drawing.Size(47, 17);
            this.checkBoxLata.TabIndex = 0;
            this.checkBoxLata.Text = "Lata";
            this.checkBoxLata.UseVisualStyleBackColor = true;
            this.checkBoxLata.CheckedChanged += new System.EventHandler(this.checkBoxLata_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxSabor);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 73);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sabor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione o sabor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Selecionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSabor
            // 
            this.textBoxSabor.Enabled = false;
            this.textBoxSabor.Location = new System.Drawing.Point(6, 31);
            this.textBoxSabor.Name = "textBoxSabor";
            this.textBoxSabor.Size = new System.Drawing.Size(205, 20);
            this.textBoxSabor.TabIndex = 0;
            // 
            // BebidaPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 334);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BebidaPopUp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bebidas";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valorLitrao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorLitro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorGarrafa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorLata)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown valorLitrao;
        private System.Windows.Forms.Label labelValorLitrao;
        private System.Windows.Forms.NumericUpDown valorLitro;
        private System.Windows.Forms.Label labelValorLitro;
        private System.Windows.Forms.NumericUpDown valorGarrafa;
        private System.Windows.Forms.Label labelValorGarrafa;
        private System.Windows.Forms.NumericUpDown valorLata;
        private System.Windows.Forms.Label labelValorLata;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxLitrao;
        private System.Windows.Forms.CheckBox checkBoxLitro;
        private System.Windows.Forms.CheckBox checkBoxGarrafa;
        private System.Windows.Forms.CheckBox checkBoxLata;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxSabor;
    }
}
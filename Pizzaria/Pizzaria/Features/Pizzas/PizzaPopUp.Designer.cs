namespace Pizzaria.Features.Pizzas
{
    partial class PizzaPopUp
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
            this.textBoxSabor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxPequena = new System.Windows.Forms.CheckBox();
            this.checkBoxMedia = new System.Windows.Forms.CheckBox();
            this.checkBoxGrande = new System.Windows.Forms.CheckBox();
            this.checkBoxGigante = new System.Windows.Forms.CheckBox();
            this.checkBoxExtraGigante = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelValorPequena = new System.Windows.Forms.Label();
            this.valorPequena = new System.Windows.Forms.NumericUpDown();
            this.labelValorMedia = new System.Windows.Forms.Label();
            this.valorMedia = new System.Windows.Forms.NumericUpDown();
            this.labelValorGrande = new System.Windows.Forms.Label();
            this.valorGrande = new System.Windows.Forms.NumericUpDown();
            this.labelValorGigante = new System.Windows.Forms.Label();
            this.valorGigante = new System.Windows.Forms.NumericUpDown();
            this.labelValorExtraGigante = new System.Windows.Forms.Label();
            this.valorExtraGigante = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valorPequena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorMedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorGrande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorGigante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorExtraGigante)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSabor
            // 
            this.textBoxSabor.Enabled = false;
            this.textBoxSabor.Location = new System.Drawing.Point(6, 31);
            this.textBoxSabor.Name = "textBoxSabor";
            this.textBoxSabor.Size = new System.Drawing.Size(205, 20);
            this.textBoxSabor.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione o sabor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxSabor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sabor";
            // 
            // checkBoxPequena
            // 
            this.checkBoxPequena.AutoSize = true;
            this.checkBoxPequena.Location = new System.Drawing.Point(6, 19);
            this.checkBoxPequena.Name = "checkBoxPequena";
            this.checkBoxPequena.Size = new System.Drawing.Size(69, 17);
            this.checkBoxPequena.TabIndex = 0;
            this.checkBoxPequena.Text = "Pequena";
            this.checkBoxPequena.UseVisualStyleBackColor = true;
            this.checkBoxPequena.CheckedChanged += new System.EventHandler(this.checkBoxPequena_CheckedChanged);
            // 
            // checkBoxMedia
            // 
            this.checkBoxMedia.AutoSize = true;
            this.checkBoxMedia.Location = new System.Drawing.Point(6, 41);
            this.checkBoxMedia.Name = "checkBoxMedia";
            this.checkBoxMedia.Size = new System.Drawing.Size(55, 17);
            this.checkBoxMedia.TabIndex = 1;
            this.checkBoxMedia.Text = "Média";
            this.checkBoxMedia.UseVisualStyleBackColor = true;
            this.checkBoxMedia.CheckedChanged += new System.EventHandler(this.checkBoxMedia_CheckedChanged);
            // 
            // checkBoxGrande
            // 
            this.checkBoxGrande.AutoSize = true;
            this.checkBoxGrande.Location = new System.Drawing.Point(6, 64);
            this.checkBoxGrande.Name = "checkBoxGrande";
            this.checkBoxGrande.Size = new System.Drawing.Size(61, 17);
            this.checkBoxGrande.TabIndex = 2;
            this.checkBoxGrande.Text = "Grande";
            this.checkBoxGrande.UseVisualStyleBackColor = true;
            this.checkBoxGrande.CheckedChanged += new System.EventHandler(this.checkBoxGrande_CheckedChanged);
            // 
            // checkBoxGigante
            // 
            this.checkBoxGigante.AutoSize = true;
            this.checkBoxGigante.Location = new System.Drawing.Point(112, 19);
            this.checkBoxGigante.Name = "checkBoxGigante";
            this.checkBoxGigante.Size = new System.Drawing.Size(63, 17);
            this.checkBoxGigante.TabIndex = 3;
            this.checkBoxGigante.Text = "Gigante";
            this.checkBoxGigante.UseVisualStyleBackColor = true;
            this.checkBoxGigante.CheckedChanged += new System.EventHandler(this.checkBoxGigante_CheckedChanged);
            // 
            // checkBoxExtraGigante
            // 
            this.checkBoxExtraGigante.AutoSize = true;
            this.checkBoxExtraGigante.Location = new System.Drawing.Point(112, 41);
            this.checkBoxExtraGigante.Name = "checkBoxExtraGigante";
            this.checkBoxExtraGigante.Size = new System.Drawing.Size(90, 17);
            this.checkBoxExtraGigante.TabIndex = 4;
            this.checkBoxExtraGigante.Text = "Extra Gigante";
            this.checkBoxExtraGigante.UseVisualStyleBackColor = true;
            this.checkBoxExtraGigante.CheckedChanged += new System.EventHandler(this.checkBoxExtraGigante_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxExtraGigante);
            this.groupBox2.Controls.Add(this.checkBoxGigante);
            this.groupBox2.Controls.Add(this.checkBoxGrande);
            this.groupBox2.Controls.Add(this.checkBoxMedia);
            this.groupBox2.Controls.Add(this.checkBoxPequena);
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 91);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tamanhos";
            // 
            // labelValorPequena
            // 
            this.labelValorPequena.AutoSize = true;
            this.labelValorPequena.Location = new System.Drawing.Point(6, 16);
            this.labelValorPequena.Name = "labelValorPequena";
            this.labelValorPequena.Size = new System.Drawing.Size(77, 13);
            this.labelValorPequena.TabIndex = 0;
            this.labelValorPequena.Text = "Valor Pequena";
            this.labelValorPequena.Visible = false;
            // 
            // valorPequena
            // 
            this.valorPequena.DecimalPlaces = 2;
            this.valorPequena.Location = new System.Drawing.Point(9, 33);
            this.valorPequena.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.valorPequena.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valorPequena.Name = "valorPequena";
            this.valorPequena.Size = new System.Drawing.Size(74, 20);
            this.valorPequena.TabIndex = 1;
            this.valorPequena.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valorPequena.Visible = false;
            // 
            // labelValorMedia
            // 
            this.labelValorMedia.AutoSize = true;
            this.labelValorMedia.Location = new System.Drawing.Point(107, 16);
            this.labelValorMedia.Name = "labelValorMedia";
            this.labelValorMedia.Size = new System.Drawing.Size(63, 13);
            this.labelValorMedia.TabIndex = 2;
            this.labelValorMedia.Text = "Valor Média";
            this.labelValorMedia.Visible = false;
            // 
            // valorMedia
            // 
            this.valorMedia.DecimalPlaces = 2;
            this.valorMedia.Location = new System.Drawing.Point(110, 33);
            this.valorMedia.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.valorMedia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valorMedia.Name = "valorMedia";
            this.valorMedia.Size = new System.Drawing.Size(74, 20);
            this.valorMedia.TabIndex = 3;
            this.valorMedia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valorMedia.Visible = false;
            // 
            // labelValorGrande
            // 
            this.labelValorGrande.AutoSize = true;
            this.labelValorGrande.Location = new System.Drawing.Point(6, 59);
            this.labelValorGrande.Name = "labelValorGrande";
            this.labelValorGrande.Size = new System.Drawing.Size(69, 13);
            this.labelValorGrande.TabIndex = 4;
            this.labelValorGrande.Text = "Valor Grande";
            this.labelValorGrande.Visible = false;
            // 
            // valorGrande
            // 
            this.valorGrande.DecimalPlaces = 2;
            this.valorGrande.Location = new System.Drawing.Point(9, 76);
            this.valorGrande.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.valorGrande.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valorGrande.Name = "valorGrande";
            this.valorGrande.Size = new System.Drawing.Size(74, 20);
            this.valorGrande.TabIndex = 5;
            this.valorGrande.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valorGrande.Visible = false;
            // 
            // labelValorGigante
            // 
            this.labelValorGigante.AutoSize = true;
            this.labelValorGigante.Location = new System.Drawing.Point(107, 59);
            this.labelValorGigante.Name = "labelValorGigante";
            this.labelValorGigante.Size = new System.Drawing.Size(71, 13);
            this.labelValorGigante.TabIndex = 6;
            this.labelValorGigante.Text = "Valor Gigante";
            this.labelValorGigante.Visible = false;
            // 
            // valorGigante
            // 
            this.valorGigante.DecimalPlaces = 2;
            this.valorGigante.Location = new System.Drawing.Point(110, 76);
            this.valorGigante.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.valorGigante.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valorGigante.Name = "valorGigante";
            this.valorGigante.Size = new System.Drawing.Size(74, 20);
            this.valorGigante.TabIndex = 7;
            this.valorGigante.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valorGigante.Visible = false;
            // 
            // labelValorExtraGigante
            // 
            this.labelValorExtraGigante.AutoSize = true;
            this.labelValorExtraGigante.Location = new System.Drawing.Point(6, 105);
            this.labelValorExtraGigante.Name = "labelValorExtraGigante";
            this.labelValorExtraGigante.Size = new System.Drawing.Size(98, 13);
            this.labelValorExtraGigante.TabIndex = 8;
            this.labelValorExtraGigante.Text = "Valor Extra Gigante";
            this.labelValorExtraGigante.Visible = false;
            // 
            // valorExtraGigante
            // 
            this.valorExtraGigante.DecimalPlaces = 2;
            this.valorExtraGigante.Location = new System.Drawing.Point(9, 122);
            this.valorExtraGigante.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.valorExtraGigante.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valorExtraGigante.Name = "valorExtraGigante";
            this.valorExtraGigante.Size = new System.Drawing.Size(74, 20);
            this.valorExtraGigante.TabIndex = 9;
            this.valorExtraGigante.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valorExtraGigante.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.valorExtraGigante);
            this.groupBox3.Controls.Add(this.labelValorExtraGigante);
            this.groupBox3.Controls.Add(this.valorGigante);
            this.groupBox3.Controls.Add(this.labelValorGigante);
            this.groupBox3.Controls.Add(this.valorGrande);
            this.groupBox3.Controls.Add(this.labelValorGrande);
            this.groupBox3.Controls.Add(this.valorMedia);
            this.groupBox3.Controls.Add(this.labelValorMedia);
            this.groupBox3.Controls.Add(this.valorPequena);
            this.groupBox3.Controls.Add(this.labelValorPequena);
            this.groupBox3.Location = new System.Drawing.Point(14, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 148);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Valor";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(254, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSalvar.Location = new System.Drawing.Point(173, 342);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 4;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.button3_Click);
            // 
            // PizzaPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 407);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PizzaPopUp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizzas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valorPequena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorMedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorGrande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorGigante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorExtraGigante)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSabor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxPequena;
        private System.Windows.Forms.CheckBox checkBoxMedia;
        private System.Windows.Forms.CheckBox checkBoxGrande;
        private System.Windows.Forms.CheckBox checkBoxGigante;
        private System.Windows.Forms.CheckBox checkBoxExtraGigante;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelValorPequena;
        private System.Windows.Forms.NumericUpDown valorPequena;
        private System.Windows.Forms.Label labelValorMedia;
        private System.Windows.Forms.NumericUpDown valorMedia;
        private System.Windows.Forms.Label labelValorGrande;
        private System.Windows.Forms.NumericUpDown valorGrande;
        private System.Windows.Forms.Label labelValorGigante;
        private System.Windows.Forms.NumericUpDown valorGigante;
        private System.Windows.Forms.Label labelValorExtraGigante;
        private System.Windows.Forms.NumericUpDown valorExtraGigante;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonSalvar;
    }
}
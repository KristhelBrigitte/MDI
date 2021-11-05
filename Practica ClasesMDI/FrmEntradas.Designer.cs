
namespace Practica_ClasesMDI
{
    partial class FrmEntradas
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAme = new System.Windows.Forms.TextBox();
            this.lblValorGram = new System.Windows.Forms.Label();
            this.lblValorVIP = new System.Windows.Forms.Label();
            this.lblValorGen = new System.Windows.Forms.Label();
            this.txtGeneral = new System.Windows.Forms.TextBox();
            this.lblGeneral = new System.Windows.Forms.Label();
            this.lblGramilla = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGramilla = new System.Windows.Forms.TextBox();
            this.txtVIP = new System.Windows.Forms.TextBox();
            this.txtCostoGen = new System.Windows.Forms.TextBox();
            this.txtCostoGram = new System.Windows.Forms.TextBox();
            this.txtCostoVIP = new System.Windows.Forms.TextBox();
            this.txtNombreEv = new System.Windows.Forms.TextBox();
            this.txtEvento = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCrear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCrear.Location = new System.Drawing.Point(205, 277);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(100, 35);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAme);
            this.groupBox1.Controls.Add(this.lblValorGram);
            this.groupBox1.Controls.Add(this.btnCrear);
            this.groupBox1.Controls.Add(this.lblValorVIP);
            this.groupBox1.Controls.Add(this.lblValorGen);
            this.groupBox1.Controls.Add(this.txtGeneral);
            this.groupBox1.Controls.Add(this.lblGeneral);
            this.groupBox1.Controls.Add(this.lblGramilla);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGramilla);
            this.groupBox1.Controls.Add(this.txtVIP);
            this.groupBox1.Controls.Add(this.txtCostoGen);
            this.groupBox1.Controls.Add(this.txtCostoGram);
            this.groupBox1.Controls.Add(this.txtCostoVIP);
            this.groupBox1.Location = new System.Drawing.Point(49, 115);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(525, 342);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Definir cantidad de entradas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cantidad de amenidades:";
            // 
            // txtAme
            // 
            this.txtAme.Location = new System.Drawing.Point(345, 229);
            this.txtAme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAme.Name = "txtAme";
            this.txtAme.Size = new System.Drawing.Size(132, 25);
            this.txtAme.TabIndex = 13;
            this.txtAme.Text = "5";
            // 
            // lblValorGram
            // 
            this.lblValorGram.AutoSize = true;
            this.lblValorGram.Location = new System.Drawing.Point(191, 124);
            this.lblValorGram.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorGram.Name = "lblValorGram";
            this.lblValorGram.Size = new System.Drawing.Size(40, 20);
            this.lblValorGram.TabIndex = 6;
            this.lblValorGram.Text = "Valor";
            // 
            // lblValorVIP
            // 
            this.lblValorVIP.AutoSize = true;
            this.lblValorVIP.Location = new System.Drawing.Point(341, 124);
            this.lblValorVIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorVIP.Name = "lblValorVIP";
            this.lblValorVIP.Size = new System.Drawing.Size(40, 20);
            this.lblValorVIP.TabIndex = 7;
            this.lblValorVIP.Text = "Valor";
            // 
            // lblValorGen
            // 
            this.lblValorGen.AutoSize = true;
            this.lblValorGen.Location = new System.Drawing.Point(19, 124);
            this.lblValorGen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorGen.Name = "lblValorGen";
            this.lblValorGen.Size = new System.Drawing.Size(40, 20);
            this.lblValorGen.TabIndex = 5;
            this.lblValorGen.Text = "Valor";
            // 
            // txtGeneral
            // 
            this.txtGeneral.Location = new System.Drawing.Point(23, 69);
            this.txtGeneral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGeneral.Name = "txtGeneral";
            this.txtGeneral.Size = new System.Drawing.Size(132, 25);
            this.txtGeneral.TabIndex = 12;
            this.txtGeneral.Text = "2000";
            // 
            // lblGeneral
            // 
            this.lblGeneral.AutoSize = true;
            this.lblGeneral.Location = new System.Drawing.Point(19, 45);
            this.lblGeneral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.Size = new System.Drawing.Size(57, 20);
            this.lblGeneral.TabIndex = 2;
            this.lblGeneral.Text = "General";
            // 
            // lblGramilla
            // 
            this.lblGramilla.AutoSize = true;
            this.lblGramilla.Location = new System.Drawing.Point(191, 45);
            this.lblGramilla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGramilla.Name = "lblGramilla";
            this.lblGramilla.Size = new System.Drawing.Size(61, 20);
            this.lblGramilla.TabIndex = 3;
            this.lblGramilla.Text = "Gramilla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "PalcoVIP";
            // 
            // txtGramilla
            // 
            this.txtGramilla.Location = new System.Drawing.Point(183, 69);
            this.txtGramilla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGramilla.Name = "txtGramilla";
            this.txtGramilla.Size = new System.Drawing.Size(132, 25);
            this.txtGramilla.TabIndex = 11;
            this.txtGramilla.Text = "1500";
            // 
            // txtVIP
            // 
            this.txtVIP.Location = new System.Drawing.Point(345, 69);
            this.txtVIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVIP.Name = "txtVIP";
            this.txtVIP.Size = new System.Drawing.Size(132, 25);
            this.txtVIP.TabIndex = 10;
            this.txtVIP.Text = "1000";
            // 
            // txtCostoGen
            // 
            this.txtCostoGen.Location = new System.Drawing.Point(23, 148);
            this.txtCostoGen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCostoGen.Name = "txtCostoGen";
            this.txtCostoGen.Size = new System.Drawing.Size(132, 25);
            this.txtCostoGen.TabIndex = 9;
            this.txtCostoGen.Text = "75000";
            // 
            // txtCostoGram
            // 
            this.txtCostoGram.Location = new System.Drawing.Point(183, 148);
            this.txtCostoGram.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCostoGram.Name = "txtCostoGram";
            this.txtCostoGram.Size = new System.Drawing.Size(132, 25);
            this.txtCostoGram.TabIndex = 8;
            this.txtCostoGram.Text = "125000";
            // 
            // txtCostoVIP
            // 
            this.txtCostoVIP.Location = new System.Drawing.Point(345, 148);
            this.txtCostoVIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCostoVIP.Name = "txtCostoVIP";
            this.txtCostoVIP.Size = new System.Drawing.Size(132, 25);
            this.txtCostoVIP.TabIndex = 7;
            this.txtCostoVIP.Text = "250000";
            // 
            // txtNombreEv
            // 
            this.txtNombreEv.Location = new System.Drawing.Point(49, 80);
            this.txtNombreEv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreEv.Name = "txtNombreEv";
            this.txtNombreEv.Size = new System.Drawing.Size(477, 25);
            this.txtNombreEv.TabIndex = 13;
            this.txtNombreEv.Text = "Cold Play";
            // 
            // txtEvento
            // 
            this.txtEvento.AutoSize = true;
            this.txtEvento.Location = new System.Drawing.Point(45, 55);
            this.txtEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(127, 20);
            this.txtEvento.TabIndex = 14;
            this.txtEvento.Text = "Nombre del evento:";
            // 
            // FrmEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(616, 466);
            this.Controls.Add(this.txtEvento);
            this.Controls.Add(this.txtNombreEv);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEntradas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblValorVIP;
        private System.Windows.Forms.TextBox txtGeneral;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGramilla;
        private System.Windows.Forms.TextBox txtVIP;
        private System.Windows.Forms.TextBox txtCostoGen;
        private System.Windows.Forms.TextBox txtCostoGram;
        private System.Windows.Forms.TextBox txtCostoVIP;
        private System.Windows.Forms.Label lblGeneral;
        private System.Windows.Forms.Label lblGramilla;
        private System.Windows.Forms.Label lblValorGen;
        private System.Windows.Forms.Label lblValorGram;
        private System.Windows.Forms.TextBox txtNombreEv;
        private System.Windows.Forms.Label txtEvento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAme;
    }
}
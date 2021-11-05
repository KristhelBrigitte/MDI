
namespace Practica_ClasesMDI
{
    partial class FrmAsignar
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
            this.btnGeneral = new System.Windows.Forms.Button();
            this.btnGramilla = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtUna = new System.Windows.Forms.RadioButton();
            this.rbtDos = new System.Windows.Forms.RadioButton();
            this.rbtTres = new System.Windows.Forms.RadioButton();
            this.gbxCantidad = new System.Windows.Forms.GroupBox();
            this.btnVip = new System.Windows.Forms.Button();
            this.gbxCantidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGeneral
            // 
            this.btnGeneral.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnGeneral.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGeneral.Image = global::Practica_ClasesMDI.Properties.Resources.download1;
            this.btnGeneral.Location = new System.Drawing.Point(54, 251);
            this.btnGeneral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(205, 216);
            this.btnGeneral.TabIndex = 0;
            this.btnGeneral.Text = "Gramilla";
            this.btnGeneral.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnGeneral.UseVisualStyleBackColor = false;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // btnGramilla
            // 
            this.btnGramilla.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnGramilla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGramilla.Image = global::Practica_ClasesMDI.Properties.Resources.download1;
            this.btnGramilla.Location = new System.Drawing.Point(320, 251);
            this.btnGramilla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGramilla.Name = "btnGramilla";
            this.btnGramilla.Size = new System.Drawing.Size(206, 216);
            this.btnGramilla.TabIndex = 1;
            this.btnGramilla.Text = "General";
            this.btnGramilla.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnGramilla.UseVisualStyleBackColor = false;
            this.btnGramilla.Click += new System.EventHandler(this.btnGramilla_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(197, 72);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(184, 25);
            this.txtCedula.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite la identificación del cliente:";
            // 
            // rbtUna
            // 
            this.rbtUna.AutoSize = true;
            this.rbtUna.Location = new System.Drawing.Point(28, 62);
            this.rbtUna.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtUna.Name = "rbtUna";
            this.rbtUna.Size = new System.Drawing.Size(34, 24);
            this.rbtUna.TabIndex = 5;
            this.rbtUna.TabStop = true;
            this.rbtUna.Text = "1";
            this.rbtUna.UseVisualStyleBackColor = true;
            // 
            // rbtDos
            // 
            this.rbtDos.AutoSize = true;
            this.rbtDos.Location = new System.Drawing.Point(213, 62);
            this.rbtDos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtDos.Name = "rbtDos";
            this.rbtDos.Size = new System.Drawing.Size(34, 24);
            this.rbtDos.TabIndex = 6;
            this.rbtDos.TabStop = true;
            this.rbtDos.Text = "2";
            this.rbtDos.UseVisualStyleBackColor = true;
            // 
            // rbtTres
            // 
            this.rbtTres.AutoSize = true;
            this.rbtTres.Location = new System.Drawing.Point(392, 62);
            this.rbtTres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtTres.Name = "rbtTres";
            this.rbtTres.Size = new System.Drawing.Size(34, 24);
            this.rbtTres.TabIndex = 7;
            this.rbtTres.TabStop = true;
            this.rbtTres.Text = "3";
            this.rbtTres.UseVisualStyleBackColor = true;
            // 
            // gbxCantidad
            // 
            this.gbxCantidad.Controls.Add(this.rbtTres);
            this.gbxCantidad.Controls.Add(this.rbtUna);
            this.gbxCantidad.Controls.Add(this.rbtDos);
            this.gbxCantidad.Location = new System.Drawing.Point(197, 107);
            this.gbxCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxCantidad.Name = "gbxCantidad";
            this.gbxCantidad.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxCantidad.Size = new System.Drawing.Size(505, 134);
            this.gbxCantidad.TabIndex = 8;
            this.gbxCantidad.TabStop = false;
            this.gbxCantidad.Text = "Defina la cantidad de entradas:";
            // 
            // btnVip
            // 
            this.btnVip.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnVip.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVip.Image = global::Practica_ClasesMDI.Properties.Resources.download1;
            this.btnVip.Location = new System.Drawing.Point(589, 251);
            this.btnVip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVip.Name = "btnVip";
            this.btnVip.Size = new System.Drawing.Size(206, 216);
            this.btnVip.TabIndex = 2;
            this.btnVip.Text = "PalcoVIP";
            this.btnVip.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVip.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnVip.UseVisualStyleBackColor = false;
            this.btnVip.Click += new System.EventHandler(this.btnVip_Click);
            // 
            // FrmAsignar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(862, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.btnVip);
            this.Controls.Add(this.btnGramilla);
            this.Controls.Add(this.btnGeneral);
            this.Controls.Add(this.gbxCantidad);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAsignar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar";
            this.gbxCantidad.ResumeLayout(false);
            this.gbxCantidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Button btnGramilla;
        private System.Windows.Forms.Button btnVip;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtUna;
        private System.Windows.Forms.RadioButton rbtDos;
        private System.Windows.Forms.RadioButton rbtTres;
        private System.Windows.Forms.GroupBox gbxCantidad;
    }
}
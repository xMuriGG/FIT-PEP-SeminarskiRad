namespace CZE_Desktop.Forms.Certifikati_kandidata
{
    partial class CertifikatiKandidataCreate
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
            this.GrupaKandidati_i = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Biljeske_i = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DatumOdobrenja_i = new System.Windows.Forms.DateTimePicker();
            this.btn_Snimi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GrupaKandidati_i
            // 
            this.GrupaKandidati_i.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.GrupaKandidati_i.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.GrupaKandidati_i.Enabled = false;
            this.GrupaKandidati_i.FormattingEnabled = true;
            this.GrupaKandidati_i.Location = new System.Drawing.Point(157, 58);
            this.GrupaKandidati_i.Name = "GrupaKandidati_i";
            this.GrupaKandidati_i.Size = new System.Drawing.Size(273, 21);
            this.GrupaKandidati_i.TabIndex = 28;
            this.GrupaKandidati_i.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Datum odobrenja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Grupa kandidata";
            // 
            // Biljeske_i
            // 
            this.Biljeske_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Biljeske_i.Location = new System.Drawing.Point(157, 127);
            this.Biljeske_i.Multiline = true;
            this.Biljeske_i.Name = "Biljeske_i";
            this.Biljeske_i.Size = new System.Drawing.Size(273, 126);
            this.Biljeske_i.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Bilješke";
            // 
            // DatumOdobrenja_i
            // 
            this.DatumOdobrenja_i.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatumOdobrenja_i.Location = new System.Drawing.Point(157, 91);
            this.DatumOdobrenja_i.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.DatumOdobrenja_i.Name = "DatumOdobrenja_i";
            this.DatumOdobrenja_i.Size = new System.Drawing.Size(156, 20);
            this.DatumOdobrenja_i.TabIndex = 0;
            // 
            // btn_Snimi
            // 
            this.btn_Snimi.Location = new System.Drawing.Point(64, 346);
            this.btn_Snimi.Name = "btn_Snimi";
            this.btn_Snimi.Size = new System.Drawing.Size(75, 23);
            this.btn_Snimi.TabIndex = 2;
            this.btn_Snimi.Text = "Snimi";
            this.btn_Snimi.UseVisualStyleBackColor = true;
            this.btn_Snimi.Click += new System.EventHandler(this.btn_Snimi_Click);
            // 
            // CertifikatiKandidataCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 401);
            this.Controls.Add(this.btn_Snimi);
            this.Controls.Add(this.DatumOdobrenja_i);
            this.Controls.Add(this.Biljeske_i);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GrupaKandidati_i);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "CertifikatiKandidataCreate";
            this.Text = "CertifikatiKandidataCreate";
            this.Load += new System.EventHandler(this.CertifikatiKandidataCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox GrupaKandidati_i;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Biljeske_i;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DatumOdobrenja_i;
        private System.Windows.Forms.Button btn_Snimi;
    }
}
namespace CZE_Desktop.Forms.Uplate_kandidata
{
    partial class UplateKandidataCreate
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UplateKandidataCreate));
            this.Kolicina_i = new System.Windows.Forms.TextBox();
            this.GrupaKandidati_i = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Biljeske_i = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.racunIzdat_i = new System.Windows.Forms.CheckBox();
            this.btn_Snimi = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Kolicina_i
            // 
            this.Kolicina_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kolicina_i.Location = new System.Drawing.Point(152, 76);
            this.Kolicina_i.Name = "Kolicina_i";
            this.Kolicina_i.Size = new System.Drawing.Size(273, 22);
            this.Kolicina_i.TabIndex = 22;
            this.Kolicina_i.Validating += new System.ComponentModel.CancelEventHandler(this.Kolicina_i_Validating);
            // 
            // GrupaKandidati_i
            // 
            this.GrupaKandidati_i.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.GrupaKandidati_i.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.GrupaKandidati_i.Enabled = false;
            this.GrupaKandidati_i.FormattingEnabled = true;
            this.GrupaKandidati_i.Location = new System.Drawing.Point(152, 43);
            this.GrupaKandidati_i.Name = "GrupaKandidati_i";
            this.GrupaKandidati_i.Size = new System.Drawing.Size(273, 21);
            this.GrupaKandidati_i.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Količina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Grupa kandidata";
            // 
            // Biljeske_i
            // 
            this.Biljeske_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Biljeske_i.Location = new System.Drawing.Point(152, 142);
            this.Biljeske_i.Multiline = true;
            this.Biljeske_i.Name = "Biljeske_i";
            this.Biljeske_i.Size = new System.Drawing.Size(273, 126);
            this.Biljeske_i.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Bilješke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Račun izdat";
            // 
            // racunIzdat_i
            // 
            this.racunIzdat_i.AutoSize = true;
            this.racunIzdat_i.Checked = true;
            this.racunIzdat_i.CheckState = System.Windows.Forms.CheckState.Checked;
            this.racunIzdat_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.racunIzdat_i.Location = new System.Drawing.Point(281, 113);
            this.racunIzdat_i.Name = "racunIzdat_i";
            this.racunIzdat_i.Size = new System.Drawing.Size(15, 14);
            this.racunIzdat_i.TabIndex = 25;
            this.racunIzdat_i.UseVisualStyleBackColor = true;
            // 
            // btn_Snimi
            // 
            this.btn_Snimi.Location = new System.Drawing.Point(59, 349);
            this.btn_Snimi.Name = "btn_Snimi";
            this.btn_Snimi.Size = new System.Drawing.Size(75, 23);
            this.btn_Snimi.TabIndex = 26;
            this.btn_Snimi.Text = "Snimi";
            this.btn_Snimi.UseVisualStyleBackColor = true;
            this.btn_Snimi.Click += new System.EventHandler(this.btn_Snimi_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // UplateKandidataCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 401);
            this.Controls.Add(this.btn_Snimi);
            this.Controls.Add(this.racunIzdat_i);
            this.Controls.Add(this.Biljeske_i);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Kolicina_i);
            this.Controls.Add(this.GrupaKandidati_i);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "UplateKandidataCreate";
            this.Text = "Unos uplate";
            this.Load += new System.EventHandler(this.UplateKandidataCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Kolicina_i;
        private System.Windows.Forms.ComboBox GrupaKandidati_i;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Biljeske_i;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox racunIzdat_i;
        private System.Windows.Forms.Button btn_Snimi;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
namespace CZE_Desktop.Forms.KursForms
{
    partial class KursCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KursCreate));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Opis_i = new System.Windows.Forms.TextBox();
            this.Naziv_i = new System.Windows.Forms.TextBox();
            this.TipKursa_i = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Snimi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // Opis_i
            // 
            this.Opis_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opis_i.Location = new System.Drawing.Point(140, 119);
            this.Opis_i.Multiline = true;
            this.Opis_i.Name = "Opis_i";
            this.Opis_i.Size = new System.Drawing.Size(273, 126);
            this.Opis_i.TabIndex = 13;
            // 
            // Naziv_i
            // 
            this.Naziv_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naziv_i.Location = new System.Drawing.Point(140, 79);
            this.Naziv_i.Name = "Naziv_i";
            this.Naziv_i.Size = new System.Drawing.Size(273, 22);
            this.Naziv_i.TabIndex = 12;
            this.Naziv_i.Validating += new System.ComponentModel.CancelEventHandler(this.Naziv_i_Validating);
            // 
            // TipKursa_i
            // 
            this.TipKursa_i.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipKursa_i.FormattingEnabled = true;
            this.TipKursa_i.Location = new System.Drawing.Point(140, 50);
            this.TipKursa_i.Name = "TipKursa_i";
            this.TipKursa_i.Size = new System.Drawing.Size(273, 21);
            this.TipKursa_i.TabIndex = 11;
            this.TipKursa_i.Validating += new System.ComponentModel.CancelEventHandler(this.TipKursa_i_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Opis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Naziv";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tip kursa";
            // 
            // btn_Snimi
            // 
            this.btn_Snimi.Location = new System.Drawing.Point(27, 339);
            this.btn_Snimi.Name = "btn_Snimi";
            this.btn_Snimi.Size = new System.Drawing.Size(75, 23);
            this.btn_Snimi.TabIndex = 14;
            this.btn_Snimi.Text = "Snimi";
            this.btn_Snimi.UseVisualStyleBackColor = true;
            this.btn_Snimi.Click += new System.EventHandler(this.btn_Snimi_Click);
            // 
            // KursCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 401);
            this.Controls.Add(this.btn_Snimi);
            this.Controls.Add(this.Opis_i);
            this.Controls.Add(this.Naziv_i);
            this.Controls.Add(this.TipKursa_i);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "KursCreate";
            this.Text = "KursCreate";
            this.Load += new System.EventHandler(this.KursCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox Opis_i;
        private System.Windows.Forms.TextBox Naziv_i;
        private System.Windows.Forms.ComboBox TipKursa_i;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Snimi;
    }
}
namespace CZE_Desktop.Forms.KursForms
{
    partial class TipKursaCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipKursaCreate));
            this.Kategorija_i = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Naziv_i = new System.Windows.Forms.TextBox();
            this.Trajanje_i = new System.Windows.Forms.TextBox();
            this.Cijena_i = new System.Windows.Forms.TextBox();
            this.Opis_i = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Snimi = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Kategorija_i
            // 
            this.Kategorija_i.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Kategorija_i.FormattingEnabled = true;
            this.Kategorija_i.Location = new System.Drawing.Point(152, 29);
            this.Kategorija_i.Name = "Kategorija_i";
            this.Kategorija_i.Size = new System.Drawing.Size(156, 21);
            this.Kategorija_i.TabIndex = 5;
            this.Kategorija_i.Validating += new System.ComponentModel.CancelEventHandler(this.Kategorija_i_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kategorija";
            // 
            // Naziv_i
            // 
            this.Naziv_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naziv_i.Location = new System.Drawing.Point(152, 58);
            this.Naziv_i.Name = "Naziv_i";
            this.Naziv_i.Size = new System.Drawing.Size(273, 22);
            this.Naziv_i.TabIndex = 6;
            this.Naziv_i.Validating += new System.ComponentModel.CancelEventHandler(this.Naziv_i_Validating);
            // 
            // Trajanje_i
            // 
            this.Trajanje_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trajanje_i.Location = new System.Drawing.Point(152, 86);
            this.Trajanje_i.Name = "Trajanje_i";
            this.Trajanje_i.Size = new System.Drawing.Size(273, 22);
            this.Trajanje_i.TabIndex = 7;
            this.Trajanje_i.Validating += new System.ComponentModel.CancelEventHandler(this.Trajanje_i_Validating);
            // 
            // Cijena_i
            // 
            this.Cijena_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cijena_i.Location = new System.Drawing.Point(152, 114);
            this.Cijena_i.Name = "Cijena_i";
            this.Cijena_i.Size = new System.Drawing.Size(273, 22);
            this.Cijena_i.TabIndex = 7;
            this.Cijena_i.Validating += new System.ComponentModel.CancelEventHandler(this.Cijena_i_Validating);
            // 
            // Opis_i
            // 
            this.Opis_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opis_i.Location = new System.Drawing.Point(152, 142);
            this.Opis_i.Multiline = true;
            this.Opis_i.Name = "Opis_i";
            this.Opis_i.Size = new System.Drawing.Size(273, 126);
            this.Opis_i.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trajanje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cijena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Opis";
            // 
            // btn_Snimi
            // 
            this.btn_Snimi.Location = new System.Drawing.Point(39, 315);
            this.btn_Snimi.Name = "btn_Snimi";
            this.btn_Snimi.Size = new System.Drawing.Size(75, 23);
            this.btn_Snimi.TabIndex = 8;
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
            // TipKursaCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 401);
            this.Controls.Add(this.btn_Snimi);
            this.Controls.Add(this.Opis_i);
            this.Controls.Add(this.Cijena_i);
            this.Controls.Add(this.Trajanje_i);
            this.Controls.Add(this.Naziv_i);
            this.Controls.Add(this.Kategorija_i);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "TipKursaCreate";
            this.Text = "TipKursaCreate";
            this.Load += new System.EventHandler(this.TipKursaCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Kategorija_i;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Naziv_i;
        private System.Windows.Forms.TextBox Trajanje_i;
        private System.Windows.Forms.TextBox Cijena_i;
        private System.Windows.Forms.TextBox Opis_i;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Snimi;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
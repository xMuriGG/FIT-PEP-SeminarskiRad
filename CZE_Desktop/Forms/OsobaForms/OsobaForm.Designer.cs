namespace CZE_Desktop.Forms.OsobaForms
{
    partial class OsobaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OsobaForm));
            this.Ime_i = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Prezime_i = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Email_i = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Adresa_i = new System.Windows.Forms.TextBox();
            this.lable6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Broj0_i = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SnimiBTN = new System.Windows.Forms.Button();
            this.AddBrojBTN = new System.Windows.Forms.Button();
            this.RemoveBrojBTN = new System.Windows.Forms.Button();
            this.Broj0_cB = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DatumRodjenja_i = new System.Windows.Forms.DateTimePicker();
            this.Spol_i = new System.Windows.Forms.ComboBox();
            this.MjestoRodjenja_i = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Ime_i
            // 
            this.Ime_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ime_i.Location = new System.Drawing.Point(159, 30);
            this.Ime_i.Name = "Ime_i";
            this.Ime_i.Size = new System.Drawing.Size(273, 22);
            this.Ime_i.TabIndex = 0;
            this.Ime_i.Validating += new System.ComponentModel.CancelEventHandler(this.Ime_i_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime";
            // 
            // Prezime_i
            // 
            this.Prezime_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prezime_i.Location = new System.Drawing.Point(159, 56);
            this.Prezime_i.Name = "Prezime_i";
            this.Prezime_i.Size = new System.Drawing.Size(273, 22);
            this.Prezime_i.TabIndex = 1;
            this.Prezime_i.Validating += new System.ComponentModel.CancelEventHandler(this.Prezime_i_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Datum rođenja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Spol";
            // 
            // Email_i
            // 
            this.Email_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_i.Location = new System.Drawing.Point(159, 134);
            this.Email_i.Name = "Email_i";
            this.Email_i.Size = new System.Drawing.Size(273, 22);
            this.Email_i.TabIndex = 4;
            this.Email_i.Validating += new System.ComponentModel.CancelEventHandler(this.Email_i_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email";
            // 
            // Adresa_i
            // 
            this.Adresa_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adresa_i.Location = new System.Drawing.Point(159, 160);
            this.Adresa_i.Name = "Adresa_i";
            this.Adresa_i.Size = new System.Drawing.Size(273, 22);
            this.Adresa_i.TabIndex = 5;
            this.Adresa_i.Validating += new System.ComponentModel.CancelEventHandler(this.Adresa_i_Validating);
            // 
            // lable6
            // 
            this.lable6.AutoSize = true;
            this.lable6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable6.Location = new System.Drawing.Point(17, 163);
            this.lable6.Name = "lable6";
            this.lable6.Size = new System.Drawing.Size(121, 16);
            this.lable6.TabIndex = 1;
            this.lable6.Text = "Adresa stanovanja";
            // 
            // label7
            // 
            this.label7.AccessibleDescription = "";
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mjesto rođenja";
            // 
            // Broj0_i
            // 
            this.Broj0_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Broj0_i.Location = new System.Drawing.Point(159, 212);
            this.Broj0_i.Name = "Broj0_i";
            this.Broj0_i.Size = new System.Drawing.Size(156, 22);
            this.Broj0_i.TabIndex = 7;
            this.Broj0_i.Validating += new System.ComponentModel.CancelEventHandler(this.Broj_i_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Brojevi telefona";
            // 
            // SnimiBTN
            // 
            this.SnimiBTN.CausesValidation = false;
            this.SnimiBTN.Location = new System.Drawing.Point(52, 410);
            this.SnimiBTN.Name = "SnimiBTN";
            this.SnimiBTN.Size = new System.Drawing.Size(86, 30);
            this.SnimiBTN.TabIndex = 11;
            this.SnimiBTN.Text = "Snimi";
            this.SnimiBTN.UseVisualStyleBackColor = true;
            this.SnimiBTN.Click += new System.EventHandler(this.SnimiBTN_Click);
            // 
            // AddBrojBTN
            // 
            this.AddBrojBTN.CausesValidation = false;
            this.AddBrojBTN.Location = new System.Drawing.Point(159, 256);
            this.AddBrojBTN.Name = "AddBrojBTN";
            this.AddBrojBTN.Size = new System.Drawing.Size(75, 23);
            this.AddBrojBTN.TabIndex = 9;
            this.AddBrojBTN.Text = "Add";
            this.AddBrojBTN.UseVisualStyleBackColor = true;
            this.AddBrojBTN.Click += new System.EventHandler(this.AddBrojBTN_Click);
            // 
            // RemoveBrojBTN
            // 
            this.RemoveBrojBTN.CausesValidation = false;
            this.RemoveBrojBTN.Location = new System.Drawing.Point(240, 256);
            this.RemoveBrojBTN.Name = "RemoveBrojBTN";
            this.RemoveBrojBTN.Size = new System.Drawing.Size(75, 23);
            this.RemoveBrojBTN.TabIndex = 10;
            this.RemoveBrojBTN.Text = "Remove";
            this.RemoveBrojBTN.UseVisualStyleBackColor = true;
            this.RemoveBrojBTN.Click += new System.EventHandler(this.RemoveBrojBTN_Click);
            // 
            // Broj0_cB
            // 
            this.Broj0_cB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Broj0_cB.FormattingEnabled = true;
            this.Broj0_cB.Location = new System.Drawing.Point(336, 213);
            this.Broj0_cB.Name = "Broj0_cB";
            this.Broj0_cB.Size = new System.Drawing.Size(96, 21);
            this.Broj0_cB.TabIndex = 8;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // DatumRodjenja_i
            // 
            this.DatumRodjenja_i.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatumRodjenja_i.Location = new System.Drawing.Point(159, 84);
            this.DatumRodjenja_i.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.DatumRodjenja_i.Name = "DatumRodjenja_i";
            this.DatumRodjenja_i.Size = new System.Drawing.Size(156, 20);
            this.DatumRodjenja_i.TabIndex = 2;
            // 
            // Spol_i
            // 
            this.Spol_i.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Spol_i.FormattingEnabled = true;
            this.Spol_i.Location = new System.Drawing.Point(159, 109);
            this.Spol_i.Name = "Spol_i";
            this.Spol_i.Size = new System.Drawing.Size(156, 21);
            this.Spol_i.TabIndex = 3;
            this.Spol_i.Validating += new System.ComponentModel.CancelEventHandler(this.Spol_i_Validating);
            // 
            // MjestoRodjenja_i
            // 
            this.MjestoRodjenja_i.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MjestoRodjenja_i.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MjestoRodjenja_i.FormattingEnabled = true;
            this.MjestoRodjenja_i.Location = new System.Drawing.Point(159, 186);
            this.MjestoRodjenja_i.Name = "MjestoRodjenja_i";
            this.MjestoRodjenja_i.Size = new System.Drawing.Size(273, 21);
            this.MjestoRodjenja_i.TabIndex = 6;
            this.MjestoRodjenja_i.Validating += new System.ComponentModel.CancelEventHandler(this.MjestoRodjenja_i_Validating);
            // 
            // button1
            // 
            this.button1.CausesValidation = false;
            this.button1.Location = new System.Drawing.Point(159, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Zatvori";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OsobaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MjestoRodjenja_i);
            this.Controls.Add(this.Spol_i);
            this.Controls.Add(this.DatumRodjenja_i);
            this.Controls.Add(this.Broj0_cB);
            this.Controls.Add(this.RemoveBrojBTN);
            this.Controls.Add(this.AddBrojBTN);
            this.Controls.Add(this.SnimiBTN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lable6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Broj0_i);
            this.Controls.Add(this.Adresa_i);
            this.Controls.Add(this.Email_i);
            this.Controls.Add(this.Prezime_i);
            this.Controls.Add(this.Ime_i);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "OsobaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "OsobaForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OsobaForm_FormClosing);
            this.Load += new System.EventHandler(this.OsobaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Ime_i;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Prezime_i;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Email_i;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Adresa_i;
        private System.Windows.Forms.Label lable6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Broj0_i;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SnimiBTN;
        private System.Windows.Forms.Button AddBrojBTN;
        private System.Windows.Forms.Button RemoveBrojBTN;
        private System.Windows.Forms.ComboBox Broj0_cB;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox MjestoRodjenja_i;
        private System.Windows.Forms.ComboBox Spol_i;
        private System.Windows.Forms.DateTimePicker DatumRodjenja_i;
        private System.Windows.Forms.Button button1;
    }
}
namespace CZE_Desktop.Forms.KursForms
{
    partial class GrupaCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrupaCreate));
            this.Naziv_i = new System.Windows.Forms.TextBox();
            this.Kurs_i = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DatumPocetka_i = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DatumZavrsetka_i = new System.Windows.Forms.DateTimePicker();
            this.Predavac_i = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Snimi = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.slikaInput = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Naziv_i
            // 
            this.Naziv_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naziv_i.Location = new System.Drawing.Point(162, 41);
            this.Naziv_i.Name = "Naziv_i";
            this.Naziv_i.Size = new System.Drawing.Size(273, 22);
            this.Naziv_i.TabIndex = 18;
            this.Naziv_i.Validating += new System.ComponentModel.CancelEventHandler(this.Naziv_i_Validating);
            // 
            // Kurs_i
            // 
            this.Kurs_i.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Kurs_i.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Kurs_i.FormattingEnabled = true;
            this.Kurs_i.Location = new System.Drawing.Point(162, 12);
            this.Kurs_i.Name = "Kurs_i";
            this.Kurs_i.Size = new System.Drawing.Size(273, 21);
            this.Kurs_i.TabIndex = 17;
            this.Kurs_i.Validating += new System.ComponentModel.CancelEventHandler(this.cB_i_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Naziv";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Kurs";
            // 
            // DatumPocetka_i
            // 
            this.DatumPocetka_i.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatumPocetka_i.Location = new System.Drawing.Point(162, 74);
            this.DatumPocetka_i.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.DatumPocetka_i.Name = "DatumPocetka_i";
            this.DatumPocetka_i.Size = new System.Drawing.Size(135, 20);
            this.DatumPocetka_i.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Datum početka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Datum završetka";
            // 
            // DatumZavrsetka_i
            // 
            this.DatumZavrsetka_i.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatumZavrsetka_i.Location = new System.Drawing.Point(162, 100);
            this.DatumZavrsetka_i.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.DatumZavrsetka_i.Name = "DatumZavrsetka_i";
            this.DatumZavrsetka_i.Size = new System.Drawing.Size(135, 20);
            this.DatumZavrsetka_i.TabIndex = 20;
            // 
            // Predavac_i
            // 
            this.Predavac_i.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Predavac_i.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Predavac_i.FormattingEnabled = true;
            this.Predavac_i.Location = new System.Drawing.Point(162, 136);
            this.Predavac_i.Name = "Predavac_i";
            this.Predavac_i.Size = new System.Drawing.Size(273, 21);
            this.Predavac_i.TabIndex = 22;
            this.Predavac_i.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.Predavac_i_Format);
            this.Predavac_i.Validating += new System.ComponentModel.CancelEventHandler(this.cB_i_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Predavač";
            // 
            // btn_Snimi
            // 
            this.btn_Snimi.Location = new System.Drawing.Point(49, 324);
            this.btn_Snimi.Name = "btn_Snimi";
            this.btn_Snimi.Size = new System.Drawing.Size(75, 23);
            this.btn_Snimi.TabIndex = 23;
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
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(233, 163);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(120, 120);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 50;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // slikaInput
            // 
            this.slikaInput.Enabled = false;
            this.slikaInput.Location = new System.Drawing.Point(162, 289);
            this.slikaInput.Name = "slikaInput";
            this.slikaInput.Size = new System.Drawing.Size(273, 20);
            this.slikaInput.TabIndex = 51;
            this.slikaInput.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Slika";
            // 
            // GrupaCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 401);
            this.Controls.Add(this.slikaInput);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btn_Snimi);
            this.Controls.Add(this.Predavac_i);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DatumZavrsetka_i);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DatumPocetka_i);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Naziv_i);
            this.Controls.Add(this.Kurs_i);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "GrupaCreate";
            this.Text = "GrupaCreate";
            this.Load += new System.EventHandler(this.GrupaCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Naziv_i;
        private System.Windows.Forms.ComboBox Kurs_i;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DatumPocetka_i;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DatumZavrsetka_i;
        private System.Windows.Forms.ComboBox Predavac_i;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Snimi;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox slikaInput;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label7;
    }
}
namespace CZE_Desktop.Forms.KursForms
{
    partial class KursMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGV_TipKursa = new System.Windows.Forms.DataGridView();
            this.KursTipID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KursKategorijaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trajanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGV_Kurs = new System.Windows.Forms.DataGridView();
            this.KursID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KursNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KursOpis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGV_Grupa = new System.Windows.Forms.DataGridView();
            this.GrupaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrupaNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrupaDatumPocetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrupaDatumZavrsetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrupaAktivna = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GrupaUToku = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GrupaImePrezimePredavaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMS_Grupa = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMS_Grupa_Utoku = new System.Windows.Forms.ToolStripMenuItem();
            this.cMS_Grupa_Zavrsena = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_AddTipKursa = new System.Windows.Forms.Button();
            this.btn_AddKurs = new System.Windows.Forms.Button();
            this.btn_AddGrupa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cMS_EditGrupa = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_TipKursa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Kurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Grupa)).BeginInit();
            this.cMS_Grupa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV_TipKursa
            // 
            this.dGV_TipKursa.AllowUserToAddRows = false;
            this.dGV_TipKursa.AllowUserToDeleteRows = false;
            this.dGV_TipKursa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_TipKursa.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGV_TipKursa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGV_TipKursa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_TipKursa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KursTipID,
            this.KursKategorijaID,
            this.Naziv,
            this.Kategorija,
            this.Trajanje,
            this.Cijena});
            this.dGV_TipKursa.Location = new System.Drawing.Point(45, 47);
            this.dGV_TipKursa.Name = "dGV_TipKursa";
            this.dGV_TipKursa.ReadOnly = true;
            this.dGV_TipKursa.RowHeadersVisible = false;
            this.dGV_TipKursa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_TipKursa.Size = new System.Drawing.Size(918, 164);
            this.dGV_TipKursa.TabIndex = 0;
            this.dGV_TipKursa.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGV_TipKursa_CellMouseClick);
            // 
            // KursTipID
            // 
            this.KursTipID.DataPropertyName = "KursTipID";
            this.KursTipID.HeaderText = "KursTipID";
            this.KursTipID.Name = "KursTipID";
            this.KursTipID.ReadOnly = true;
            this.KursTipID.Visible = false;
            // 
            // KursKategorijaID
            // 
            this.KursKategorijaID.DataPropertyName = "KursKategorijaID";
            this.KursKategorijaID.HeaderText = "KursKategorijaID";
            this.KursKategorijaID.Name = "KursKategorijaID";
            this.KursKategorijaID.ReadOnly = true;
            this.KursKategorijaID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Tip";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Kategorija
            // 
            this.Kategorija.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kategorija.DataPropertyName = "KursKategorijaNaziv";
            this.Kategorija.HeaderText = "Kategorija";
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.ReadOnly = true;
            // 
            // Trajanje
            // 
            this.Trajanje.DataPropertyName = "Trajanje";
            this.Trajanje.HeaderText = "Časova";
            this.Trajanje.Name = "Trajanje";
            this.Trajanje.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cijena.DataPropertyName = "Cijena";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Cijena.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // dGV_Kurs
            // 
            this.dGV_Kurs.AllowUserToAddRows = false;
            this.dGV_Kurs.AllowUserToDeleteRows = false;
            this.dGV_Kurs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_Kurs.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGV_Kurs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGV_Kurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Kurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KursID,
            this.KursNaziv,
            this.KursOpis,
            this.Ocjena});
            this.dGV_Kurs.Location = new System.Drawing.Point(45, 280);
            this.dGV_Kurs.Name = "dGV_Kurs";
            this.dGV_Kurs.ReadOnly = true;
            this.dGV_Kurs.RowHeadersVisible = false;
            this.dGV_Kurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Kurs.Size = new System.Drawing.Size(918, 164);
            this.dGV_Kurs.TabIndex = 1;
            this.dGV_Kurs.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGV_Kurs_CellMouseClick);
            // 
            // KursID
            // 
            this.KursID.DataPropertyName = "KursID";
            this.KursID.HeaderText = "KursID";
            this.KursID.Name = "KursID";
            this.KursID.ReadOnly = true;
            this.KursID.Visible = false;
            // 
            // KursNaziv
            // 
            this.KursNaziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.KursNaziv.DataPropertyName = "Naziv";
            this.KursNaziv.HeaderText = "Naziv";
            this.KursNaziv.Name = "KursNaziv";
            this.KursNaziv.ReadOnly = true;
            this.KursNaziv.Width = 59;
            // 
            // KursOpis
            // 
            this.KursOpis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KursOpis.DataPropertyName = "Opis";
            this.KursOpis.HeaderText = "Opis";
            this.KursOpis.Name = "KursOpis";
            this.KursOpis.ReadOnly = true;
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Prosječna ocjena";
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            // 
            // dGV_Grupa
            // 
            this.dGV_Grupa.AllowUserToAddRows = false;
            this.dGV_Grupa.AllowUserToDeleteRows = false;
            this.dGV_Grupa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_Grupa.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGV_Grupa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGV_Grupa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Grupa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GrupaID,
            this.GrupaNaziv,
            this.GrupaDatumPocetka,
            this.GrupaDatumZavrsetka,
            this.GrupaAktivna,
            this.GrupaUToku,
            this.GrupaImePrezimePredavaca});
            this.dGV_Grupa.Location = new System.Drawing.Point(45, 513);
            this.dGV_Grupa.Name = "dGV_Grupa";
            this.dGV_Grupa.ReadOnly = true;
            this.dGV_Grupa.RowHeadersVisible = false;
            this.dGV_Grupa.RowTemplate.ContextMenuStrip = this.cMS_Grupa;
            this.dGV_Grupa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Grupa.Size = new System.Drawing.Size(918, 164);
            this.dGV_Grupa.TabIndex = 2;
            this.dGV_Grupa.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dGV_Grupa_CellFormatting);
            this.dGV_Grupa.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.dGV_Grupa_RowContextMenuStripNeeded);
            // 
            // GrupaID
            // 
            this.GrupaID.DataPropertyName = "GrupaID";
            this.GrupaID.HeaderText = "GrupaID";
            this.GrupaID.Name = "GrupaID";
            this.GrupaID.ReadOnly = true;
            this.GrupaID.Visible = false;
            // 
            // GrupaNaziv
            // 
            this.GrupaNaziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GrupaNaziv.DataPropertyName = "Naziv";
            this.GrupaNaziv.HeaderText = "Naziv";
            this.GrupaNaziv.Name = "GrupaNaziv";
            this.GrupaNaziv.ReadOnly = true;
            // 
            // GrupaDatumPocetka
            // 
            this.GrupaDatumPocetka.DataPropertyName = "Pocetak";
            this.GrupaDatumPocetka.HeaderText = "Datum početka";
            this.GrupaDatumPocetka.Name = "GrupaDatumPocetka";
            this.GrupaDatumPocetka.ReadOnly = true;
            // 
            // GrupaDatumZavrsetka
            // 
            this.GrupaDatumZavrsetka.DataPropertyName = "Kraj";
            this.GrupaDatumZavrsetka.HeaderText = "Datum završetka";
            this.GrupaDatumZavrsetka.Name = "GrupaDatumZavrsetka";
            this.GrupaDatumZavrsetka.ReadOnly = true;
            // 
            // GrupaAktivna
            // 
            this.GrupaAktivna.DataPropertyName = "Aktivna";
            this.GrupaAktivna.HeaderText = "Aktivna";
            this.GrupaAktivna.Name = "GrupaAktivna";
            this.GrupaAktivna.ReadOnly = true;
            // 
            // GrupaUToku
            // 
            this.GrupaUToku.DataPropertyName = "UToku";
            this.GrupaUToku.HeaderText = "U toku";
            this.GrupaUToku.Name = "GrupaUToku";
            this.GrupaUToku.ReadOnly = true;
            // 
            // GrupaImePrezimePredavaca
            // 
            this.GrupaImePrezimePredavaca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GrupaImePrezimePredavaca.DataPropertyName = "ImePrezimeZaposlenika";
            this.GrupaImePrezimePredavaca.HeaderText = "Predavač";
            this.GrupaImePrezimePredavaca.Name = "GrupaImePrezimePredavaca";
            this.GrupaImePrezimePredavaca.ReadOnly = true;
            // 
            // cMS_Grupa
            // 
            this.cMS_Grupa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMS_EditGrupa,
            this.toolStripMenuItem1,
            this.cMS_Grupa_Utoku,
            this.cMS_Grupa_Zavrsena});
            this.cMS_Grupa.Name = "cMS_Grupa";
            this.cMS_Grupa.ShowImageMargin = false;
            this.cMS_Grupa.Size = new System.Drawing.Size(179, 114);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.toolStripMenuItem1.Text = "Promjeni status grupe u:";
            // 
            // cMS_Grupa_Utoku
            // 
            this.cMS_Grupa_Utoku.Enabled = false;
            this.cMS_Grupa_Utoku.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cMS_Grupa_Utoku.Name = "cMS_Grupa_Utoku";
            this.cMS_Grupa_Utoku.Size = new System.Drawing.Size(178, 22);
            this.cMS_Grupa_Utoku.Text = "U toku";
            this.cMS_Grupa_Utoku.Click += new System.EventHandler(this.cMS_Grupa_Utoku_Click);
            // 
            // cMS_Grupa_Zavrsena
            // 
            this.cMS_Grupa_Zavrsena.Enabled = false;
            this.cMS_Grupa_Zavrsena.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cMS_Grupa_Zavrsena.Name = "cMS_Grupa_Zavrsena";
            this.cMS_Grupa_Zavrsena.Size = new System.Drawing.Size(178, 22);
            this.cMS_Grupa_Zavrsena.Text = "Zavšena";
            this.cMS_Grupa_Zavrsena.Click += new System.EventHandler(this.cMS_Grupa_Zavrsena_Click);
            // 
            // btn_AddTipKursa
            // 
            this.btn_AddTipKursa.Location = new System.Drawing.Point(121, 21);
            this.btn_AddTipKursa.Name = "btn_AddTipKursa";
            this.btn_AddTipKursa.Size = new System.Drawing.Size(75, 23);
            this.btn_AddTipKursa.TabIndex = 3;
            this.btn_AddTipKursa.Text = "Add";
            this.btn_AddTipKursa.UseVisualStyleBackColor = true;
            this.btn_AddTipKursa.Click += new System.EventHandler(this.btn_AddTipKursa_Click);
            // 
            // btn_AddKurs
            // 
            this.btn_AddKurs.Location = new System.Drawing.Point(121, 254);
            this.btn_AddKurs.Name = "btn_AddKurs";
            this.btn_AddKurs.Size = new System.Drawing.Size(75, 23);
            this.btn_AddKurs.TabIndex = 3;
            this.btn_AddKurs.Text = "Add";
            this.btn_AddKurs.UseVisualStyleBackColor = true;
            this.btn_AddKurs.Click += new System.EventHandler(this.btn_AddKurs_Click);
            // 
            // btn_AddGrupa
            // 
            this.btn_AddGrupa.Location = new System.Drawing.Point(121, 487);
            this.btn_AddGrupa.Name = "btn_AddGrupa";
            this.btn_AddGrupa.Size = new System.Drawing.Size(75, 23);
            this.btn_AddGrupa.TabIndex = 3;
            this.btn_AddGrupa.Text = "Add";
            this.btn_AddGrupa.UseVisualStyleBackColor = true;
            this.btn_AddGrupa.Click += new System.EventHandler(this.btn_AddGrupa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(50, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tip kursa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(50, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kurs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(50, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Grupe:";
            // 
            // cMS_EditGrupa
            // 
            this.cMS_EditGrupa.Name = "cMS_EditGrupa";
            this.cMS_EditGrupa.Size = new System.Drawing.Size(178, 22);
            this.cMS_EditGrupa.Text = "Edit";
            this.cMS_EditGrupa.Click += new System.EventHandler(this.cMS_EditGrupa_Click);
            // 
            // KursMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(975, 684);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AddGrupa);
            this.Controls.Add(this.btn_AddKurs);
            this.Controls.Add(this.btn_AddTipKursa);
            this.Controls.Add(this.dGV_Grupa);
            this.Controls.Add(this.dGV_Kurs);
            this.Controls.Add(this.dGV_TipKursa);
            this.Name = "KursMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KursMain";
            this.Load += new System.EventHandler(this.KursMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_TipKursa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Kurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Grupa)).EndInit();
            this.cMS_Grupa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_TipKursa;
        private System.Windows.Forms.DataGridView dGV_Kurs;
        private System.Windows.Forms.DataGridView dGV_Grupa;
        private System.Windows.Forms.Button btn_AddTipKursa;
        private System.Windows.Forms.Button btn_AddKurs;
        private System.Windows.Forms.Button btn_AddGrupa;
        private System.Windows.Forms.DataGridViewTextBoxColumn KursTipID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KursKategorijaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trajanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn KursID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KursNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn KursOpis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrupaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrupaNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrupaDatumPocetka;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrupaDatumZavrsetka;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GrupaAktivna;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GrupaUToku;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrupaImePrezimePredavaca;
        private System.Windows.Forms.ContextMenuStrip cMS_Grupa;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cMS_Grupa_Utoku;
        private System.Windows.Forms.ToolStripMenuItem cMS_Grupa_Zavrsena;
        private System.Windows.Forms.ToolStripMenuItem cMS_EditGrupa;
    }
}
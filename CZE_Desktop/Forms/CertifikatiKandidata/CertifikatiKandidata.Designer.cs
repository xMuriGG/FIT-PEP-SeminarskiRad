namespace CZE_Desktop.Forms.Certifikati_kandidata
{
    partial class CertifikatiKandidata
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
            this.lbl_grupeKandidata = new System.Windows.Forms.Label();
            this.dGV_GrupeKandidati = new System.Windows.Forms.DataGridView();
            this.GrupaKandidatiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrupaNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KursNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predavac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otplaceno = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DatumOdobrenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uruceno = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Biljeske = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMI_Printaj = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMI_Odobri = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMI_Uruci = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_GrupeKandidati)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_grupeKandidata
            // 
            this.lbl_grupeKandidata.AutoSize = true;
            this.lbl_grupeKandidata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grupeKandidata.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_grupeKandidata.Location = new System.Drawing.Point(12, 9);
            this.lbl_grupeKandidata.Name = "lbl_grupeKandidata";
            this.lbl_grupeKandidata.Size = new System.Drawing.Size(0, 16);
            this.lbl_grupeKandidata.TabIndex = 7;
            // 
            // dGV_GrupeKandidati
            // 
            this.dGV_GrupeKandidati.AllowUserToAddRows = false;
            this.dGV_GrupeKandidati.AllowUserToDeleteRows = false;
            this.dGV_GrupeKandidati.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_GrupeKandidati.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dGV_GrupeKandidati.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dGV_GrupeKandidati.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGV_GrupeKandidati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_GrupeKandidati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GrupaKandidatiID,
            this.GrupaNaziv,
            this.KursNaziv,
            this.TipNaziv,
            this.Predavac,
            this.Otplaceno,
            this.DatumOdobrenja,
            this.Uruceno,
            this.Biljeske});
            this.dGV_GrupeKandidati.Location = new System.Drawing.Point(12, 29);
            this.dGV_GrupeKandidati.Name = "dGV_GrupeKandidati";
            this.dGV_GrupeKandidati.ReadOnly = true;
            this.dGV_GrupeKandidati.RowHeadersVisible = false;
            this.dGV_GrupeKandidati.RowTemplate.ContextMenuStrip = this.contextMenuStrip;
            this.dGV_GrupeKandidati.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_GrupeKandidati.Size = new System.Drawing.Size(946, 398);
            this.dGV_GrupeKandidati.TabIndex = 6;
            this.dGV_GrupeKandidati.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dGV_GrupeKandidati_CellFormatting);
            this.dGV_GrupeKandidati.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.dGV_GrupeKandidati_RowContextMenuStripNeeded);
            // 
            // GrupaKandidatiID
            // 
            this.GrupaKandidatiID.HeaderText = "GrupaKandidatiID";
            this.GrupaKandidatiID.Name = "GrupaKandidatiID";
            this.GrupaKandidatiID.ReadOnly = true;
            this.GrupaKandidatiID.Visible = false;
            // 
            // GrupaNaziv
            // 
            this.GrupaNaziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GrupaNaziv.DataPropertyName = "GrupaNaziv";
            this.GrupaNaziv.HeaderText = "Grupa";
            this.GrupaNaziv.Name = "GrupaNaziv";
            this.GrupaNaziv.ReadOnly = true;
            // 
            // KursNaziv
            // 
            this.KursNaziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.KursNaziv.DataPropertyName = "KursNaziv";
            this.KursNaziv.HeaderText = "Kurs";
            this.KursNaziv.Name = "KursNaziv";
            this.KursNaziv.ReadOnly = true;
            this.KursNaziv.Width = 53;
            // 
            // TipNaziv
            // 
            this.TipNaziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TipNaziv.DataPropertyName = "TipNaziv";
            this.TipNaziv.HeaderText = "Tip";
            this.TipNaziv.Name = "TipNaziv";
            this.TipNaziv.ReadOnly = true;
            this.TipNaziv.Width = 47;
            // 
            // Predavac
            // 
            this.Predavac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Predavac.DataPropertyName = "Predavac";
            this.Predavac.HeaderText = "Predavač";
            this.Predavac.Name = "Predavac";
            this.Predavac.ReadOnly = true;
            this.Predavac.Width = 78;
            // 
            // Otplaceno
            // 
            this.Otplaceno.DataPropertyName = "Otplaceno";
            this.Otplaceno.HeaderText = "Otplačeno";
            this.Otplaceno.Name = "Otplaceno";
            this.Otplaceno.ReadOnly = true;
            this.Otplaceno.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Otplaceno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DatumOdobrenja
            // 
            this.DatumOdobrenja.DataPropertyName = "DatumOdobrenja";
            this.DatumOdobrenja.HeaderText = "Datum odobrenja";
            this.DatumOdobrenja.Name = "DatumOdobrenja";
            this.DatumOdobrenja.ReadOnly = true;
            // 
            // Uruceno
            // 
            this.Uruceno.DataPropertyName = "Uruceno";
            this.Uruceno.HeaderText = "Uručeno";
            this.Uruceno.Name = "Uruceno";
            this.Uruceno.ReadOnly = true;
            this.Uruceno.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Uruceno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Biljeske
            // 
            this.Biljeske.DataPropertyName = "Biljeske";
            this.Biljeske.HeaderText = "Bilješke";
            this.Biljeske.Name = "Biljeske";
            this.Biljeske.ReadOnly = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMI_Printaj,
            this.tSMI_Odobri,
            this.tSMI_Uruci});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 92);
            // 
            // tSMI_Printaj
            // 
            this.tSMI_Printaj.Name = "tSMI_Printaj";
            this.tSMI_Printaj.Size = new System.Drawing.Size(152, 22);
            this.tSMI_Printaj.Text = "Printaj";
            this.tSMI_Printaj.Click += new System.EventHandler(this.tSMI_Printaj_Click);
            // 
            // tSMI_Odobri
            // 
            this.tSMI_Odobri.Name = "tSMI_Odobri";
            this.tSMI_Odobri.Size = new System.Drawing.Size(152, 22);
            this.tSMI_Odobri.Text = "Odobri";
            this.tSMI_Odobri.Click += new System.EventHandler(this.tSMI_Odobri_Click);
            // 
            // tSMI_Uruci
            // 
            this.tSMI_Uruci.Name = "tSMI_Uruci";
            this.tSMI_Uruci.Size = new System.Drawing.Size(152, 22);
            this.tSMI_Uruci.Text = "Uruči";
            this.tSMI_Uruci.Click += new System.EventHandler(this.tSMI_Uruci_Click);
            // 
            // CertifikatiKandidata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 439);
            this.Controls.Add(this.lbl_grupeKandidata);
            this.Controls.Add(this.dGV_GrupeKandidati);
            this.Name = "CertifikatiKandidata";
            this.Text = "Certifikati kandidata";
            this.Load += new System.EventHandler(this.CertifikatiKandidata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_GrupeKandidati)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_grupeKandidata;
        private System.Windows.Forms.DataGridView dGV_GrupeKandidati;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tSMI_Printaj;
        private System.Windows.Forms.ToolStripMenuItem tSMI_Odobri;
        private System.Windows.Forms.ToolStripMenuItem tSMI_Uruci;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrupaKandidatiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrupaNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn KursNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predavac;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Otplaceno;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumOdobrenja;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Uruceno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Biljeske;
    }
}
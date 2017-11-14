namespace CZE_Desktop.Forms.Uplate_kandidata
{
    partial class UplateKandidata
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGV_GrupeKandidati = new System.Windows.Forms.DataGridView();
            this.GrupaKandidatiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrupaNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KursNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predavac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uplaceno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGV_Uplate = new System.Windows.Forms.DataGridView();
            this.UplataKandidataID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumUplate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RacunIzdat = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Biljeske = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_addUplatu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_deleteUplatu = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMI_OplacenoStatus = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_GrupeKandidati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Uplate)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.Uplaceno});
            this.dGV_GrupeKandidati.Location = new System.Drawing.Point(22, 29);
            this.dGV_GrupeKandidati.Name = "dGV_GrupeKandidati";
            this.dGV_GrupeKandidati.ReadOnly = true;
            this.dGV_GrupeKandidati.RowHeadersVisible = false;
            this.dGV_GrupeKandidati.RowTemplate.ContextMenuStrip = this.contextMenuStrip;
            this.dGV_GrupeKandidati.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_GrupeKandidati.Size = new System.Drawing.Size(586, 398);
            this.dGV_GrupeKandidati.TabIndex = 0;
            this.dGV_GrupeKandidati.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dGV_GrupeKandidati_CellFormatting);
            this.dGV_GrupeKandidati.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGV_GrupeKandidati_CellMouseClick);
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
            // Uplaceno
            // 
            this.Uplaceno.DataPropertyName = "Uplaceno";
            this.Uplaceno.HeaderText = "Uplačeno";
            this.Uplaceno.Name = "Uplaceno";
            this.Uplaceno.ReadOnly = true;
            // 
            // dGV_Uplate
            // 
            this.dGV_Uplate.AllowUserToAddRows = false;
            this.dGV_Uplate.AllowUserToDeleteRows = false;
            this.dGV_Uplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_Uplate.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dGV_Uplate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dGV_Uplate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGV_Uplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Uplate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UplataKandidataID,
            this.DatumUplate,
            this.Kolicina,
            this.RacunIzdat,
            this.Biljeske});
            this.dGV_Uplate.Location = new System.Drawing.Point(632, 58);
            this.dGV_Uplate.Name = "dGV_Uplate";
            this.dGV_Uplate.ReadOnly = true;
            this.dGV_Uplate.RowHeadersVisible = false;
            this.dGV_Uplate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Uplate.Size = new System.Drawing.Size(326, 369);
            this.dGV_Uplate.TabIndex = 1;
            // 
            // UplataKandidataID
            // 
            this.UplataKandidataID.DataPropertyName = "UplataKandidataID";
            this.UplataKandidataID.HeaderText = "UplataKandidataID";
            this.UplataKandidataID.Name = "UplataKandidataID";
            this.UplataKandidataID.ReadOnly = true;
            this.UplataKandidataID.Visible = false;
            // 
            // DatumUplate
            // 
            this.DatumUplate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DatumUplate.DataPropertyName = "DatumUplate";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.DatumUplate.DefaultCellStyle = dataGridViewCellStyle5;
            this.DatumUplate.HeaderText = "Datum uplate";
            this.DatumUplate.Name = "DatumUplate";
            this.DatumUplate.ReadOnly = true;
            this.DatumUplate.Width = 95;
            // 
            // Kolicina
            // 
            this.Kolicina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Kolicina.DataPropertyName = "Kolicina";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.Kolicina.DefaultCellStyle = dataGridViewCellStyle6;
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            this.Kolicina.Width = 69;
            // 
            // RacunIzdat
            // 
            this.RacunIzdat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.RacunIzdat.DataPropertyName = "RacunIzdat";
            this.RacunIzdat.HeaderText = "Račun izdat";
            this.RacunIzdat.Name = "RacunIzdat";
            this.RacunIzdat.ReadOnly = true;
            this.RacunIzdat.Width = 70;
            // 
            // Biljeske
            // 
            this.Biljeske.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Biljeske.DataPropertyName = "Biljeske";
            this.Biljeske.HeaderText = "Bilješke";
            this.Biljeske.Name = "Biljeske";
            this.Biljeske.ReadOnly = true;
            // 
            // btn_addUplatu
            // 
            this.btn_addUplatu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addUplatu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addUplatu.Location = new System.Drawing.Point(631, 28);
            this.btn_addUplatu.Name = "btn_addUplatu";
            this.btn_addUplatu.Size = new System.Drawing.Size(257, 30);
            this.btn_addUplatu.TabIndex = 2;
            this.btn_addUplatu.Text = "+";
            this.btn_addUplatu.UseVisualStyleBackColor = true;
            this.btn_addUplatu.Click += new System.EventHandler(this.btn_addUplatu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Grupe kandidata:";
            // 
            // btn_deleteUplatu
            // 
            this.btn_deleteUplatu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deleteUplatu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteUplatu.Location = new System.Drawing.Point(894, 28);
            this.btn_deleteUplatu.Name = "btn_deleteUplatu";
            this.btn_deleteUplatu.Size = new System.Drawing.Size(65, 30);
            this.btn_deleteUplatu.TabIndex = 6;
            this.btn_deleteUplatu.Text = "x";
            this.btn_deleteUplatu.UseVisualStyleBackColor = true;
            this.btn_deleteUplatu.Click += new System.EventHandler(this.btn_deleteUplatu_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.tSMI_OplacenoStatus});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.ShowImageMargin = false;
            this.contextMenuStrip.Size = new System.Drawing.Size(144, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItem1.Text = "Promjena statusa:";
            // 
            // tSMI_OplacenoStatus
            // 
            this.tSMI_OplacenoStatus.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tSMI_OplacenoStatus.Name = "tSMI_OplacenoStatus";
            this.tSMI_OplacenoStatus.Size = new System.Drawing.Size(143, 22);
            this.tSMI_OplacenoStatus.Text = "Otplačeno";
            this.tSMI_OplacenoStatus.Click += new System.EventHandler(this.tSMI_OplacenoStatus_Click);
            // 
            // UplateKandidata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 439);
            this.Controls.Add(this.btn_deleteUplatu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addUplatu);
            this.Controls.Add(this.dGV_Uplate);
            this.Controls.Add(this.dGV_GrupeKandidati);
            this.Name = "UplateKandidata";
            this.ShowIcon = false;
            this.Text = "Uplate kandidata";
            this.Load += new System.EventHandler(this.UplateKandidata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_GrupeKandidati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Uplate)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_GrupeKandidati;
        private System.Windows.Forms.DataGridView dGV_Uplate;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrupaKandidatiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrupaNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn KursNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predavac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uplaceno;
        private System.Windows.Forms.Button btn_addUplatu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UplataKandidataID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumUplate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RacunIzdat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Biljeske;
        private System.Windows.Forms.Button btn_deleteUplatu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tSMI_OplacenoStatus;
    }
}
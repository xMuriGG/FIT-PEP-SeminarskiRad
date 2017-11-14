namespace CZE_Desktop.Forms.OsobaForms
{
    partial class Promote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Promote));
            this.btn_addOsobu = new System.Windows.Forms.Button();
            this.txt_SearchTerm = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.OsobaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsKandidat = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsZaposlenik = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OsobaGridKNalog = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.promoteToKandidatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Kandidat = new System.Windows.Forms.ToolStripMenuItem();
            this.Zaposlenik = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.KorisnickiNalogCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tSMI_Uplate0 = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMI_Uplate1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMI_Uplate3 = new System.Windows.Forms.ToolStripSeparator();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Kandidat = new System.Windows.Forms.CheckBox();
            this.cB_Zaposlenik = new System.Windows.Forms.CheckBox();
            this.cB_Kracun = new System.Windows.Forms.CheckBox();
            this.tSMI_Uplate2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_addOsobu
            // 
            this.btn_addOsobu.Location = new System.Drawing.Point(878, 31);
            this.btn_addOsobu.Name = "btn_addOsobu";
            this.btn_addOsobu.Size = new System.Drawing.Size(75, 23);
            this.btn_addOsobu.TabIndex = 1;
            this.btn_addOsobu.Text = "Dodaj osobu";
            this.btn_addOsobu.UseVisualStyleBackColor = true;
            this.btn_addOsobu.Click += new System.EventHandler(this.btn_addOsobu_Click);
            // 
            // txt_SearchTerm
            // 
            this.txt_SearchTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchTerm.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_SearchTerm.Location = new System.Drawing.Point(12, 28);
            this.txt_SearchTerm.Name = "txt_SearchTerm";
            this.txt_SearchTerm.Size = new System.Drawing.Size(281, 26);
            this.txt_SearchTerm.TabIndex = 2;
            this.txt_SearchTerm.Text = "Ime Prezime";
            this.txt_SearchTerm.Click += new System.EventHandler(this.textBox1_Enter);
            this.txt_SearchTerm.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txt_SearchTerm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SearchTerm_KeyPress);
            this.txt_SearchTerm.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OsobaID,
            this.Ime,
            this.Prezime,
            this.DatumRodjenja,
            this.Spol,
            this.Email,
            this.Adresa,
            this.IsKandidat,
            this.IsZaposlenik,
            this.OsobaGridKNalog});
            this.dataGridView.Location = new System.Drawing.Point(12, 90);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.ContextMenuStrip = this.contextMenuStrip;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(941, 497);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
            this.dataGridView.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.dataGridView_RowContextMenuStripNeeded);
            // 
            // OsobaID
            // 
            this.OsobaID.HeaderText = "OsobaID";
            this.OsobaID.Name = "OsobaID";
            this.OsobaID.ReadOnly = true;
            this.OsobaID.Visible = false;
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.DatumRodjenja.DefaultCellStyle = dataGridViewCellStyle2;
            this.DatumRodjenja.HeaderText = "Datum Rođenja";
            this.DatumRodjenja.Name = "DatumRodjenja";
            this.DatumRodjenja.ReadOnly = true;
            // 
            // Spol
            // 
            this.Spol.DataPropertyName = "Spol";
            this.Spol.HeaderText = "Spol";
            this.Spol.Name = "Spol";
            this.Spol.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // IsKandidat
            // 
            this.IsKandidat.DataPropertyName = "Kandidat";
            this.IsKandidat.HeaderText = "Kandidat";
            this.IsKandidat.IndeterminateValue = "false";
            this.IsKandidat.Name = "IsKandidat";
            this.IsKandidat.ReadOnly = true;
            // 
            // IsZaposlenik
            // 
            this.IsZaposlenik.DataPropertyName = "Zaposlenik";
            this.IsZaposlenik.HeaderText = "Zaposlenik";
            this.IsZaposlenik.IndeterminateValue = "false";
            this.IsZaposlenik.Name = "IsZaposlenik";
            this.IsZaposlenik.ReadOnly = true;
            // 
            // OsobaGridKNalog
            // 
            this.OsobaGridKNalog.DataPropertyName = "KorisnickiNalog";
            this.OsobaGridKNalog.HeaderText = "Korisnički nalog";
            this.OsobaGridKNalog.Name = "OsobaGridKNalog";
            this.OsobaGridKNalog.ReadOnly = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promoteToKandidatToolStripMenuItem,
            this.Kandidat,
            this.Zaposlenik,
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.KorisnickiNalogCreate,
            this.toolStripSeparator2,
            this.tSMI_Uplate0,
            this.tSMI_Uplate1,
            this.tSMI_Uplate2,
            this.tSMI_Uplate3,
            this.Edit,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.ShowImageMargin = false;
            this.contextMenuStrip.Size = new System.Drawing.Size(137, 264);
            // 
            // promoteToKandidatToolStripMenuItem
            // 
            this.promoteToKandidatToolStripMenuItem.Enabled = false;
            this.promoteToKandidatToolStripMenuItem.Name = "promoteToKandidatToolStripMenuItem";
            this.promoteToKandidatToolStripMenuItem.ShowShortcutKeys = false;
            this.promoteToKandidatToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.promoteToKandidatToolStripMenuItem.Text = "Promote to:";
            // 
            // Kandidat
            // 
            this.Kandidat.Enabled = false;
            this.Kandidat.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Kandidat.Name = "Kandidat";
            this.Kandidat.ShortcutKeyDisplayString = "";
            this.Kandidat.Size = new System.Drawing.Size(136, 22);
            this.Kandidat.Text = "Kandidat";
            this.Kandidat.Click += new System.EventHandler(this.Kandidat_Click);
            // 
            // Zaposlenik
            // 
            this.Zaposlenik.Enabled = false;
            this.Zaposlenik.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Zaposlenik.Name = "Zaposlenik";
            this.Zaposlenik.Size = new System.Drawing.Size(136, 22);
            this.Zaposlenik.Text = "Zaposlenik";
            this.Zaposlenik.Click += new System.EventHandler(this.Zaposlenik_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem1.Text = "Korisnički nalog:";
            // 
            // KorisnickiNalogCreate
            // 
            this.KorisnickiNalogCreate.Enabled = false;
            this.KorisnickiNalogCreate.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.KorisnickiNalogCreate.Name = "KorisnickiNalogCreate";
            this.KorisnickiNalogCreate.Size = new System.Drawing.Size(136, 22);
            this.KorisnickiNalogCreate.Text = "Create";
            this.KorisnickiNalogCreate.Click += new System.EventHandler(this.KorisnickiNalogCreate_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(133, 6);
            // 
            // tSMI_Uplate0
            // 
            this.tSMI_Uplate0.Enabled = false;
            this.tSMI_Uplate0.Name = "tSMI_Uplate0";
            this.tSMI_Uplate0.Size = new System.Drawing.Size(136, 22);
            this.tSMI_Uplate0.Text = "Kandidat:";
            this.tSMI_Uplate0.Visible = false;
            // 
            // tSMI_Uplate1
            // 
            this.tSMI_Uplate1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tSMI_Uplate1.Name = "tSMI_Uplate1";
            this.tSMI_Uplate1.Size = new System.Drawing.Size(136, 22);
            this.tSMI_Uplate1.Text = "Uplate";
            this.tSMI_Uplate1.Visible = false;
            this.tSMI_Uplate1.Click += new System.EventHandler(this.tSMI_Uplate_Click);
            // 
            // tSMI_Uplate3
            // 
            this.tSMI_Uplate3.Name = "tSMI_Uplate3";
            this.tSMI_Uplate3.Size = new System.Drawing.Size(133, 6);
            this.tSMI_Uplate3.Visible = false;
            // 
            // Edit
            // 
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(136, 22);
            this.Edit.Text = "Edit";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search.BackgroundImage")));
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Search.Location = new System.Drawing.Point(306, 22);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(35, 32);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Clear.BackgroundImage")));
            this.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Clear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Clear.Location = new System.Drawing.Point(352, 22);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(35, 32);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(13, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Osobe : Desni klik za dodatne funkcionalnosti";
            // 
            // cb_Kandidat
            // 
            this.cb_Kandidat.AutoSize = true;
            this.cb_Kandidat.Location = new System.Drawing.Point(465, 37);
            this.cb_Kandidat.Name = "cb_Kandidat";
            this.cb_Kandidat.Size = new System.Drawing.Size(68, 17);
            this.cb_Kandidat.TabIndex = 7;
            this.cb_Kandidat.Text = "Kandidat";
            this.cb_Kandidat.UseVisualStyleBackColor = true;
            this.cb_Kandidat.CheckedChanged += new System.EventHandler(this.cb_Kandidat_CheckedChanged);
            // 
            // cB_Zaposlenik
            // 
            this.cB_Zaposlenik.AutoSize = true;
            this.cB_Zaposlenik.Location = new System.Drawing.Point(551, 37);
            this.cB_Zaposlenik.Name = "cB_Zaposlenik";
            this.cB_Zaposlenik.Size = new System.Drawing.Size(78, 17);
            this.cB_Zaposlenik.TabIndex = 7;
            this.cB_Zaposlenik.Text = "Zaposlenik";
            this.cB_Zaposlenik.UseVisualStyleBackColor = true;
            this.cB_Zaposlenik.CheckedChanged += new System.EventHandler(this.cb_Kandidat_CheckedChanged);
            // 
            // cB_Kracun
            // 
            this.cB_Kracun.AutoSize = true;
            this.cB_Kracun.Location = new System.Drawing.Point(637, 37);
            this.cB_Kracun.Name = "cB_Kracun";
            this.cB_Kracun.Size = new System.Drawing.Size(101, 17);
            this.cB_Kracun.TabIndex = 7;
            this.cB_Kracun.Text = "Korisnički račun";
            this.cB_Kracun.UseVisualStyleBackColor = true;
            this.cB_Kracun.CheckedChanged += new System.EventHandler(this.cb_Kandidat_CheckedChanged);
            // 
            // tSMI_Uplate2
            // 
            this.tSMI_Uplate2.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tSMI_Uplate2.Name = "tSMI_Uplate2";
            this.tSMI_Uplate2.Size = new System.Drawing.Size(136, 22);
            this.tSMI_Uplate2.Text = "Certifikati";
            this.tSMI_Uplate2.Visible = false;
            this.tSMI_Uplate2.Click += new System.EventHandler(this.tSMI_Certifikati_Click);
            // 
            // Promote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 604);
            this.Controls.Add(this.cB_Kracun);
            this.Controls.Add(this.cB_Zaposlenik);
            this.Controls.Add(this.cb_Kandidat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txt_SearchTerm);
            this.Controls.Add(this.btn_addOsobu);
            this.Name = "Promote";
            this.Text = "Promote";
            this.Load += new System.EventHandler(this.Promote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addOsobu;
        private System.Windows.Forms.TextBox txt_SearchTerm;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem promoteToKandidatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Kandidat;
        private System.Windows.Forms.ToolStripMenuItem Zaposlenik;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KorisnickiNalogCreate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn OsobaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsKandidat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsZaposlenik;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OsobaGridKNalog;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_Kandidat;
        private System.Windows.Forms.CheckBox cB_Zaposlenik;
        private System.Windows.Forms.CheckBox cB_Kracun;
        private System.Windows.Forms.ToolStripMenuItem tSMI_Uplate1;
        private System.Windows.Forms.ToolStripMenuItem tSMI_Uplate0;
        private System.Windows.Forms.ToolStripSeparator tSMI_Uplate3;
        private System.Windows.Forms.ToolStripMenuItem tSMI_Uplate2;
    }
}
using CZE_API.Util;
using CZE_DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CZE_API.Models;
using CZE_Desktop.Forms.Certifikati_kandidata;
using CZE_Desktop.Forms.KorisnickiNalog;
using CZE_Desktop.Forms.Uplate_kandidata;

namespace CZE_Desktop.Forms.OsobaForms
{
    public partial class Promote : Form
    {
        WebAPIHelper client = new WebAPIHelper(Global.GetMessage("route"), "Api/OsobaPromoteGetAll");
        WebAPIHelper osobaClient = new WebAPIHelper(Global.GetMessage("route"), "Api/Osoba");

        HttpResponseMessage response;
        int rowClicked;
        public Promote()
        {
            InitializeComponent();
        }


        private void Promote_Load(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            dataGridView.AutoGenerateColumns = false;
            BindGrid();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {

            txt_SearchTerm.Text = "";
            textBox1_Leave(txt_SearchTerm, null);
            cb_Kandidat.Checked = cB_Zaposlenik.Checked = cB_Kracun.Checked = false;
            BindGrid();
        }
        private void btn_addOsobu_Click(object sender, EventArgs e)
        {
            OsobaForm osobaForm = new OsobaForm();
            DialogResult res = osobaForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void txt_SearchTerm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BindGrid();
            }
        }
        private void BindGrid()
        {
            if (txt_SearchTerm.Text == "Ime Prezime")
            {
                response = client.GetResponse(cb_Kandidat.Checked, cB_Zaposlenik.Checked, cB_Kracun.Checked, "");
            }
            else
            {
                response = client.GetResponse(cb_Kandidat.Checked, cB_Zaposlenik.Checked, cB_Kracun.Checked, txt_SearchTerm.Text);
            }
            dataGridView.DataSource = response.Content.ReadAsAsync<List<OsobaPromoteVM>>().Result;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Ime Prezime")
            {
                tb.Text = "";
                tb.ForeColor = System.Drawing.SystemColors.WindowText;
            }
            else
            {
                //tb.Select(0, tb.Text.Length);
                tb.SelectAll();
                tb.Focus();
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length < 1)
            {
                tb.Text = "Ime Prezime";
                tb.ForeColor = System.Drawing.SystemColors.ScrollBar;
            }
        }

        private void dataGridView_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            //https://stackoverflow.com/questions/3035144/right-click-to-select-a-row-in-a-datagridview-and-show-a-menu-to-delete-it   
            dataGridView.ClearSelection();

            if (e.RowIndex != -1)
            {
                rowClicked = e.RowIndex;
                dataGridView.Rows[rowClicked].Selected = true;

                OsobaPromoteVM o = (OsobaPromoteVM)dataGridView.Rows[rowClicked].DataBoundItem;

                bool isKandidat = o.Kandidat != null, 
                    isZaposlenik = o.Zaposlenik != null,
                    hasKorisnickiNalog=o.KorisnickiNalog!=null;

                //Kandidat items
                contextMenuStrip.Items["Kandidat"].Enabled = !isKandidat;
                tSMI_Uplate0.Visible = isKandidat;
                tSMI_Uplate1.Visible = isKandidat;
                tSMI_Uplate2.Visible = isKandidat;
                tSMI_Uplate3.Visible = isKandidat;

                //Zaposlenik items
                contextMenuStrip.Items["Zaposlenik"].Enabled = !isZaposlenik;

                //Korisnicki nalog items
                KorisnickiNalogCreate.Enabled = !hasKorisnickiNalog && (isZaposlenik || isKandidat);


                e.ContextMenuStrip = contextMenuStrip;
            }
        }
        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //https://stackoverflow.com/questions/650271/itemdatabound-for-a-windows-forms-datagridview
            //https://msdn.microsoft.com/en-us/library/system.windows.forms.datagridview.cellformatting.aspx
            if (this.dataGridView.Columns[e.ColumnIndex].Name == "IsKandidat")
            {
                e.Value = e.Value != null;
            }
            else if (this.dataGridView.Columns[e.ColumnIndex].Name == "IsZaposlenik")
            {
                e.Value = e.Value != null;
            }
            else if (this.dataGridView.Columns[e.ColumnIndex].Name == "OsobaGridKNalog")
            {
                e.Value = e.Value != null;
            }
        }

        private void Zaposlenik_Click(object sender, EventArgs e)
        {
            OsobaPromoteVM o = (OsobaPromoteVM)dataGridView.Rows[rowClicked].DataBoundItem;
            PromoteToZaposlenik z = new PromoteToZaposlenik(o);
            z.ShowDialog();
            if (z.DialogResult == DialogResult.OK)
            {
                BindGrid();
            }
        }
        private void Kandidat_Click(object sender, EventArgs e)
        {
            OsobaPromoteVM o = (OsobaPromoteVM)dataGridView.Rows[rowClicked].DataBoundItem;
            PromoteToKandidat k = new PromoteToKandidat(o);
            k.ShowDialog();
            if (k.DialogResult == DialogResult.OK)
            {
                BindGrid();
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OsobaPromoteVM o = (OsobaPromoteVM)dataGridView.Rows[rowClicked].DataBoundItem;
            DialogResult dialog = MessageBox.Show("Obrisati kirisnika: " + o.Ime + " " + o.Prezime, "Brisanje korisnika", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                response = osobaClient.DeleteResponse(o.OsobaID);
                if (response.IsSuccessStatusCode)
                {
                    BindGrid();
                }
                else
                {
                    MessageBox.Show("Osoba ima poveznicu na drugi entitet.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            OsobaPromoteVM o = (OsobaPromoteVM)dataGridView.Rows[rowClicked].DataBoundItem;
            response = osobaClient.GetResponse(o.OsobaID);
            if (response.IsSuccessStatusCode)
            {
                Osoba real = response.Content.ReadAsAsync<Osoba>().Result;
                OsobaForm osobaForm = new OsobaForm(real);
                DialogResult res = osobaForm.ShowDialog();
                if (res == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }
        private void KorisnickiNalogCreate_Click(object sender, EventArgs e)
        {
            OsobaPromoteVM o = (OsobaPromoteVM)dataGridView.Rows[rowClicked].DataBoundItem;
            KorisnickiNalog.KorisnickiNalogCreate kN = new KorisnickiNalog.KorisnickiNalogCreate(o);
            kN.ShowDialog();
            if (kN.DialogResult == DialogResult.OK)
            {
                BindGrid();
            }
        }
        private void tSMI_Uplate_Click(object sender, EventArgs e)
        {
            OsobaPromoteVM o = (OsobaPromoteVM)dataGridView.Rows[rowClicked].DataBoundItem;
            UplateKandidata uK = new UplateKandidata(o.OsobaID);
            uK.ShowDialog();
        }
        private void tSMI_Certifikati_Click(object sender, EventArgs e)
        {
            OsobaPromoteVM o = (OsobaPromoteVM)dataGridView.Rows[rowClicked].DataBoundItem;
            CertifikatiKandidata c=new CertifikatiKandidata(o);
            c.ShowDialog();
        }


        private void cb_Kandidat_CheckedChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

    }
}

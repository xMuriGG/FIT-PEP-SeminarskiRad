using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CZE_API.Models;
using CZE_API.Util;
using CZE_DAL.Models;

namespace CZE_Desktop.Forms.Certifikati_kandidata
{
    public partial class CertifikatiKandidata : Form
    {

        WebAPIHelper certifikatiKandidataClient = new WebAPIHelper(Global.GetMessage("route"), "Api/Certifikat");
        
        private HttpResponseMessage response;

        private readonly OsobaPromoteVM _kandidat;
        public CertifikatiKandidata(OsobaPromoteVM kandidat)
        {
            _kandidat = kandidat;
            InitializeComponent();
        }

        private void CertifikatiKandidata_Load(object sender, EventArgs e)
        {
            dGV_GrupeKandidati.AutoGenerateColumns = false;


            lbl_grupeKandidata.Text = "Grupe/Certifikati kandidata ' " + _kandidat.Ime + " " + _kandidat.Prezime + " ':";

            GrupeKandidatiSet();

        }
        private void GrupeKandidatiSet()
        {
            response = certifikatiKandidataClient.GetResponse(_kandidat.OsobaID);
            if (response.IsSuccessStatusCode)
            {
                var l = response.Content.ReadAsAsync<List<CertifikatKandidataTableVM>>().Result;
                dGV_GrupeKandidati.DataSource = l;
            }
            dGV_GrupeKandidati.ClearSelection();
        }

        private void dGV_GrupeKandidati_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var gK = (CertifikatKandidataTableVM)dGV_GrupeKandidati.Rows[e.RowIndex].DataBoundItem;
            if (gK.CertifikatOdobren && e.RowIndex != -1 && e.ColumnIndex == 1)
            {
                dGV_GrupeKandidati.Rows[e.RowIndex].DefaultCellStyle.BackColor =
                    gK.Uruceno != null && !(bool)gK.Uruceno ? Color.Khaki : Color.LimeGreen;
            }
        }

        private void dGV_GrupeKandidati_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            var gK = (CertifikatKandidataTableVM)dGV_GrupeKandidati.Rows[e.RowIndex].DataBoundItem;

            dGV_GrupeKandidati.ClearSelection();
            if (e.RowIndex == -1) return;

            dGV_GrupeKandidati.Rows[e.RowIndex].Selected = true;

            tSMI_Printaj.Visible = gK.CertifikatOdobren;
            tSMI_Odobri.Visible = !gK.CertifikatOdobren;
            tSMI_Uruci.Visible = gK.CertifikatOdobren && (bool)((!gK.Uruceno) ?? false);

            e.ContextMenuStrip = contextMenuStrip;
        }
        private void tSMI_Uruci_Click(object sender, EventArgs e)
        {
            if (dGV_GrupeKandidati.SelectedRows.Count == 1)
            {
                var cK = (CertifikatKandidataTableVM) dGV_GrupeKandidati.SelectedRows[0].DataBoundItem;

                response = certifikatiKandidataClient.GetActionResponse("UruciStatusChange",
                    cK.GrupaKandidatiID.ToString());
                if (response.IsSuccessStatusCode)
                {
                    GrupeKandidatiSet();
                }
                else
                {
                    MessageBox.Show("Status uručeno, grupe kandidata nije promjenjen.", Global.GetMessage("greska"), MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }
        private void tSMI_Odobri_Click(object sender, EventArgs e)
        {
            if (dGV_GrupeKandidati.SelectedRows.Count == 1)
            {
                var cK = (CertifikatKandidataTableVM)dGV_GrupeKandidati.SelectedRows[0].DataBoundItem;

               CertifikatiKandidataCreate c=new CertifikatiKandidataCreate(cK);
                DialogResult d = c.ShowDialog();
                if (d==DialogResult.OK)
                {
                    GrupeKandidatiSet();
                }
                else
                {
                    MessageBox.Show("Certifikat kandidata nije odobren u bazi.", Global.GetMessage("greska"), MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void tSMI_Printaj_Click(object sender, EventArgs e)
        {
            var cK = (CertifikatKandidataTableVM)dGV_GrupeKandidati.SelectedRows[0].DataBoundItem;

            PrintanjeCertifikata p =new PrintanjeCertifikata(cK);
            p.ShowDialog();
        }
    }
}


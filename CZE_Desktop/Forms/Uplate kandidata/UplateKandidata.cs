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
using CZE_API.Util;
using CZE_API.Models;
using CZE_DAL.Models;

namespace CZE_Desktop.Forms.Uplate_kandidata
{
    public partial class UplateKandidata : Form
    {
        WebAPIHelper grupaKandidatiClient = new WebAPIHelper(Global.GetMessage("route"), "Api/GrupaKandidati");
        WebAPIHelper uplateKandidataClient = new WebAPIHelper(Global.GetMessage("route"), "Api/UplataKandidata");
        private HttpResponseMessage response;
        private readonly int _kandidatId;

        public UplateKandidata(int kandidatId)
        {
            _kandidatId = kandidatId;
            InitializeComponent();
        }

        private void UplateKandidata_Load(object sender, EventArgs e)
        {
            dGV_GrupeKandidati.AutoGenerateColumns = false;
            dGV_Uplate.AutoGenerateColumns = false;

            GrupeKandidatiSet();
        }

        private void GrupeKandidatiSet()
        {
            response = grupaKandidatiClient.GetActionResponse("TableVM", _kandidatId.ToString());
            if (response.IsSuccessStatusCode)
            {
                List<GrupeKandidatiTableVM> l = response.Content.ReadAsAsync<List<GrupeKandidatiTableVM>>().Result;
                dGV_GrupeKandidati.DataSource = l;
            }
            dGV_GrupeKandidati.ClearSelection();
        }
        private void GetUplateByGrupaKandidati(int grupaKandidatiId)
        {
            response = uplateKandidataClient.GetResponse(grupaKandidatiId);
            if (response.IsSuccessStatusCode)
            {
                List<UplataKandidata> l = response.Content.ReadAsAsync<List<UplataKandidata>>().Result;
                dGV_Uplate.DataSource = l;
            }
        }

        private void dGV_GrupeKandidati_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var gK = (GrupeKandidatiTableVM)dGV_GrupeKandidati.SelectedRows[0].DataBoundItem;
            GetUplateByGrupaKandidati(gK.GrupaKandidatiID);
        }
        private void dGV_GrupeKandidati_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 1)
            {
                var gK = (GrupeKandidatiTableVM)dGV_GrupeKandidati.Rows[e.RowIndex].DataBoundItem;
                if (gK.Otplaceno)
                {
                    dGV_GrupeKandidati.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LimeGreen;
                }
            }

        }
        private void dGV_GrupeKandidati_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            dGV_GrupeKandidati.ClearSelection();
            if (e.RowIndex != -1)
            {
                dGV_GrupeKandidati.Rows[e.RowIndex].Selected = true;
                e.ContextMenuStrip = contextMenuStrip;
            }
        }
        private void tSMI_OplacenoStatus_Click(object sender, EventArgs e)
        {
            var gK = (GrupeKandidatiTableVM)dGV_GrupeKandidati.SelectedRows[0].DataBoundItem;
            response = grupaKandidatiClient.GetActionResponse("OtplacenoStatusChange", gK.GrupaKandidatiID.ToString());
            if (response.IsSuccessStatusCode)
            {
                GrupeKandidatiSet();
            }
            else
            {
                MessageBox.Show("Status otplaćeno, grupe kandidata nije promjenjen.", Global.GetMessage("greska"), MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btn_addUplatu_Click(object sender, EventArgs e)
        {
            if (dGV_GrupeKandidati.SelectedRows.Count == 1)
            {
                var gK = (GrupeKandidatiTableVM)dGV_GrupeKandidati.SelectedRows[0].DataBoundItem;
                UplateKandidataCreate c = new UplateKandidataCreate(gK);
                DialogResult result = c.ShowDialog();
                if (result == DialogResult.OK)
                {
                    GetUplateByGrupaKandidati(gK.GrupaKandidatiID);
                    GrupeKandidatiSet();
                }
                else
                {
                    MessageBox.Show("Uplata kandidata nije pohranjena u bazu.", Global.GetMessage("greska"), MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }
        private void btn_deleteUplatu_Click(object sender, EventArgs e)
        {
            var u = (UplataKandidata)dGV_Uplate.SelectedRows[0].DataBoundItem;

            if (dGV_Uplate.SelectedRows.Count == 1)
            {
                response = uplateKandidataClient.DeleteResponse(u.UplataKandidataID);
                if (response.IsSuccessStatusCode)
                {                  
                    GetUplateByGrupaKandidati(u.GrupaKandidatiID);
                    GrupeKandidatiSet();
                }
                else
                {
                    MessageBox.Show("Uplata kandidata nije izbrisana.", Global.GetMessage("greska"), MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CZE_API.Util;
using System.Net.Http;
using CZE_API.Models;
using CZE_DAL.Models;

namespace CZE_Desktop.Forms.KursForms
{
    public partial class KursMain : Form
    {
        WebAPIHelper kursTipClient = new WebAPIHelper(Global.GetMessage("route"), "Api/KursTip/VM");
        WebAPIHelper kursClient = new WebAPIHelper(Global.GetMessage("route"), "Api/Kurs/VM");
        WebAPIHelper grupaClient = new WebAPIHelper(Global.GetMessage("route"), "Api/Grupa");
        HttpResponseMessage response;

        int rowClicked;

        public KursMain()
        {
            InitializeComponent();
        }

        private void KursMain_Load(object sender, EventArgs e)
        {
            dGV_Kurs.AutoGenerateColumns = false;
            dGV_TipKursa.AutoGenerateColumns = false;
            dGV_Grupa.AutoGenerateColumns = false;
            TipKursaDataGridSet();
        }

        private void TipKursaDataGridSet()
        {
            response = kursTipClient.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<KursTipDisplayListVM> list = response.Content.ReadAsAsync<List<KursTipDisplayListVM>>().Result;
                dGV_TipKursa.DataSource = list;
            }
        }
        private void KursDataGridSet(int id = 0)
        {
            response = kursClient.GetResponse(id);
            if (response.IsSuccessStatusCode)
            {
                List<KursDisplayListVM> list = response.Content.ReadAsAsync<List<KursDisplayListVM>>().Result;
                dGV_Kurs.DataSource = list;
            }
        }
        private void GrupaDataGridSet(int id = 0)
        {
            response = grupaClient.GetResponse(id);
            if (response.IsSuccessStatusCode)
            {
                List<GrupaDisplayListVM> list = response.Content.ReadAsAsync<List<GrupaDisplayListVM>>().Result;
                dGV_Grupa.DataSource = list;
            }
            dGV_Grupa.ClearSelection();
        }

        private void dGV_TipKursa_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int kursID = (int)dGV_TipKursa.SelectedRows[0].Cells["KursTipID"].Value;

            KursDataGridSet(kursID);
            dGV_Grupa.DataSource = null;
        }
        private void dGV_Kurs_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int kursID = (int)dGV_Kurs.SelectedRows[0].Cells["KursID"].Value;
            GrupaDataGridSet(kursID);
        }

        private void btn_AddTipKursa_Click(object sender, EventArgs e)
        {
            TipKursaCreate create = new TipKursaCreate();
            create.ShowDialog();
            if (create.DialogResult == DialogResult.OK)
            {
                TipKursaDataGridSet();
            }
        }
        private void btn_AddKurs_Click(object sender, EventArgs e)
        {
            int kursTipID = dGV_TipKursa.SelectedRows.Count != 0 ? (int)dGV_TipKursa.SelectedRows[0].Cells["KursTipID"].Value : 0;
            KursCreate kCreate = new KursCreate(kursTipID);
            kCreate.ShowDialog();
            if (kCreate.DialogResult == DialogResult.OK)
            {
                KursDataGridSet(kursTipID);
            }
        }
        private void btn_AddGrupa_Click(object sender, EventArgs e)
        {
            GrupaCreate_OpenDialog(GetKursId());
        }

        private int GetKursId()
        {
            return dGV_Kurs.SelectedRows.Count != 0 ? (int)dGV_Kurs.SelectedRows[0].Cells["KursID"].Value : 0;
        }

        private void GrupaCreate_OpenDialog(int kursID,Grupa grupa=null)
        {
            GrupaCreate gCreate = new GrupaCreate(kursID,grupa);
            gCreate.ShowDialog();
            if (gCreate.DialogResult == DialogResult.OK)
            {
                GrupaDataGridSet(kursID);
            }
        }

        private void dGV_Grupa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                GrupaDisplayListVM g = (GrupaDisplayListVM)dGV_Grupa.Rows[e.RowIndex].DataBoundItem;
                if (g.Utoku)
                {
                    dGV_Grupa.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.SeaGreen;
                }
                else if (g.Aktivna)
                {
                    dGV_Grupa.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.GreenYellow;
                }
                else
                {
                    dGV_Grupa.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Firebrick;

                }

            }
        }

        private void dGV_Grupa_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            dGV_Grupa.ClearSelection();

            if (e.RowIndex != -1)
            {
                cMS_Grupa_Utoku.Enabled = false;
                cMS_Grupa_Zavrsena.Enabled = false;

                rowClicked = e.RowIndex;
                dGV_Grupa.Rows[rowClicked].Selected = true;

                GrupaDisplayListVM g = (GrupaDisplayListVM)dGV_Grupa.Rows[e.RowIndex].DataBoundItem;

                if (g.Utoku)
                {
                    cMS_Grupa_Zavrsena.Enabled = true;
                }
                else if (g.Aktivna)
                {
                    cMS_Grupa_Utoku.Enabled = true;
                }
                e.ContextMenuStrip = cMS_Grupa;
            }
        }
        private void cMS_Grupa_Utoku_Click(object sender, EventArgs e)
        {
            GrupaDisplayListVM g = (GrupaDisplayListVM)dGV_Grupa.Rows[dGV_Grupa.SelectedRows[0].Index].DataBoundItem;
            response= grupaClient.GetActionResponse("StatusToUtoku",g.GrupaID.ToString());
            if (response.IsSuccessStatusCode)
            {
              dGV_Kurs_CellMouseClick(null,null);
            }
        }
        private void cMS_Grupa_Zavrsena_Click(object sender, EventArgs e)
        {
            GrupaDisplayListVM g = (GrupaDisplayListVM)dGV_Grupa.Rows[dGV_Grupa.SelectedRows[0].Index].DataBoundItem;
            response = grupaClient.GetActionResponse("StatusToZavrsena", g.GrupaID.ToString());
            if (response.IsSuccessStatusCode)
            {
                dGV_Kurs_CellMouseClick(null, null);
            }
        }

        private void cMS_EditGrupa_Click(object sender, EventArgs e)
        {
            GrupaDisplayListVM g = (GrupaDisplayListVM)dGV_Grupa.Rows[dGV_Grupa.SelectedRows[0].Index].DataBoundItem;
            response = grupaClient.GetActionResponse("GetGrupaById", g.GrupaID.ToString());
            if (response.IsSuccessStatusCode)
            {
                Grupa grupa = response.Content.ReadAsAsync<Grupa>().Result;
                GrupaCreate_OpenDialog(GetKursId(),grupa);
                
            }
        }
    }
}

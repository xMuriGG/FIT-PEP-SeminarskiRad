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

namespace CZE_Desktop.Forms.KursForms
{
    public partial class KursCreate : Form
    {
        private readonly int tipKursaID=0;
        WebAPIHelper kursTipClient = new WebAPIHelper(Global.GetMessage("route"), "Api/KursTip");
        WebAPIHelper kursClient = new WebAPIHelper(Global.GetMessage("route"), "Api/Kurs");
        HttpResponseMessage response;

        public KursCreate(int tipKursa=0)
        {
            this.tipKursaID = tipKursa;
            InitializeComponent();
        }

        private void KursCreate_Load(object sender, EventArgs e)
        {
            KursTipComboBoxSet();
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void KursTipComboBoxSet()
        {
            response = kursTipClient.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<KursTip> kT = response.Content.ReadAsAsync<List<KursTip>>().Result;
                TipKursa_i.DataSource = kT;
                TipKursa_i.DisplayMember = "Naziv";
                TipKursa_i.ValueMember = "KursTipID";
                if (tipKursaID != 0)
                {
                    TipKursa_i.SelectedValue = tipKursaID;
                }
                else
                {
                    TipKursa_i.SelectedIndex = -1;
                }
            }
        }
        private void btn_Snimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Kurs k = new Kurs()
                {
                    KursTipID = (int)TipKursa_i.SelectedValue,
                    Naziv = Naziv_i.Text,
                    Opis = Opis_i.Text
                };
                response = kursClient.PostResponse(k);
                if (response.IsSuccessStatusCode)
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(response.ReasonPhrase, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } 
            }

        }

        private void TipKursa_i_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cB = sender as ComboBox;
            if (cB.SelectedIndex == -1)
            {
                errorProvider.SetError(cB, "Tip kursa je obavezno polje.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cB, "");
            }
        }
        private void Naziv_i_Validating(object sender, CancelEventArgs e)
        {
            TextBox tB = sender as TextBox;
            if (string.IsNullOrEmpty(tB.Text))
            {
                errorProvider.SetError(tB, "Naziv je obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tB, "");
            }
        }
    }
}


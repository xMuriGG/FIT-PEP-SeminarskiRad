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

    public partial class TipKursaCreate : Form
    {
        WebAPIHelper kategorijaClient = new WebAPIHelper(Global.GetMessage("route"), "Api/KursKategorija");
        WebAPIHelper kursTipClient = new WebAPIHelper(Global.GetMessage("route"), "Api/KursTip");

        HttpResponseMessage response;
        public TipKursaCreate()
        {
            InitializeComponent();
        }

        private void TipKursaCreate_Load(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;

            KursKategorijaCBSet();
        }

        private void KursKategorijaCBSet()
        {
            response = kategorijaClient.GetResponse();
            List<KursKategorija> l = response.Content.ReadAsAsync<List<KursKategorija>>().Result;
            Kategorija_i.DataSource = l;
            Kategorija_i.ValueMember = "KursKategorijaID";
            Kategorija_i.DisplayMember = "Naziv";
            Kategorija_i.SelectedIndex = -1;
        }

        private void btn_Snimi_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren())
            {
                KursTip kT = new KursTip();
                kT.KursKategorijaID = (int)Kategorija_i.SelectedValue;
                //kT.Naziv = Naziv_i.Text;
                kT.Naziv = null;
                kT.Trajanje = Convert.ToInt32(Trajanje_i.Text);
                kT.Cijena = Convert.ToDecimal(Cijena_i.Text);
                kT.Opis = Opis_i.Text;

                response = kursTipClient.PostResponse(kT);

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

        private void Kategorija_i_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cB = sender as ComboBox;
            if (cB.SelectedIndex == -1)
            {
                errorProvider.SetError(cB, "Kategorija je obavezno polje.");
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

        private void Trajanje_i_Validating(object sender, CancelEventArgs e)
        {
            TextBox tB = sender as TextBox;
            if (string.IsNullOrEmpty(tB.Text))
            {
                errorProvider.SetError(tB, "Trajanje je obavezno polje.");
                e.Cancel = true;
            }
            else
            {
                int i;
                if (!int.TryParse(tB.Text, out i))
                {
                    errorProvider.SetError(tB, "Trajanje mora biti broj koji predstavlja časove.");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(tB, "");
                }
            }
        }

        private void Cijena_i_Validating(object sender, CancelEventArgs e)
        {
            TextBox tB = sender as TextBox;
            if (string.IsNullOrEmpty(tB.Text))
            {
                errorProvider.SetError(tB, "Cijena je obavezno polje.");
                e.Cancel = true;
            }
            else
            {
                decimal i;
                if (!decimal.TryParse(tB.Text, out i))
                {
                    errorProvider.SetError(tB, "Cijena mora biti decimalni broj.");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(tB, "");
                }
            }
        }
    }
}

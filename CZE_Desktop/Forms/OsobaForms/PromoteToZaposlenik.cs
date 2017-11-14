using CZE_API.Models;
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
using CZE_API.Helper;
using System.Text.RegularExpressions;

namespace CZE_Desktop.Forms.OsobaForms
{
    public partial class PromoteToZaposlenik : Form
    {
        OsobaPromoteVM osoba;
        WebAPIHelper client = new WebAPIHelper(Global.GetMessage("route"), "Api/Grad");
        WebAPIHelper zaposlenikClient = new WebAPIHelper(Global.GetMessage("route"), "Api/Zaposlenik");
        public PromoteToZaposlenik(OsobaPromoteVM osoba)
        {
            this.osoba = osoba;
            InitializeComponent();
        }

        private void PromoteToZaposlenik_Load(object sender, EventArgs e)
        {
            SetOsobaControls();

            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            StepenObrazovanja_i.DataSource = MyEnumExtentions.ToIEnumerable(new StepeniObrazovanja());
            StepenObrazovanja_i.SelectedIndex = -1;

        }

        private void SetOsobaControls()
        {
            lbl_ImePrezime.Text = osoba.Ime + " " + osoba.Prezime;
            lbl_Spol.Text = osoba.Spol.ToString();
            lbl_AdrStanovanja.Text = osoba.Adresa;
            lbl_DatumR.Text = osoba.DatumRodjenja.ToShortDateString();
            lbl_Email.Text = osoba.Email;
            HttpResponseMessage response = client.GetResponse(osoba.GradID);
            string gNaziv = "/";
            if (response.IsSuccessStatusCode)
            {
                gNaziv = response.Content.ReadAsAsync<Grad>().Result.Naziv;
            }
            lbl_MjestoR.Text = gNaziv;
        }

        private void StepenObrazovanja_i_Validating(object sender, CancelEventArgs e)
        {
            if (StepenObrazovanja_i.SelectedIndex != -1)
            {
                errorProvider.SetError(StepenObrazovanja_i, "");
            }
            else
            {
                errorProvider.SetError(StepenObrazovanja_i, "Stepen obrazovanja je obavezno polje.");
                e.Cancel = true;
            }
        }
        private void BrRadneKnjizice_i_Validating(object sender, CancelEventArgs e)
        {
            if (BrRadneKnjizice_i.Text.Length > 5)
            {
                if (Regex.IsMatch(BrRadneKnjizice_i.Text, @"\d"))
                {
                    errorProvider.SetError(BrRadneKnjizice_i, "");
                }
                else
                {
                    errorProvider.SetError(BrRadneKnjizice_i, "Broj radne knjižice mora biti broj.");
                    e.Cancel = true;
                }
            }
            else
            {
                errorProvider.SetError(BrRadneKnjizice_i, "Broj radne knjižice je obavezno polje.");
                e.Cancel = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (ValidateChildren())
            {
                Osoba o = new Osoba() { OsobaID = osoba.OsobaID };
                Zaposlenik z = new Zaposlenik();
                
                z.StepenObrazovanja = (StepeniObrazovanja)StepenObrazovanja_i.SelectedValue;
                z.BrojRadneKnjizice = BrRadneKnjizice_i.Text;
                z.Osoba = o;

                HttpResponseMessage response = zaposlenikClient.PostResponse(z);

                if (response.IsSuccessStatusCode)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(response.ReasonPhrase, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

       
    }
}

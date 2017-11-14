using CZE_API.Models;
using CZE_API.Util;
using CZE_DAL.Models;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace CZE_Desktop.Forms.OsobaForms
{
    public partial class PromoteToKandidat : Form
    {
        OsobaPromoteVM osoba = new OsobaPromoteVM();
        WebAPIHelper client = new WebAPIHelper(Global.GetMessage("route"), "Api/Grad");
        WebAPIHelper kandidatClient = new WebAPIHelper(Global.GetMessage("route"), "Api/Kandidat");
        HttpResponseMessage response;
        public PromoteToKandidat(OsobaPromoteVM o)
        {
            osoba = o;
            InitializeComponent();
        }

        private void PromoteToKandidat_Load(object sender, EventArgs e)
        {
            SetOsobaControls();
        }
        private void SetOsobaControls()
        {
            lbl_ImePrezime.Text = osoba.Ime + " " + osoba.Prezime;
            lbl_Spol.Text = osoba.Spol.ToString();
            lbl_AdrStanovanja.Text = osoba.Adresa;
            lbl_DatumR.Text = osoba.DatumRodjenja.ToShortDateString();
            lbl_Email.Text = osoba.Email;
            response = client.GetResponse(osoba.GradID);
            string gNaziv = "/";
            if (response.IsSuccessStatusCode)
            {
                gNaziv = response.Content.ReadAsAsync<Grad>().Result.Naziv;
            }
            lbl_MjestoR.Text = gNaziv;
        }
        private void btn_Snimi_Click(object sender, EventArgs e)
        {
            Osoba o = new Osoba() { OsobaID = osoba.OsobaID };
            Kandidat k = new Kandidat() { DatumUpisa = Datum_i.Value, Biljeske = biljeske_i.Text,Osoba=o };
            response = kandidatClient.PostResponse(k);
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

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
using RestSharp;

namespace CZE_Desktop.Forms.KorisnickiNalog
{
    public partial class KorisnickiNalogCreate : Form
    {
        OsobaPromoteVM osoba = new OsobaPromoteVM();
        WebAPIHelper client = new WebAPIHelper(Global.GetMessage("route"), "Api/Grad");
        WebAPIHelper kNalogclient = new WebAPIHelper(Global.GetMessage("route"), "Api/KorisnickiNalog");
        WebAPIHelper osobaBrojTelefonaclient = new WebAPIHelper(Global.GetMessage("route"), "Api/BrojTelefona");


        HttpResponseMessage response;

        public KorisnickiNalogCreate(OsobaPromoteVM o)
        {
            osoba = o;
            InitializeComponent();
        }
        private void KorisnickiNalogCreate_Load(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            SetOsobaControls();
            Uloga_i.DataSource = MyEnumExtentions.ToIEnumerable(new UlogaKorisnika());
            Uloga_i.SelectedIndex = -1;
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
            cB_IsZaposlenik.Checked = osoba.Kandidat != null;
            cB_IsZaposlenik.Checked = osoba.Zaposlenik != null;
        }

        private void btn_Snimi_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren())
            {
                CZE_DAL.Models.KorisnickiNalog kN = new CZE_DAL.Models.KorisnickiNalog() { };

                kN.KorisnickoIme = KorisnickoIme_i.Text;
                kN.LozinkaSalt = UIHelper.GenerateSalt();
                kN.LozinkaHash = UIHelper.GenerateHash(Lozinka_i.Text, kN.LozinkaSalt);
                kN.UlogaKorisnika = (UlogaKorisnika)Uloga_i.SelectedValue;
                kN.Aktivan = true;
                kN.KorisnickiNalogID = osoba.OsobaID;

                response = kNalogclient.PostResponse(kN);
                if (response.IsSuccessStatusCode)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(response.ReasonPhrase, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (Poruka_i.Checked)
                {
                    string errMessage = "";
                    response = osobaBrojTelefonaclient.GetResponse(osoba.OsobaID);
                    List<BrojTelefona> brojevi = response.Content.ReadAsAsync<List<BrojTelefona>>().Result;
                    foreach (BrojTelefona br in brojevi)
                    {
                        if (br.TipTelefona == TipoviTelefona.Mobilni)
                        {
                            IRestResponse Iresponse = Notifications
                                .KandidatUspjesnaRegistracija(osoba.Ime + " " + osoba.Prezime, kN.KorisnickoIme, Lozinka_i.Text, br.Broj);
                            if (Iresponse.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                errMessage += "Poruka poslana na broj:" + br.Broj.ToString() + "\n";

                            }
                            else
                            {
                                errMessage += "Poruka nije poslana na broj:" + br.Broj.ToString() + "\n";
                            }
                        }
                    }
                    MessageBox.Show(errMessage, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //MessageBox.Show("SMS Info: Nisam uspio povratiti račun na infoBipu");
                }
            }

        }

        private void btn_RandomizeLozinka_Click(object sender, EventArgs e)
        {
            Lozinka_i.Text = UIHelper.GenerateSalt(6);
        }

        private void Lozinka_i_Validating(object sender, CancelEventArgs e)
        {
            TextBox tB = sender as TextBox;
            if (string.IsNullOrEmpty(tB.Text))
            {
                errorProvider.SetError(tB, "Lozinka je obavezno polje.");
                e.Cancel = true;
            }
            else
            {
                if (tB.Text.Length < 6)
                {
                    errorProvider.SetError(tB, "Lozinka mora biti minimalno 6 karaktera.");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(tB, "");
                }
            }
        }

        private void Uloga_i_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cB = sender as ComboBox;
            if (cB.SelectedIndex == -1)
            {
                errorProvider.SetError(cB, "Uloga korisnika je obavezno polje.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cB, "");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CZE_API.Helper;
using CZE_DAL.Models;
using CZE_API.Util;
using System.Net.Http;

namespace CZE_Desktop.Forms.OsobaForms
{
    public partial class OsobaForm : Form
    {
        Osoba osoba;
        bool editMode = false;
        WebAPIHelper gradClient = new WebAPIHelper(Global.GetMessage("route"), "Api/Grad");
        WebAPIHelper OsobaClient = new WebAPIHelper(Global.GetMessage("route"), "Api/Osoba");
        int brojTelefona = 1;
        const int razmak = 5;

        public OsobaForm(Osoba o = null)
        {
            InitializeComponent();
            if (o != null)
            {
                editMode = true;
                osoba = o;            
            }
        }
        private void OsobaForm_Load(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;

            Broj0_cB.DataSource = MyEnumExtentions.ToIEnumerable(new TipoviTelefona()); ;
            Spol_i.DataSource = MyEnumExtentions.ToIEnumerable(new Spol());
            Spol_i.SelectedIndex = -1;

            HttpResponseMessage gradResponse = gradClient.GetResponse();
            if (gradResponse.IsSuccessStatusCode)
            {
                List<Grad> gradovi = gradResponse.Content.ReadAsAsync<List<Grad>>().Result;
                MjestoRodjenja_i.DataSource = gradovi;
                MjestoRodjenja_i.ValueMember = "GradID";
                MjestoRodjenja_i.DisplayMember = "Naziv";
                MjestoRodjenja_i.SelectedIndex = -1;
            }
            if (editMode)
            {
                SetOsobaControls();
            }
        }
        private void AddBrojBTN_Click(object sender, EventArgs e)
        {
            DodajBrojTelefonaKontrole();
        }

        private void DodajBrojTelefonaKontrole()
        {
            if (brojTelefona < 5)
            {
                TextBox br = new TextBox();
                br.Name = "Broj" + brojTelefona + "_i";
                br.Size = Broj0_i.Size;
                br.Validating += new System.ComponentModel.CancelEventHandler(Broj_i_Validating);


                ComboBox cb = new ComboBox();
                cb.Name = "Broj" + brojTelefona + "_cB";
                cb.Size = Broj0_cB.Size;
                cb.DropDownStyle = ComboBoxStyle.DropDownList;
                cb.DataSource = MyEnumExtentions.ToIEnumerable(new TipoviTelefona());

                br.Location = new Point(Broj0_i.Left, Broj0_i.Top + ((Broj0_i.Height + razmak)) * brojTelefona);
                cb.Location = new Point(Broj0_cB.Left, Broj0_cB.Top + ((Broj0_cB.Height + razmak)) * brojTelefona);

                AddBrojBTN.Location = new Point(AddBrojBTN.Left, AddBrojBTN.Top + Broj0_i.Height + razmak);
                RemoveBrojBTN.Location = new Point(RemoveBrojBTN.Left, RemoveBrojBTN.Top + Broj0_i.Height + razmak);

                brojTelefona++;
                this.Controls.Add(br);
                this.Controls.Add(cb);

            }
        }

        private void RemoveBrojBTN_Click(object sender, EventArgs e)
        {
            if (brojTelefona > 1)
            {
                TextBox tbox = this.Controls.Find("Broj" + (brojTelefona-1) + "_i", true).FirstOrDefault() as TextBox;
                ComboBox cbox = this.Controls.Find("Broj" + (brojTelefona-1) + "_cB", true).FirstOrDefault() as ComboBox;
                if (tbox != null && cbox != null)
                {
                    this.Controls.Remove(tbox);
                    this.Controls.Remove(cbox);

                    AddBrojBTN.Location = new Point(AddBrojBTN.Left, AddBrojBTN.Top - Broj0_i.Height - razmak);
                    RemoveBrojBTN.Location = new Point(RemoveBrojBTN.Left, RemoveBrojBTN.Top - Broj0_i.Height - razmak);
                    brojTelefona--;
                }
            }
        }
        private void SnimiBTN_Click(object sender, EventArgs e)
        {

            errorProvider.Clear();
            if (ValidateChildren())
            {
                Osoba o = new Osoba();
                o.Ime = Ime_i.Text;
                o.Prezime = Prezime_i.Text;
                o.DatumRodjenja = DatumRodjenja_i.Value;
                o.Spol = (Spol)Spol_i.SelectedValue;
                o.Email = Email_i.Text;
                o.Adresa = Adresa_i.Text;
                o.GradID = Convert.ToInt32(MjestoRodjenja_i.SelectedValue);


                o.BrojTelefona = new List<BrojTelefona>();
                for (int i = 0; i < brojTelefona; i++)
                {
                    TextBox tb = this.Controls.Find("Broj" + i + "_i", false).FirstOrDefault() as TextBox;
                    ComboBox cb = this.Controls.Find("Broj" + i + "_cB", false).FirstOrDefault() as ComboBox;
                    o.BrojTelefona.Add(new BrojTelefona { Broj = tb.Text, TipTelefona = (TipoviTelefona)cb.SelectedValue });
                }
                HttpResponseMessage response;
                if (editMode)
                {
                    o.OsobaID = osoba.OsobaID;
                    response = OsobaClient.PutResponse(o);
                }
                else
                {
                    response = OsobaClient.PostResponse(o);
                }
                if (response.IsSuccessStatusCode)
                {
                    this.DialogResult=DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(response.ReasonPhrase, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        #region validations
        private void Broj_i_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text.Length < 10)
            {
                errorProvider.SetError(tb, "Broj telefona je obavezno polje.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tb, "");
            }
        }
        private void Ime_i_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(Ime_i.Text))
            {
                errorProvider.SetError(Ime_i, "Ime je obavezno polje.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(Ime_i, "");
            }
        }

        private void Prezime_i_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(Prezime_i.Text))
            {
                errorProvider.SetError(Prezime_i, "Prezime je obavezno polje.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(Prezime_i, "");
            }
        }

        private void Email_i_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Email_i.Text))
            {
                errorProvider.SetError(Email_i, "Email je obavezno polje.");
                e.Cancel = true;
            }
            else
            {
                try
                {
                    new System.Net.Mail.MailAddress(Email_i.Text);
                    errorProvider.SetError(Email_i, "");

                }
                catch (Exception)
                {
                    errorProvider.SetError(Email_i, "Email nije u ispravnom formatu.");
                    e.Cancel = true;
                }
            }
        }
        private void Spol_i_Validating(object sender, CancelEventArgs e)
        {

            if (Spol_i.SelectedIndex == -1)
            {
                errorProvider.SetError(Spol_i, "Spol je obavezno polje.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(Spol_i, "");
            }
        }

        private void Adresa_i_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(Adresa_i.Text))
            {
                errorProvider.SetError(Adresa_i, "Adresa je obavezno polje.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(Adresa_i, "");
            }
        }

        private void MjestoRodjenja_i_Validating(object sender, CancelEventArgs e)
        {
            if (MjestoRodjenja_i.SelectedIndex == -1)
            {
                errorProvider.SetError(MjestoRodjenja_i, "Mjesto rođenja je obavezno polje.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(MjestoRodjenja_i, "");
            }
        }

        private void OsobaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
        #endregion

        private void SetOsobaControls()
        {
            Ime_i.Text = osoba.Ime;
            Prezime_i.Text = osoba.Prezime;
            DatumRodjenja_i.Value = osoba.DatumRodjenja;
            Spol_i.SelectedItem = osoba.Spol;
            Email_i.Text = osoba.Email;
            Adresa_i.Text = osoba.Adresa;
            MjestoRodjenja_i.SelectedValue = osoba.GradID;
            if (osoba.BrojTelefona != null && osoba.BrojTelefona.Count!=0)
            {
                Broj0_i.Text = osoba.BrojTelefona[0].Broj;
                Broj0_cB.SelectedItem = osoba.BrojTelefona[0].TipTelefona;
                for (int i = 1; i < osoba.BrojTelefona.Count; i++)
                {
                    DodajBrojTelefonaKontrole();
                    TextBox tbox = this.Controls.Find("Broj" + i + "_i", true).FirstOrDefault() as TextBox;
                    ComboBox cbox = this.Controls.Find("Broj" + i + "_cB", true).FirstOrDefault() as ComboBox;
                    tbox.Text = osoba.BrojTelefona[i].Broj;
                    cbox.SelectedItem = osoba.BrojTelefona[i].TipTelefona;

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

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


namespace CZE_Desktop.Forms.Uplate_kandidata
{
    public partial class UplateKandidataCreate : Form
    {
        private readonly GrupeKandidatiTableVM _grupaKandidata;
        WebAPIHelper uplateKandidataClient = new WebAPIHelper(Global.GetMessage("route"), "Api/UplataKandidata");
        private HttpResponseMessage response;

        public UplateKandidataCreate(GrupeKandidatiTableVM grupaKandidata)
        {
            this._grupaKandidata = grupaKandidata;
            InitializeComponent();
        }

        private void UplateKandidataCreate_Load(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;

            GrupaKandidati_i.Text = _grupaKandidata.GrupaNaziv + " | " + _grupaKandidata.KursNaziv + " | " + _grupaKandidata.TipNaziv;
        }

        private void btn_Snimi_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                UplataKandidata u = new UplataKandidata();
                u.GrupaKandidatiID = _grupaKandidata.GrupaKandidatiID;
                u.Kolicina = Convert.ToDecimal(Kolicina_i.Text);
                u.RacunIzdat = racunIzdat_i.Checked;
                u.Biljeske = Biljeske_i.Text;
                u.ZaposlenikID = Global.logiraniKorisnik.KorisnickiNalogID;
                u.DatumUplate = DateTime.Now;

                response = uplateKandidataClient.PostResponse(u);

                if (response.IsSuccessStatusCode)
                {
                    this.DialogResult = DialogResult.OK;
                }
                this.Close();
            }
        }

        private void Kolicina_i_Validating(object sender, CancelEventArgs e)
        {
            decimal d;

            if (!string.IsNullOrEmpty(Kolicina_i.Text))
            {
                try
                {
                    Convert.ToDecimal(Kolicina_i.Text);
                    errorProvider.SetError(Kolicina_i, "");
                }
                catch (Exception)
                {
                    errorProvider.SetError(Kolicina_i, "Količina mora biti decimalan broj.");
                }
            }
            else
            {
                errorProvider.SetError(Kolicina_i, "Količina je obavezno polje.");
            }
        }
    }
}

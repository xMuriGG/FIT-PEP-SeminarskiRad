using System;
using System.Net.Http;
using System.Windows.Forms;
using CZE_API.Models;
using CZE_API.Util;
using CZE_DAL.Models;


namespace CZE_Desktop.Forms.Certifikati_kandidata
{
    public partial class CertifikatiKandidataCreate : Form
    {
        private readonly CertifikatKandidataTableVM _grupaKandidata;
        WebAPIHelper certifikatKandidataClient = new WebAPIHelper(Global.GetMessage("route"), "Api/Certifikat");
        private HttpResponseMessage response;

        public CertifikatiKandidataCreate(CertifikatKandidataTableVM grupaKandidata)
        {
            _grupaKandidata = grupaKandidata;
            InitializeComponent();
        }

        private void CertifikatiKandidataCreate_Load(object sender, EventArgs e)
        {
            GrupaKandidati_i.Text = _grupaKandidata.GrupaNaziv + " | " + _grupaKandidata.KursNaziv + " | " + _grupaKandidata.TipNaziv;

        }

        private void btn_Snimi_Click(object sender, EventArgs e)
        {
            var c = new Certifikat
            {
                CertifikatID = _grupaKandidata.GrupaKandidatiID,
                DatumOdobrenja = DatumOdobrenja_i.Value,
                Biljeske = Biljeske_i.Text,
                Uruceno = false,
                ZaposlenikID = Global.logiraniKorisnik.KorisnickiNalogID
            };
            response = certifikatKandidataClient.PostResponse(c);
            if (response.IsSuccessStatusCode)
            {
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }
    }
}

using System;
using System.Net;
using System.Windows.Forms;
using System.Net.Http;
using CZE_API.Models;
using CZE_API.Util;
using CZE_Desktop;

namespace eProdaja_UI
{
    public partial class LoginForm : Form
    {
        WebAPIHelper korisnickiNalogService = new WebAPIHelper(Global.GetMessage("route"), "Api/KorisnickiNalog");
        HttpResponseMessage response;

        public LoginForm()
        {
            InitializeComponent();
            korisnickoImeInput.Text = "test";
            lozinkaInput.Text = "test123";

        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void potvrdiButton_Click(object sender, EventArgs e)
        {
            response = korisnickiNalogService.GetResponse(korisnickoImeInput.Text + "/");
            if (response.IsSuccessStatusCode)
            {
                LogiraniKorisnik lK = response.Content.ReadAsAsync<LogiraniKorisnik>().Result;
                string hash = UIHelper.GenerateHash(lozinkaInput.Text, lK.LozinkaSalt);
                if (string.Compare(hash, lK.LozinkaHash) == 0)
                {
                    Global.logiraniKorisnik = lK;                
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Login podaci nisu ispravni.", Global.GetMessage("greska"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (response.StatusCode==HttpStatusCode.NotFound)
            {
                MessageBox.Show("Login podaci nisu ispravni.", Global.GetMessage("greska"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Greška pri komunikaciji sa API serverom.", Global.GetMessage("greska"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void lozinkaInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                potvrdiButton_Click(sender, EventArgs.Empty);
        }

    }
}

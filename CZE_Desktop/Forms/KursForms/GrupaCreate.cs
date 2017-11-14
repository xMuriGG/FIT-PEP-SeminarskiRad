using CZE_API.Util;
using CZE_DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CZE_Desktop.Forms.KursForms
{
    public partial class GrupaCreate : Form
    {
        private Grupa _grupa;
        private bool editMode = false;
        private readonly int kursID;
        WebAPIHelper kursClient = new WebAPIHelper(Global.GetMessage("route"), "Api/Kurs");
        WebAPIHelper zaposlenikClient = new WebAPIHelper(Global.GetMessage("route"), "Api/Zaposlenik");
        WebAPIHelper grupaClient = new WebAPIHelper(Global.GetMessage("route"), "Api/Grupa");
        HttpResponseMessage response;
        public GrupaCreate(int kursID=0,Grupa grupa=null)
        {
            if (grupa!=null)
            {
                editMode = true;
            }
            _grupa = grupa;

            this.kursID = kursID;
            InitializeComponent();
        }

        private void GrupaCreate_Load(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            KursComboBoxSet();
            PredavacComboBoxSet();

            if (_grupa != null)
            {
                SetEditFields();
            }

            DatumZavrsetka_i.Value = DatumZavrsetka_i.Value.AddMonths(2);
        }
        private void SetEditFields()
        {
            Kurs_i.SelectedValue = _grupa.KursID;
            Naziv_i.Text = _grupa.Naziv;
            DatumPocetka_i.Value = _grupa.Pocetak;
            Predavac_i.SelectedValue = _grupa.ZaposlenikID;
            if (_grupa.SlikaThumb!=null)
            {
                using (var ms=new MemoryStream(_grupa.SlikaThumb))
                {
                    pictureBox.Image=Image.FromStream(ms) ;                   
                }
            }

        }

        private void PredavacComboBoxSet()
        {
            response = zaposlenikClient.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Zaposlenik> z = response.Content.ReadAsAsync<List<Zaposlenik>>().Result;
                Predavac_i.DataSource = z;
                //Predavac_i.DisplayMember->Predavac_i_Format
                Predavac_i.ValueMember = "ZaposlenikID";
                Predavac_i.SelectedIndex = -1;
            }
        }
        private void KursComboBoxSet()
        {
            response = kursClient.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Kurs> k = response.Content.ReadAsAsync<List<Kurs>>().Result;
                Kurs_i.DataSource = k;
                Kurs_i.DisplayMember = "Naziv";
                Kurs_i.ValueMember = "KursID";
                if (kursID != 0)
                {
                    Kurs_i.SelectedValue = kursID;
                }
                else
                {
                    Kurs_i.SelectedIndex = -1;
                }
            }
        }

        private void Predavac_i_Format(object sender, ListControlConvertEventArgs e)
        {
            Zaposlenik z = (Zaposlenik)e.ListItem;
            e.Value = z.Osoba.Ime + " " + z.Osoba.Prezime;
        }

        private void cB_i_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cB = sender as ComboBox;
            if (cB.SelectedIndex == -1)
            {
                errorProvider.SetError(cB, "Ovo polje je obavezno polje.");
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
                errorProvider.SetError(tB, "Naziv je obavezno polje.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tB, "");
            }
        }

        private void btn_Snimi_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (_grupa==null)
                {
                   _grupa=new Grupa();
                }

                _grupa.KursID = (int)Kurs_i.SelectedValue;
                _grupa.Naziv = Naziv_i.Text;
                _grupa.Pocetak = DatumPocetka_i.Value;
                _grupa.Kraj = DatumZavrsetka_i.Value;
                _grupa.Aktivna = !editMode || _grupa.Aktivna;
                _grupa.ZaposlenikID = (int) Predavac_i.SelectedValue;

                response = grupaClient.PostResponse(_grupa);
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

        private void pictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                if (_grupa == null)
                    _grupa = new Grupa();

                openFileDialog.ShowDialog();
                slikaInput.Text = openFileDialog.FileName;

                Image image = Image.FromFile(slikaInput.Text);

                MemoryStream ms = new MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                _grupa.Slika = ms.ToArray();

                int resizedWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgWidth"]);
                int resizedHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgHeight"]);
                int croppedWidth = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgWidth"]);
                int croppedHeight = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgHeight"]);

                if (image.Width > resizedWidth)
                {
                    //Umanjiti sliku
                    Image resizedImage = UIHelper.ResizeImage(image, new Size(resizedWidth, resizedHeight));
                    Image croppedImage = resizedImage;

                    int croppedXPosition = (resizedImage.Width - croppedWidth) / 2;
                    int croppedYPosition = (resizedImage.Height - croppedHeight) / 2;

                    //Provjera da li je umanjena slika dovoljna za crop dimenzije
                    if (resizedImage.Width >= croppedWidth && resizedImage.Height >= croppedHeight)
                    {
                        croppedImage = UIHelper.CropImage(resizedImage, new Rectangle(croppedXPosition, croppedYPosition, croppedWidth, croppedHeight));
                        ms = new MemoryStream();
                        croppedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        _grupa.SlikaThumb = ms.ToArray();

                        pictureBox.Image = croppedImage;
                    }

                }
                else
                {
                    MessageBox.Show(Global.GetMessage("picture_war") + " " + resizedWidth + "x" + resizedHeight + ".", Global.GetMessage("warning"),
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _grupa = null;
                }
            }
            catch (Exception)
            {
                _grupa = null;
                pictureBox.Image = null;
                slikaInput.Text = "";
            }
        }
    }
}

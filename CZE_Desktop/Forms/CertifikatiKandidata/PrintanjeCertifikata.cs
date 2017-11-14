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
using Microsoft.Reporting.WinForms;

namespace CZE_Desktop.Forms.Certifikati_kandidata
{
    public partial class PrintanjeCertifikata : Form
    {
        WebAPIHelper certifikatKandidataClient = new WebAPIHelper(Global.GetMessage("route"), "Api/Certifikat");
        private HttpResponseMessage response;
        public CertifikatKandidataTableVM _info { get; set; }
        DataTable dt = new DataTable("Areas");

        public PrintanjeCertifikata(CertifikatKandidataTableVM info)
        {
            _info = info;
            InitializeComponent();
        }

        private void PrintanjeCertifikata_Load(object sender, EventArgs e)
        {

            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);


            response = certifikatKandidataClient.GetActionResponse("Print", _info.GrupaKandidatiID.ToString());
            if (!response.IsSuccessStatusCode)
            {
                this.DialogResult = DialogResult.Retry;
                this.Close();
            }
            CertifikatPrintVM ctx = response.Content.ReadAsAsync<CertifikatPrintVM>().Result;
            CertifikatPrintVMBindingSource.DataSource = ctx;
            ReportDataSource rds = new ReportDataSource("DataSet1", CertifikatPrintVMBindingSource);
            reportViewer1.LocalReport.DataSources.Add(rds);


            RefreshReport();
            frm_printanjeCertifikata_SizeChanged(null, null);

            kreirajTabeluZaCB();
            cB.DataSource = dt;
            cB.DisplayMember = "Naziv";
            cB.ValueMember = "id";


        }
        private void kreirajTabeluZaCB()
        {
            dt.Columns.Add("id", typeof(String));
            dt.Columns.Add("Naziv", typeof(String));
            dt.Columns.Add("Area1", typeof(String));
            dt.Columns.Add("Area2", typeof(String));
            dt.Columns.Add("Area3", typeof(String));
            dt.Columns.Add("Area4", typeof(String));
            dt.Columns.Add("Area5", typeof(String));


            dt.Rows.Add(new Object[] { 0, "Custom", " ", " ", " ", " ", " " });
            dt.Rows.Add(new Object[] {
                1,
                "Njemački jezik",
                "O USPJEŠNO ODSLUŠANOM KURSU I POLOZENOM ISPITU IZ NJEMAČKOG JEZIKA",
                "BESCHEINIGUNG UBER DIE ERFOLGREICHE TEILNAHME AM DEUTSCHSPRACHKURS UND DIE ABGELEGTE PRUFUNG",
                "geboren <<datum>> god., in <<grad>>",
                "je odslušao/la kurs, te uspješno položio/la test o poznavanju njemačkog jezika u skladu sa Evropskim referentnim okvirom za jezike za nivo",
                "Deutschsprachkurs teilgenommen und eine Prufung im Einklang mit den Gemeinsamen europaischen Referenzrahmen fur Sprachen auf def folgenden Niveaustufe erfolgreich abgelegt" });

            dt.Rows.Add(new Object[] {
                2, "Engleski jezik",
                "O USPJEŠNO ODSLUŠANOM KURSU I POLOZENOM ISPITU IZ ENGLESKOG JEZIKA",
                "OF SUCCESSFULLY COMPLETING THE COURSE AND PASSING EXAM OF ENGLISH LANGUAGE",
                "born <<datum>> god., in <<grad>>",
                "je odslušao/la kurs, te uspješno položio/la test o poznavanju engleskog jezika u skladu sa Evropskim referentnim okvirom za jezike za nivo",
                "He/she has completed the course and successfully passed the test of knowledge of the English language in accordance with the Common European Framework of Reference for Languages" });
        }
        private void RefreshReport()
        {
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Area1", tB1.Text));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Area2", tB2.Text));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Area3", tB3.Text));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Area4", tB4.Text));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Area5", tB5.Text));

            this.reportViewer1.RefreshReport();
        }
        private void buttonVisibility(bool visible)
        {
            btn_Area1.Visible = visible;
            btn_Area2.Visible = visible;
            btn_Area3.Visible = visible;
            btn_Area4.Visible = visible;
            btn_Area5.Visible = visible;
        }
        private void frm_printanjeCertifikata_SizeChanged(object sender, EventArgs e)
        {
            int width = (int)(reportViewer1.Width / 2 - btn_Area1.Size.Width) + 50, height = reportViewer1.Height + btn_Area1.Size.Height + 10;

            Point p = new Point(width, (int)(height * 0.25));

            btn_Area1.Location = p;
            p.Offset(0, (int)height / 14);
            btn_Area2.Location = p;
            p.Offset(0, (int)(height / 5.3));
            btn_Area3.Location = p;
            p.Offset(0, (int)(height * 0.085));
            btn_Area4.Location = p;
            p.Offset(0, (int)(height * 0.055));
            btn_Area5.Location = p;

            btn_Area1.Width = width / 10;
            btn_Area1.Height = (int)height / 20;

            btn_Area2.Width = width / 10;
            btn_Area2.Height = (int)height / 20;

            btn_Area3.Width = width / 10;
            btn_Area3.Height = (int)height / 20;

            btn_Area4.Width = width / 10;
            btn_Area4.Height = (int)height / 20;

            btn_Area5.Width = width / 10;
            btn_Area5.Height = (int)height / 20;

            cB.Focus();
        }
        private void cB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cB.SelectedValue);
            tB1.Text = dt.Rows[id]["Area1"].ToString();
            tB2.Text = dt.Rows[id]["Area2"].ToString();
            tB3.Text = dt.Rows[id]["Area3"].ToString();
            tB4.Text = dt.Rows[id]["Area4"].ToString();
            tB5.Text = dt.Rows[id]["Area5"].ToString();

            RefreshReport();
        }
        private void frm_printanjeCertifikata_MouseClick(object sender, MouseEventArgs e)
        {
            cB.Focus();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                buttonVisibility(true);
            }
            else
            {
                buttonVisibility(false);
            }
        }
        private void btn_Area1_Click(object sender, EventArgs e)
        {
            TextBox tb;
            Button b = sender as Button;
            int id = Convert.ToInt32(b.Text);

            switch (id)
            {
                case 1: tb = tB1; break;
                case 2: tb = tB2; break;
                case 3: tb = tB3; break;
                case 4: tb = tB4; break;
                case 5: tb = tB5; break;
                default: tb = tB1; break;
            }

            tb.Width = reportViewer1.Width - 200;

            int width = tb.Size.Width, height = tb.Size.Height;
            Point p = new Point((int)(b.Location.X + (b.Width / 2)) - (int)(width / 2), b.Location.Y);
            tb.Location = p;

            tb.Visible = true;
            tb.Focus();
        }
        private void tB1_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.Visible = false;
            cB.Focus();
        }

        private void cB_Enter(object sender, EventArgs e)
        {
            RefreshReport();
        }
    }
}

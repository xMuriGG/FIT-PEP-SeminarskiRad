using CZE_Desktop.Forms.KursForms;
using CZE_Desktop.Forms.OsobaForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CZE_Desktop.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OsobaForm oF = new OsobaForm();
            oF.MdiParent = this;
            oF.Show();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Promote p = new Promote();
            p.WindowState = FormWindowState.Maximized;
            p.MdiParent = this;
            p.Show();
        }
        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KursMain k = new KursMain();
            k.WindowState = FormWindowState.Maximized;
            k.MdiParent = this;
            k.Show();
        }


    }
}

using CZE_API.Models;
using CZE_Desktop.Forms;
using CZE_Desktop.Forms.KorisnickiNalog;
using CZE_Desktop.Forms.KursForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using eProdaja_UI;

namespace CZE_Desktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (loginForm.DialogResult == DialogResult.OK)
                Application.Run(new MainForm());
        }
    }
}

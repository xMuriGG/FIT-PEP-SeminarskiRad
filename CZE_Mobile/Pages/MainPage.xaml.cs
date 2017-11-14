using CZE_Mobile.Pages.Grupe;
using CZE_Mobile.Pages.KorisnickiProfil;
using CZE_Mobile.Pages.Prijava;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using CZE_Mobile.Common;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace CZE_Mobile
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private NavigationHelper navigationHelper;
        private string navState;
        public MainPage()
        {
            this.InitializeComponent();
            navigationHelper=new NavigationHelper(this);
            this.NavigationCacheMode = NavigationCacheMode.Required;
            //HardwareButtons.BackPressed += HardwareButtons_BackPressed;       
        }

        //private void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        //{
        //    if (Frame.CurrentSourcePageType == typeof(MainPage))
        //    {
        //        Frame.BackStack.Clear();
        //    }
        //    else
        //    {
        //        Frame.GoBack();
        //    }
        //    e.Handled = true;
        //}


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Button btn_Prijava = new Button()
            {
                Name = "btn_Prijava",
                Content = "Prijava",
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch
            };

            sP_Buttons.Children.Insert(0, btn_Prijava);

            if (Global.logiraniKorisnik != null)
            {
                lbl_logiraniKorisnik.Text = "Welcome " + Global.logiraniKorisnik.Ime + " " + Global.logiraniKorisnik.Prezime;
                lbl_logiraniKorisnik.Visibility = Visibility.Visible;
                btn_Prijava.Content = "Moj profil";
                btn_Prijava.Click += new RoutedEventHandler(btn_MojProfil_Click);
            }
            else
            {
                lbl_logiraniKorisnik.Visibility = Visibility.Collapsed;
                btn_Prijava.Content = "Prijava";
                btn_Prijava.Click += new RoutedEventHandler(btn_Prijava_Click);
            }

        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            sP_Buttons.Children.RemoveAt(0);
        }

        private void btn_MojProfil_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(KorisnickiProfilMain));
        }
        private void btn_Prijava_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PrijavaMain));
        }  
        private void btn_AktivneGrupe_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AktivneGrupe));

        }

       
    }
}

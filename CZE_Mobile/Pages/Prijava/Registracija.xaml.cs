using CZE_Mobile.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using CZE_PCL.Util;
using CZE_PCL.Models;
using System.Net.Http;
using System.Text.RegularExpressions;
using Windows.UI.Popups;

namespace CZE_Mobile.Pages.Prijava
{

    public sealed partial class Registracija : Page
    {
        WebAPIHelper gradService = new WebAPIHelper(Global.GetMessage("route"), "Api/Grad");
        WebAPIHelper osobaService = new WebAPIHelper(Global.GetMessage("route"), "Api/Osoba");
        HttpResponseMessage response;
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        public Registracija()
        {
            this.InitializeComponent();

            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += this.NavigationHelper_LoadState;
            this.navigationHelper.SaveState += this.NavigationHelper_SaveState;
        }
        #region Generated
        /// <summary>
        /// Gets the <see cref="NavigationHelper"/> associated with this <see cref="Page"/>.
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        /// <summary>
        /// Gets the view model for this <see cref="Page"/>.
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }
        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }
        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session.  The state will be null the first time a page is visited.</param>
        #endregion
        private void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {

            spolInput.ItemsSource = Enum.GetValues(typeof(Spol)).Cast<Spol>();
            response = gradService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                mjestoRodjenjaInput.ItemsSource = response.Content.ReadAsAsync<List<Grad>>().Result;
                mjestoRodjenjaInput.DisplayMemberPath = "Naziv";
            }
        }

        private async void registracijaButton_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msg;
            bool emailb = false;
            string email = emailInput.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                emailb = true;


            if (imeInput.Text.Length<1 || prezimeInput.Text.Length<1 || 
                spolInput.SelectedIndex==-1 || adresaInput.Text.Length<1 || mjestoRodjenjaInput.SelectedIndex==-1
                || brojTelefona.Text.Length<12 || !emailb)
            {
                msg = new MessageDialog("Validacija");
                await msg.ShowAsync();
                return;
            }

                Osoba o = new Osoba();
                o.Ime = imeInput.Text;
                o.Prezime = prezimeInput.Text;
                o.DatumRodjenja = datumRodjenjaInput.Date.Date;
                o.Spol = (Spol)spolInput.SelectedValue;
                o.Email = emailInput.Text;
                o.Adresa = adresaInput.Text;
                o.GradID = ((Grad)mjestoRodjenjaInput.SelectedValue).GradID;

                o.BrojTelefona = new List<BrojTelefona>();
                o.BrojTelefona.Add(new BrojTelefona() { Broj = brojTelefona.Text, TipTelefona = TipoviTelefona.Mobilni });

                response = osobaService.PostResponse(o);
                if (response.IsSuccessStatusCode)
                {
                    msg = new MessageDialog("Zahtjev uspješno poslan.");
                    await msg.ShowAsync();
                    Frame.Navigate(typeof(MainPage));
                }
                else
                {
                    msg = new MessageDialog("Zahtjev nije poslan.");
                    await msg.ShowAsync();
                }
            
           
        }


        #region NavigationHelper registration

        /// <summary>
        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// <para>
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="NavigationHelper.LoadState"/>
        /// and <see cref="NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.
        /// </para>
        /// </summary>
        /// <param name="e">Provides data for navigation methods and event
        /// handlers that cannot cancel the navigation request.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

    }
}

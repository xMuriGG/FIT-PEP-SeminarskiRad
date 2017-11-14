using CZE_Mobile.Common;
using CZE_PCL.Models;
using CZE_PCL.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace CZE_Mobile.Pages.Kurs
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class KursOcjena : Page
    {
        WebAPIHelper ocjenaService = new WebAPIHelper(Global.GetMessage("route"), "Api/Ocjena");
        HttpResponseMessage response;

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();
        AktivnaGrupaListVM aGD;
        int b = 0;

        public KursOcjena()
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
            b = 0;
            aGD = e.NavigationParameter as AktivnaGrupaListVM;
            kurs.Text = aGD.KursNaziv;
            opisKursa.Text = aGD.KursOpis ?? "";
            tipKursa.Text = aGD.KursTipNaziv;
            trajanje.Text = aGD.KursTipTrajanje.ToString() + " časova";
            cijena.Text = aGD.KursTipCijena.ToString() + "KM";
            opisTipaKursa.Text = aGD.KursTipOpis ?? "";
            kategorija.Text = aGD.KursKategorijaNaziv;

            int[] items = { 1, 2, 3, 4, 5 };
            cB_Ocjena.ItemsSource = items;

            response = ocjenaService.GetResponse(Global.logiraniKorisnik.KorisnickiNalogID, aGD.KursID);
            if (response.IsSuccessStatusCode)
            {
                Ocjene o = response.Content.ReadAsAsync<Ocjene>().Result;
                cB_Ocjena.SelectedValue = o.Ocjena;
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
        private async void cB_Ocjena_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                ComboBox cB = sender as ComboBox;
            if (isDropDownOpened)
            {
                int val = (int)cB.SelectedValue;
                Ocjene o = new Ocjene();
                o.KandidatID = Global.logiraniKorisnik.KorisnickiNalogID;
                o.KursID = aGD.KursID;
                o.Ocjena = (int)cB.SelectedValue;
                o.Datum = DateTime.Now;

                response = ocjenaService.PostResponse(o);
                if (response.IsSuccessStatusCode)
                {
                    MessageDialog msg = new MessageDialog("Ocjena snimljena.");
                    await msg.ShowAsync();
                }
                else
                {
                    MessageDialog msg = new MessageDialog(response.ReasonPhrase);
                    await msg.ShowAsync();
                }
            }
            isDropDownOpened = false;
            //Nastaviti
        }
        bool isDropDownOpened;
        private void cB_Ocjena_DropDownOpened(object sender, object e)
        {
            isDropDownOpened = true;
        }
    }
}

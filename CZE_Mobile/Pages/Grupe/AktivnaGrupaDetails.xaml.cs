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
using CZE_PCL.Models;
using CZE_PCL.Util;
using System.Net.Http;
using Windows.UI;
using Windows.UI.Popups;
// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace CZE_Mobile.Pages.Grupe
{

    public sealed partial class AktivnaGrupaDetails : Page
    {
        public NavigationHelper NavigationHelper { get; }
        public ObservableDictionary DefaultViewModel { get; } = new ObservableDictionary();

        WebAPIHelper grupaKandidatiService = new WebAPIHelper(Global.GetMessage("route"), "Api/GrupaKandidati");
        WebAPIHelper grupaPreporukaService = new WebAPIHelper(Global.GetMessage("route"), "Api/Grupa/PreporuceneGrupe");

        HttpResponseMessage response;

        AktivnaGrupaListVM aGD;

        public AktivnaGrupaDetails()
        {
            this.InitializeComponent();


            this.NavigationHelper = new NavigationHelper(this);
            this.NavigationHelper.LoadState += this.NavigationHelper_LoadState;
            this.NavigationHelper.SaveState += this.NavigationHelper_SaveState;
        }
        #region Generated
        /// <summary>
        /// Gets the <see cref="NavigationHelper"/> associated with this <see cref="Page"/>.
        /// </summary>

        /// <summary>
        /// Gets the view model for this <see cref="Page"/>.
        /// This can be changed to a strongly typed view model.
        /// </summary>

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
            aGD = e.NavigationParameter as AktivnaGrupaListVM;
            nazivgrupe.Text = aGD.GrupaNaziv;
            datumPocetka.Text = aGD.Pocetak.ToString("dd-MM-yyyy");
            datumZavrsetka.Text = aGD.Kraj != null ? aGD.Kraj.Value.Date.ToString("dd-MM-yyyy") : "/";
            kurs.Text = aGD.KursNaziv;
            opisKursa.Text = aGD.KursOpis ?? "";
            tipKursa.Text = aGD.KursTipNaziv;
            trajanje.Text = aGD.KursTipTrajanje.ToString() + " časova";
            cijena.Text = aGD.KursTipCijena.ToString() + "KM";
            opisTipaKursa.Text = aGD.KursTipOpis ?? "";
            kategorija.Text = aGD.KursKategorijaNaziv;
            predavac.Text = aGD.ImePrezimeZaposlenika;

            if (Global.IsKorisnikLogovan && Global.logiraniKorisnik.IsKandidat)
            {
                btn_Prijava.Visibility = Visibility.Visible;
            }

            HttpResponseMessage preporukaResponse = grupaPreporukaService.GetResponse(aGD.KursID);
            if (preporukaResponse.IsSuccessStatusCode)
            {
                List<AktivnaGrupaListVM> l = preporukaResponse.Content.ReadAsAsync<List<AktivnaGrupaListVM>>().Result;
                GrupeList.ItemsSource = l;
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
            this.NavigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            this.NavigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private async void btn_Prijava_Click(object sender, RoutedEventArgs e)
        {
            if (Global.IsKorisnikLogovan && Global.logiraniKorisnik.IsKandidat)
            {
                GrupaKandidati gK = new GrupaKandidati()
                {
                    KandidatID = Global.logiraniKorisnik.KorisnickiNalogID,
                    Otplaceno = false,
                    GrupaID = aGD.GrupaID
                };
                response = grupaKandidatiService.PostResponse(gK);
                if (response.IsSuccessStatusCode)
                {
                    MessageDialog msg = new MessageDialog("Uspješno ste prijavljeni u grupu.");
                    await msg.ShowAsync();
                }
                else
                {
                    MessageDialog msg = new MessageDialog(response.ReasonPhrase);
                    await msg.ShowAsync();
                }
            }
        }

        private void GrupeList_OnItemClick(object sender, ItemClickEventArgs e)
        {
            AktivnaGrupaListVM aG = (AktivnaGrupaListVM)e.ClickedItem;
            Frame.Navigate(typeof(AktivnaGrupaDetails), aG);
        }
    }
}

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
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using CZE_Mobile.Common;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace CZE_Mobile.Pages.Grupe
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AktivneGrupe : Page
    {
        private NavigationHelper _navigationHelper;

        WebAPIHelper kursKategorijaService = new WebAPIHelper(Global.GetMessage("route"), "Api/KursKategorija");
        WebAPIHelper kursTipService = new WebAPIHelper(Global.GetMessage("route"), "Api/KursTip");
        WebAPIHelper grupaService = new WebAPIHelper(Global.GetMessage("route"), "Api/Grupa");
        HttpResponseMessage response;

        public AktivneGrupe()
        {
            this.InitializeComponent();
            _navigationHelper=new NavigationHelper(this);
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            response = kursKategorijaService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                KategorijaInput.ItemsSource = response.Content.ReadAsAsync<List<KursKategorija>>().Result;
                KategorijaInput.DisplayMemberPath = "Naziv";
            }

            SetMostRatedAktivneGrupe();
        }

        private void SetMostRatedAktivneGrupe()
        {
            response = grupaService.GetActionResponse("MostRated");
            if (response.IsSuccessStatusCode)
            {
                List<AktivnaGrupaListVM> l = response.Content.ReadAsAsync<List<AktivnaGrupaListVM>>().Result;
                GrupeList.ItemsSource = l;
            }
        }

        private void showPopUp_Click(object sender, RoutedEventArgs e)
        {
            if (popup.IsOpen)
            {
                popup.Visibility = Visibility.Collapsed;
                popup.IsOpen = false;
                TipKursaInput.SelectedIndex = -1;
                KategorijaInput.SelectedIndex = -1;
                SetMostRatedAktivneGrupe();
            }
            else
            {
                popup.Visibility = Visibility.Visible;
                popup.IsOpen = true;
            }

        }

        private void KategorijaInput_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cB = sender as ComboBox;
            if (cB.SelectedIndex != -1)
            {
                response = kursTipService.GetResponse(((KursKategorija)cB.SelectedValue).KursKategorijaID);
                if (response.IsSuccessStatusCode)
                {
                    TipKursaInput.ItemsSource = response.Content.ReadAsAsync<List<KursTip>>().Result;
                    TipKursaInput.DisplayMemberPath = "Naziv";
                    TipKursaInput.IsEnabled = true;
                }
            }
        }
        private void TipKursaInput_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cB = sender as ComboBox;
            if (cB.SelectedIndex != -1)
            {
                var cBSelectedValue = (KursTip) cB.SelectedValue;
                if (cBSelectedValue != null)
                    response = grupaService.GetActionResponse("VM", cBSelectedValue.KursTipID.ToString());
                if (response.IsSuccessStatusCode)
                {
                    List<AktivnaGrupaListVM> l= response.Content.ReadAsAsync<List<AktivnaGrupaListVM>>().Result;
                    GrupeList.ItemsSource = l;
                }
            }
        }

        private void GrupeList_ItemClick(object sender, ItemClickEventArgs e)
        {
            AktivnaGrupaListVM aG = (AktivnaGrupaListVM)e.ClickedItem;
            Frame.Navigate(typeof(AktivnaGrupaDetails), aG);
        }
    }
}

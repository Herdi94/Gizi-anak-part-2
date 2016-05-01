using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;



// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GiziUntukAnak
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class KalkulatorGizi : Page
    {
        public KalkulatorGizi()
        {
            this.InitializeComponent();

            //register back request event for current  view (onback in mobile)
            Windows.UI.Core.SystemNavigationManager.GetForCurrentView().BackRequested +=
            App_BackRequested;

        }


        private void App_BackRequested(object sender,
      Windows.UI.Core.BackRequestedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame == null)
                return;

            // Navigate back if possible, and if the event has not 
            // already been handled .
            if (rootFrame.CanGoBack && e.Handled == false)
            {
                e.Handled = true;
                rootFrame.GoBack();
            }
        }

        //BBI umur 0 - 12 bulan 
        private double calcBbiBayi(double umu)
        {
            return (umu / 2) + 4;
        }

        //BBI umur 1 - 10 tahun 
        private double calcBbiBayi2(double umu2)
        {
            return (umu2 * 2) + 8;
        }


        private void btnHamburger_Click(object sender, RoutedEventArgs e)
        {
            splitView1.IsPaneOpen = !splitView1.IsPaneOpen;
        }

        private void iconListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (polaListBoxItem.IsSelected)
            {
                Frame.Navigate(typeof(PolaGizi));
            }
            else if (kalkulatorListBoxItem.IsSelected)
            {
                Frame.Navigate(typeof(KalkulatorGizi));
            }
            else if (TentangListBoxItem.IsSelected)
            {
                Frame.Navigate(typeof(Tentang));

            }
            else if (BerandaListBoxItem.IsSelected)
            {
                Frame.Navigate(typeof(MainPage));
            }
        }

      //Button umur 0 - 12 bulan
        private void btnHitung_Click(object sender, RoutedEventArgs e)
        {
            double umur, hasilBbi;
            if(double.TryParse(umurTextBox.Text,out umur))
            {
                hasilBbi = calcBbiBayi(umur);
                labelHasil.Text = "Berat badan ideal adalah "+hasilBbi.ToString()+" kg";
            }
            else
            {
                labelHasil.Text = "Mohon diisi terlebih dulu!";
            }
        }

        //Button umur 1 - 10 tahun
        private void btnHitung2_Click(object sender, RoutedEventArgs e)
        {
            double umur2, hasilBbi2;
            if (double.TryParse(umurTextBox2.Text, out umur2))
            {
                hasilBbi2 = calcBbiBayi2(umur2);
                labelHasil2.Text = "Berat badan ideal adalah " + hasilBbi2.ToString() + " kg";
            }
            else
            {
                labelHasil2.Text = "Mohon diisi terlebih dulu!";
            }
        }


        //onback in dekstop UWP
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;

            string myPages = "";
            foreach (PageStackEntry page in rootFrame.BackStack)
            {
                myPages += page.SourcePageType.ToString() + "\n";
            }
            //stackCount.Text = myPages;

            if (rootFrame.CanGoBack)
            {
                // Show UI in title bar if opted-in and in-app backstack is not empty.
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
                    AppViewBackButtonVisibility.Visible;
            }
            else
            {
                // Remove the UI from the title bar if in-app back stack is empty.
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
                    AppViewBackButtonVisibility.Collapsed;
            }
        }

    }
}
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

namespace GiziUntukAnak.ListView
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ListUmur2 : Page
    {
        public ListUmur2()
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

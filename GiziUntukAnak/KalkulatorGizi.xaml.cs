using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

       
    }
}

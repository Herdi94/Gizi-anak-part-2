using GiziUntukAnak.ListView;
using GiziUntukAnak.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GiziUntukAnak
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PolaGizi : Page
    {
        private List<Gizi> gizi2;
        public PolaGizi()
        {
            this.InitializeComponent();
            this.InitializeComponent();
            gizi2 = GiziManager.GetGizi2();
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
            else if(BerandaListBoxItem.IsSelected)
            {
                Frame.Navigate(typeof(MainPage));
            }
        }

        private void btnHamburger_Click(object sender, RoutedEventArgs e)
        {
            splitView1.IsPaneOpen = !splitView1.IsPaneOpen;
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var gizi2 = (Gizi)e.ClickedItem;

            if (gizi2.Sub.Equals("untuk usia 0 - 2 tahun"))
                this.Frame.Navigate(typeof(ListUmur2));
            else if (gizi2.Sub.Equals("untuk usia 3 - 5 tahun"))
                this.Frame.Navigate(typeof(ListUmur5));

            else if (gizi2.Sub.Equals("untuk usia 6 - 9 tahun"))
                this.Frame.Navigate(typeof(ListUmur9));

        }

    }
}

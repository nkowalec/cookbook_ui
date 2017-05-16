using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=234238

namespace cookbook_ui
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class SearchPage : Page
    {
        public SearchPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Koszt: " + ((ComboBoxItem)kosztCBox.SelectedItem).Content);
            sb.AppendLine("Czas: " + ((ComboBoxItem)czasCBox.SelectedItem).Content);
            sb.AppendLine("Kategoria: " + ((ComboBoxItem)katCBox.SelectedItem).Content);
            
            MessageDialog dial = new MessageDialog("Widok wyszukanych przepisów: \n" + searchBox.Text + "\n" + sb.ToString());
            await dial.ShowAsync();
            Frame.Navigate(typeof(HomePage));
        }
    }
}

﻿using System;
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
using Windows.UI.Xaml.Navigation;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=234238

namespace cookbook_ui
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class CategoriesPage : Page
    {
        public CategoriesPage()
        {
            this.InitializeComponent();
        }

        public async void Open_Category(object sender, RoutedEventArgs args)
        {
            await new MessageDialog("Otwarcie kategorii " + ((TextBlock)((Border)((Button)sender).Content).Child).Text + "\nwidok jak \"GŁÓWNY\" - Przeglądaj").ShowAsync();
        }
    }
}

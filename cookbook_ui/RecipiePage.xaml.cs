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

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=234238

namespace cookbook_ui
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class RecipiePage : Page
    {
        public RecipiePage()
        {
            this.InitializeComponent();
            MainPage.PokazujKomendy(true);
            skladnikiBlock.Text = @"- pierś z kurczaka: 500 g
- makaron muszelki: 250 g
- Fix Spaghetti Bolognese Knorr: 1 opak
- woda: 400 ml
- pieczarki: 150 g
- pomidory: 2 szt
- marchew: 100 g
- cebula dymka: 3 szt
- gałązka natki pietruszki
- żółty ser: 100 g
- oliwa z oliwek: 15 ml";
        }
    }
}

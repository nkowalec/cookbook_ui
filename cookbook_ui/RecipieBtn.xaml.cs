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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace cookbook_ui
{
    public sealed partial class RecipieBtn : UserControl
    {
        public RecipieBtn()
        {
            this.InitializeComponent();
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(RecipieBtn), null);



        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Image.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register("Image", typeof(ImageSource), typeof(RecipieBtn), null);



        public string PrepTime
        {
            get { return (string)GetValue(PrepTimeProperty); }
            set { SetValue(PrepTimeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PrepTime.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PrepTimeProperty =
            DependencyProperty.Register("PrepTime", typeof(string), typeof(RecipieBtn), null);



        public string Cost
        {
            get { return (string)GetValue(CostProperty); }
            set { SetValue(CostProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Cost.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CostProperty =
            DependencyProperty.Register("Cost", typeof(string), typeof(RecipieBtn), null);


    }
}

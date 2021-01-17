using Museum.MUSEUM;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Museum
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ViewModel mview;
        public MainPage()
        {
            this.InitializeComponent();
            this.tType_of_Object.ItemsSource =
                new List<string> { "Historic", "Culture", "Artistic", "Archaeology", "Libartion War" };
            mview = new ViewModel();
            this.DataContext = mview;
       }

        private void First_Click(object sender, RoutedEventArgs e)
        {
            this.mview.First();
        }

        private void Prev_Click(object sender, RoutedEventArgs e)
        {
            this.mview.Previous();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            this.mview.Next();
        }

        private void Last_Click(object sender, RoutedEventArgs e)
        {
            this.mview.Last();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            this.mview.AddNew();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            this.mview.BeginEdit();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            this.mview.Save();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.mview.Cancel();
        }
    }
}

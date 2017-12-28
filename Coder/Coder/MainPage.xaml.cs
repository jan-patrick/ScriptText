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

namespace Coder
{
    /// <summary>
    /// Coder, a coding program
    /// </summary>
    ///     
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        public Library Library = new Library();

        private void New_Click(object sender, RoutedEventArgs e)
        {
            Library.New(Display);
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            Library.Open(Display);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Library.Save(Display);
        }
    }
}

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
using Windows.UI.Core;

namespace ScriptText
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        CoreCursor buttonCursor = null;
        CoreCursor cursorBeforePointerEntered = null;
        public MainPage()
        {
            this.InitializeComponent();
            buttonCursor = new CoreCursor(CoreCursorType.Hand, 0);
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
        private void Button_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            // Cache the cursor set before pointer enter on button.
            cursorBeforePointerEntered = Window.Current.CoreWindow.PointerCursor;
            // Set button cursor.
            Window.Current.CoreWindow.PointerCursor = buttonCursor;
        }

        private void Button_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            // Change the cursor back.
            Window.Current.CoreWindow.PointerCursor = cursorBeforePointerEntered;
        }
    }
}
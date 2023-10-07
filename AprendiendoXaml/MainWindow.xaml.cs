using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace AprendiendoXaml
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //Create button
            Button originalButton = new Button();
            originalButton.Height = 50;
            originalButton.Width = 100;
            originalButton.Background = Brushes.AliceBlue;
            originalButton.Content = "Click Me";

            //Save the button to a string
            string savedButton  = XamlWriter.Save(originalButton);

            //Load the button
            StringReader stringReader = new StringReader(savedButton);
            XmlReader xmlReader = XmlReader.Create(stringReader);
            Button readerLoadButton = (Button)XamlReader.Load(xmlReader);

        }
    }
}

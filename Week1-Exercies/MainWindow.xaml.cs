using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Week1_Exercies
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Band> allBands = new List<Band>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Band band1 = new Band()
            {
                BandName = "dtyhg",
                YearFormed = 0,
                Members = ""
            };

            Band band2 = new Band()
            {
                BandName = "ctyjygf",
                YearFormed = 0,
                Members = ""
            };

            Band band3 = new Band()
            {
                BandName = "ayutdj",
                YearFormed = 0,
                Members = ""
            };

            Band band4 = new Band()
            {
                BandName = "bytjhey",
                YearFormed = 0,
                Members = ""
            };

            Band band5 = new Band()
            {
                BandName = "eyuteu",
                YearFormed = 0,
                Members = ""
            };

            Band band6 = new Band()
            {
                BandName = "yte",
                YearFormed = 0,
                Members = ""
            };

            allBands.Add(band1);
            allBands.Add(band2);
            allBands.Add(band3);
            allBands.Add(band4);
            allBands.Add(band5);
            allBands.Add(band6);

            allBands.Sort();

            lbxBands.ItemsSource = allBands;
        }
    }
}

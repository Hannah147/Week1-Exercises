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
        static Random r = new Random();
        List<Band> allBands = new List<Band>();
        List<Band> filteredBands = new List<Band>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RockBand band1 = new RockBand()
            {
                BandName = "Fleetwood Mac",
                YearFormed = 0,
                Members = "ghjk"
            };

            RockBand band2 = new RockBand()
            {
                BandName = "The Rolling Stones",
                YearFormed = 0,
                Members = "hjgh"
                
            };

            PopBand band3 = new PopBand()
            {
                BandName = "The Beatles",
                YearFormed = 0,
                Members = ""
            };

            PopBand band4 = new PopBand()
            {
                BandName = "Westlife",
                YearFormed = 0,
                Members = ""
            };

            IndieBand band5 = new IndieBand()
            {
                BandName = "Arctic Monkeys",
                YearFormed = 0,
                Members = ""
            };

            IndieBand band6 = new IndieBand()
            {
                BandName = "The Killers",
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

            cbxGenre.ItemsSource = new string[] { "Rock", "Pop", "Indie" };
            cbxGenre.SelectedIndex = 0;
        }

        private void LbxBands_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Band selectedBand = lbxBands.SelectedItem as Band;
            tblkBandInfo.Text = $"Formed : {selectedBand.YearFormed}\n" +
                $"Members : {selectedBand.Members}";
        }

        private void CbxGenre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedGenre = cbxGenre.SelectedItem as string;
            Band selectedBand = lbxBands.SelectedItem as Band;

            if(selectedGenre == selectedBand.BandGenre)
            {
                filteredBands.Add(selectedBand);
            }

            lbxBands.ItemsSource = filteredBands;

            
        }
    }
    }

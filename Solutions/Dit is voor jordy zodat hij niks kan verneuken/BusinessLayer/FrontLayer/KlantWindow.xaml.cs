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
using System.Windows.Shapes;
using BusinessLayer;

namespace Front_layer
{
    /// <summary>
    /// Interaction logic for KlantWindow.xaml
    /// </summary>
    public partial class KlantWindow : Window
    {
        private Bankrekeninghouder gebruiker;

        public KlantWindow(Bankrekeninghouder _gebruiker)
        {
            InitializeComponent();
            
            this.gebruiker = _gebruiker;
            tblNaam.Text = gebruiker.Rekeninghouder.Voornaam + " " + gebruiker.Rekeninghouder.Achternaam;
            tblBSN.Text = Convert.ToString(gebruiker.Rekeninghouder.BSN);
            tblSpaarNum.Text = gebruiker.Spaarrekening.SpaarRekeningnr();
            tblSpaarSal.Text = Convert.ToString( gebruiker.Spaarrekening.SpaarSaldo());
            tblBetaalNum.Text = gebruiker.Betaalrekening.BetaalRekeningnr();
            tblBetaalSal.Text = Convert.ToString(gebruiker.Betaalrekening.BetaalSaldo());

     

        }

        private void comboBox_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>();
            data.Add("Maak uw keuze");
            data.Add("Storten SpaarRekening");
            data.Add("Opnemen SpaarRekening");
            data.Add("Storten BetaalRekening");
            data.Add("Opnemen BetaalRekening");
            data.Add("Van Spaarrekening naar BetaalRekening");
            data.Add("Van BetaalRekening naar SpaarRekening");
            var combo = sender as ComboBox;
            combo.ItemsSource = data;
            combo.SelectedIndex = 0;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedcomboitem = sender as ComboBox;
            string name = selectedcomboitem.SelectedItem as string;
        }

        private void btnUitloggen_Click(object sender, RoutedEventArgs e)
        {
            
            LogInPage window = new LogInPage();
            window.Show();
            this.Close();
        }
    }
}

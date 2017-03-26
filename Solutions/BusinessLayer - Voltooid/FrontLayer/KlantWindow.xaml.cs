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
            data.Add("Van spaarrekening naar betaalrekening");
            data.Add("Van betaalrekening naar spaarrekening");
            data.Add("Storten naar andere rekening");
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

        private void btnUitvoere_Click(object sender, RoutedEventArgs e)
        {
            try {
                if (comboBox.Text == "Van spaarrekening naar betaalrekening")
                {
                    gebruiker.OverboekenNaarBetaalRekening(Convert.ToDecimal(tbHoeveelheid.Text));
                    tblSpaarSal.Text = Convert.ToString(gebruiker.Spaarrekening.SpaarSaldo());
                    tblBetaalSal.Text = Convert.ToString(gebruiker.Betaalrekening.BetaalSaldo());
                }
                else if (comboBox.Text == "Van betaalrekening naar spaarrekening")
                {
                    gebruiker.OverboekenNaarSpaarRekening(Convert.ToDecimal(tbHoeveelheid.Text));
                    tblSpaarSal.Text = Convert.ToString(gebruiker.Spaarrekening.SpaarSaldo());
                    tblBetaalSal.Text = Convert.ToString(gebruiker.Betaalrekening.BetaalSaldo());
                }
                else if (comboBox.Text == "Storten naar andere rekening" )
                {
                    gebruiker.BetalingVerrichten(tbRekeningSearch.Text, Convert.ToDecimal(tbHoeveelheid.Text));
                    tblSpaarSal.Text = Convert.ToString(gebruiker.Spaarrekening.SpaarSaldo());
                    tblBetaalSal.Text = Convert.ToString(gebruiker.Betaalrekening.BetaalSaldo());
                }

                MessageBox.Show("Transactie voltooid.");

                tbRekeningSearch.Text = "";
                tbHoeveelheid.Text = "";

                

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}

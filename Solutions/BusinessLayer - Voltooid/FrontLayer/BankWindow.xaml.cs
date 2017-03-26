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
    /// Interaction logic for BankWindow.xaml
    /// </summary>
    public partial class BankWindow : Window
    {
        private Bankier bankier;
        public BankWindow(Bankier _bankier)
        {
            InitializeComponent();
            this.bankier = _bankier;
        }

        private void btnUitloggen_Click(object sender, RoutedEventArgs e)
        {
            LogInPage window = new LogInPage();
            window.Show();
            this.Close();
        }

        private void btnRenteBij_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bankier.Rentebijschrijven();
                MessageBox.Show("Er is op elke spaarrekening rente bijgeschreven.");
                btnRenteBij.IsEnabled = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void btnOpheven_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bankier.BankRekeninghouderOpheffen(tbOpheven.Text);
                MessageBox.Show("De bankrekening is verwijderd uit de database.");
                tbOpheven.Text = "";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bankier.ToevoegenBankrekeninghouder(
                    tbAanVoornaam.Text,
                    tbAanAchternaam.Text,
                    tbAanBSN.Text,
                    tbAanGebruikersnaam.Text,
                    tbAanWachtwoord.Text,
                    tbAanRekNrSparen.Text,
                    Convert.ToDecimal(tbAanRekSpaarSaldo.Text),
                    Convert.ToDecimal(tbAanRentePer.Text),
                    tbAanRekNrBetalen.Text,
                    Convert.ToDecimal(tbAanRekBetaalSaldo.Text),
                    Convert.ToDecimal(tbAanMaxCrediet.Text)
                    );

                MessageBox.Show("Nieuwe bankrekeninghouder aangemaakt.");

                tbAanVoornaam.Text = "";
                tbAanAchternaam.Text = "";
                tbAanBSN.Text = "";
                tbAanGebruikersnaam.Text = "";
                tbAanWachtwoord.Text = "";
                tbAanRekNrSparen.Text = "";
                tbAanRekSpaarSaldo.Text = "";
                tbAanRentePer.Text = "";
                tbAanRekNrBetalen.Text = "";
                tbAanRekBetaalSaldo.Text = "";
                tbAanMaxCrediet.Text = "";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}

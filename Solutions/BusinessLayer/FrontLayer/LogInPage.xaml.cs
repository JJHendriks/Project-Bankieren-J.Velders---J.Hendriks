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
using BusinessLayer;

namespace Front_layer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LogInPage : Window
    {
        public LogInPage()
        {
            InitializeComponent();
            
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {

                string gebruikersnaam = "";
                string wachtwoord = "";

                if (tbGebruiker.Text != null)
                {
                     gebruikersnaam = tbGebruiker.Text;
                  
                }
                else
                {
                    throw new ArgumentException("U heeft uw gebruikersnaam niet ingevoerd.");
                }

                if (tbwachtwoord.Password != null)
                {
                     wachtwoord = tbwachtwoord.Password;
                }
                else
                {
                    throw new ArgumentException("U heeft uw wachtwoord niet ingevoerd");
                }

               Bankrekeninghouder gebruiker = DataProvider.InloggenGebruiker(gebruikersnaam, wachtwoord);

                KlantWindow window = new KlantWindow(gebruiker);
                window.Show();
                this.Close();



                

            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}

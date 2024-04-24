using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy Styczen2203.xaml
    /// </summary>
    public partial class Styczen2203 : Window
    {
        public Styczen2203()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();

            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double cena;
            if(pocztowka.IsChecked == true)
            {
                cena = 1;
            }
            else if(list.IsChecked == true)
            {
                cena = 1.5;
            }
            else if(paczka.IsChecked == true)
            {
                cena = 10;
            }
            else
            {
                cena= 0;
            }
            cena_txt.Text = "Cena: " + cena + "zł";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string kod_poczt = kod.Text;
            string adres = ulica.Text;
            string miastot = miasto.Text;
            if(kod_poczt.Length==6 && kod_poczt[2] == '-')
            {
                MessageBox.Show("Przesyłka zostanie dostarczona na adres " + miastot+" " + kod_poczt + " na adres " + adres);
            }
            else
            {
                MessageBox.Show("Kod pocztowy jest nieprawidłowy");
            }
        }
    }
}

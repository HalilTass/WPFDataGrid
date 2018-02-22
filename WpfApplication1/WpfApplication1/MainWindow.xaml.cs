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

namespace WpfSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        List<Customers> List;

        public MainWindow()
        {
            InitializeComponent();
            List = new List<Customers>()
            {
                new Customers() {Ad="Ahmet" , Soyad="Can" },
                 new Customers() {Ad="Halil" , Soyad="Taş" },
                  new Customers() {Ad="Atalay  " , Soyad="Toker" },
                   new Customers() {Ad="KobraNecdet" , Soyad="Dolu" },
            };
            Customers lst = new Customers();
            lst.Ad = "Halil";
            lst.Soyad = "Taş";
            List.Add(lst);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tb1.ItemsSource = List;
        }

        private void btntikla_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Butona Tıklandı.");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(cmbBoxListe.SelectedItem.ToString());

            MessageBox.Show(((ComboBoxItem)(cmbBoxListe.SelectedItem)).Content.ToString());
        }


        internal class Customers
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
        }
    }
}


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

namespace Tugas_Pribadi_KPL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public int Nama { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Text_nama_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Text_Hasil_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_process_Click(object sender, RoutedEventArgs e)
        {
            string nama = Text_nama.Text;
            string halo = "halo";
            string hasil = string.Concat(halo, nama);
            MessageBox.Show(hasil);
        }
    }
}

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

namespace clickertest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int amountcliks { get; set; } = 0; 
        public MainWindow()
        {
            InitializeComponent();
        }


        public int Klik(int i)
        {
            return amountcliks++; 

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Clicks.Text = Klik(0).ToString();

        }
    }
}

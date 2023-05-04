using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        private int amountClicks = 0; // Use private field instead of public property
        private const int MAX_CLICKS = 100000; // Use constant for maximum number of clicks

        public MainWindow()
        {
            InitializeComponent();
        }

        private int IncrementClicks()
        {
            return Interlocked.Increment(ref amountClicks); // Use Interlocked to ensure thread-safe incrementation
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if (amountClicks < MAX_CLICKS) // Check if maximum number of clicks has been reached
            {
                Clicks.Text = IncrementClicks().ToString();

                await Task.Run(() => {
                    // Simulate some processing that takes time
                    Thread.Sleep(50);
                });
            }
        }
    }
}

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

namespace Question1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] intArray;
        double[] doubleArray;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var rand = new Random();

            for (int i = intArray.Length; i < intArray.Length + 10; i++)
            {
                intArray[i] = rand.Next(0, 100);
            }
            for (int i = doubleArray.Length; i < doubleArray.Length + 10; i++)
            {
                doubleArray[i] = rand.NextDouble() * 10;
            }
            intGrid.ItemsSource = intArray;
            doubleGrid.ItemsSource = doubleArray;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (intArray.Length != 0)
                intArray[intArray.Length + 1] = Convert.ToInt32(intText.Text);
            else
                intArray[0] = Convert.ToInt32(intText.Text);
            intGrid.ItemsSource = intArray;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (doubleArray.Length != 0)
                doubleArray[intArray.Length + 1] = Convert.ToDouble(doubleText.Text);
            else
                doubleArray[0] = Convert.ToDouble(doubleText.Text);
            doubleGrid.ItemsSource = doubleArray;
        }
    }
}

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
    public partial class MainWindow : Window, IComparable<string>
    {
        int[] intArray;
        double[] doubleArray;
        public MainWindow()
        {
            InitializeComponent();
        }

        public int CompareTo(string searchText)
        {
            int iteration = 0;
            if (searchText.Contains('.'))
            {
                foreach(double a in doubleArray)
                {
                    if (a == Convert.ToDouble(searchText))
                        return iteration;
                    iteration++;
                }
            }
            else
                foreach(int a in intArray)
                {
                    if (a == Convert.ToInt32(searchText))
                        return iteration;
                    iteration++;
                }
            return -1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                intArray[i] = rand.Next(0, 100);
            }
            for (int i = 0; i < 10; i++)
            {
                doubleArray[i] = rand.NextDouble() * 10;
            }
            intGrid.ItemsSource = intArray;
            doubleGrid.ItemsSource = doubleArray;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           MessageBox.Show("The location of the searched number is " + CompareTo(searchText.Text));
        }
    }
}

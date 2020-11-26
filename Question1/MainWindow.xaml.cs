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
//using 

namespace Question1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random rand = new Random();
        static int[] intArray;
        static double[] doubleArray;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void generateIntBtn_Click(object sender, RoutedEventArgs e)
        {
            string numberOfElement = elementsIntInput.Text;
            try
            {
                int n = Convert.ToInt32(numberOfElement);
                intArray = GenerateIntArray(n);
                displayIntLabel.Text = ConvertArrayToString(intArray);
            }
            catch (Exception)
            {
                MessageBox.Show("[#405] Bad Input.! Please try again");
            }
            
        }

        private void generateDoubleBtn_Click(object sender, RoutedEventArgs e)
        {
            string numberOfElement = elementsDoubleInput.Text;
            try
            {
                int n = Convert.ToInt32(numberOfElement);
                doubleArray = GenerateDoubleArray(n);
                displayDoubleLabel.Text = ConvertArrayToString(doubleArray);
            }
            catch (Exception)
            {
                MessageBox.Show("[#405] Bad Input.! Please try again");
            }
        }

        private void searchIntBtn_Click(object sender, RoutedEventArgs e)
        {
            string numberOfElement = searchIntInput.Text;
            try
            {
                int searchElement = Convert.ToInt32(numberOfElement);
                MessageBox.Show(DisplayMessage(Search(intArray, searchElement))); 
            }
            catch (Exception)
            {
                MessageBox.Show("[#405] Bad Input.! Please try again");
            }
        }

        private void searchDoubleBtn_Click(object sender, RoutedEventArgs e)
        {
            string numberOfElement = searchDoubleInput.Text;
            try
            {
                double searchElement = Convert.ToDouble(numberOfElement); 
                MessageBox.Show(DisplayMessage(Search(doubleArray, searchElement)));
            }
            catch (Exception)
            {
                MessageBox.Show("[#405] Bad Input.! Please try again");
            }
        }

        static int[] GenerateIntArray(int numberOfInput)
        {
            int[] intArray = new int[numberOfInput];
            for (int i = 0; i < intArray.Length; i++) 
            {
                intArray[i] = rand.Next(1000);
            }
            return intArray;
        }
        static double[] GenerateDoubleArray(int numberOfInput)
        {
            double[] doubleArray = new double[numberOfInput];
            for (int i = 0; i < doubleArray.Length; i++)
            {
                doubleArray[i] = (double)rand.Next(1000) + Math.Round(rand.NextDouble(), 2);
            }
            return doubleArray;
        }

        static string ConvertArrayToString<T>(T[] array)
        {
            string value = "";
            foreach (var element in array)
            {
                value += element.ToString() + ", ";
            }
            return value;
        }

        static string DisplayMessage(int isFound)
        {
            if (isFound == -1)
            {
                return "[#404] Oops.! The element you are searching is not in the list";
            }
            else
            {
                return $"[#200] Element found, position {isFound} in the array";
            }
        }

        //// Not implement IComparable interface
        //static int Search<T>(T[] arrayToSearch, T searchKey)
        //{
        //    return Array.IndexOf(arrayToSearch, searchKey);
        //}

        // Implement using IComparable interface
        private static int Search<T>(T[] arrayToSearch, T searchKey) where T : IComparable<T>
        {
            foreach (var element in arrayToSearch)
            {
                if (element.CompareTo(searchKey) == 0)
                {
                    return Array.IndexOf(arrayToSearch, element);
                }
            }
            return -1;
        }
    }
}

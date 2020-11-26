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

namespace Assignment4_Prog3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rand = new Random();
        //string[] ascii = "! \" # $ % & ' ( ) * + , - . / 0 1 2 3 4 5 6 7 8 9 : ; < = > ? @ A B C D E F G H I J K L M N O P Q R S T U V W X Y Z [ \\ ] ^ _ ' a b c d e f g h i j k l m n o p q r s t u v w x y z ( | ) ~".Split(' ');
        string[] ascii = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z".Split(' ');

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string word = "";

            StringBuilder sentence = new StringBuilder();

            int number = int.Parse(NumberOfWords.Text);

            for (int i = 1; i <= number; i++)
            {
                for (int j = 0; j <= rand.Next(20); j++)
                {
                    word += ascii[rand.Next(ascii.Length)];
                }

                if (i != number)
                {
                    sentence.Append($"{word} ");
                }
                else
                {
                    sentence.Append($"{word}");
                }
            }

            Result.Text = "The number of words contained in \"" + sentence + "\" is " + sentence.WordCount();
        }
    }
}

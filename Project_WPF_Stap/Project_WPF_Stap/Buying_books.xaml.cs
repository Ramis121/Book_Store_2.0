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
using System.Windows.Shapes;

namespace Project_WPF_Stap
{
    /// <summary>
    /// Логика взаимодействия для Buying_books.xaml
    /// </summary>
    public partial class Buying_books : Window
    {
        private int price = 3000;
        private int number = 1;
        public Buying_books()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            Minus();
        }
        private bool Minus()
        {
            if (much.Text != null && pric.Text != null)
            {
                much.Text = (number -= 1).ToString();
                pric.Text = (price /= 2).ToString();
                return true;
            }
            else if(much.Text == null && pric.Text == null)
            {
                return false;
            }
            return true;
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            much.Text = (number += 1).ToString();
            pric.Text = (price *= 2).ToString();
        }

        private void buy_Click(object sender, RoutedEventArgs e)
        {
            SnackBar.MessageQueue.Enqueue($"Вы купили Book Cover за {pric.Text}"); 
        }

        private void minus_Click1(object sender, RoutedEventArgs e)
        {
            Minus_Second();
        }

        private bool Minus_Second()
        {
            if (muchh.Text != null && pricc.Text != null)
            {
                muchh.Text = (number -= 1).ToString();
                pricc.Text = (price /= 2).ToString();
                return true;
            }
            else if (muchh.Text == null && pricc.Text == null)
            {
                return false;
            }
            return true;
        }

        private void plus_Click1(object sender, RoutedEventArgs e)
        {
            muchh.Text = (number += 1).ToString(); 
            pricc.Text = (price *= 2).ToString(); 
        }

        private void minus_Click2(object sender, RoutedEventArgs e)
        {
            Minus_third();
        }

        private bool Minus_third()
        {
            if (muchhh.Text != null && priccc.Text != null) 
            {
                muchhh.Text = (number -= 1).ToString();
                priccc.Text = (price /= 2).ToString();
                return true;
            }
            else if (muchhh.Text == null && priccc.Text == null) 
            {
                return false;
            }
            return false;
        }

        private void plus_Click2(object sender, RoutedEventArgs e)
        {
            muchhh.Text = (number += 1).ToString();
            priccc.Text = (price *= 2).ToString();
        }

        private void buy_Click2(object sender, RoutedEventArgs e)
        {
            SnackBar.MessageQueue.Enqueue($"Вы купили Глазами Волка за {priccc.Text}");
        }

        private void buy_Click1(object sender, RoutedEventArgs e)
        {
            SnackBar.MessageQueue.Enqueue($"Вы купили Марсианин за {pricc.Text}");
        }

        private void TextBox_TextChanged1(object sender, TextChangedEventArgs e)
        {

        }

        private void pricc_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged2(object sender, TextChangedEventArgs e)
        {

        }

        private void priccc_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void pric_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.IO;

namespace Project_WPF_Stap
{
    /// <summary>
    /// Логика взаимодействия для Library.xaml
    /// </summary>
    public partial class Library : Window
    {
        ObservableCollection<string> baskets;
        public Library()
        {
            InitializeComponent();
            baskets = new ObservableCollection<string>();
            listBox.ItemsSource = baskets;
            DataContext = new ApplicationViewModel(); 
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text != null && textbox2.Text != null)
            {
                string bas = textbox1.Text;
                string bss = textbox2.Text;
                baskets.Add(bas);
                baskets.Add(bss);
            }
            else
                Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SnackBar.MessageQueue.Enqueue($"Вы купили книгу {textbox1.Text}\n {textbox2.Text}");  
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Reset(); 
        }
        public void Reset()
        {

        }
    }
}

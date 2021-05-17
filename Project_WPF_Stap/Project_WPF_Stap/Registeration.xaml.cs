using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
    /// Логика взаимодействия для Registeration.xaml
    /// </summary>
    public partial class Registeration : Window
    {
        private MainWindow Main { get; set; }
        public Registeration()
        {
            InitializeComponent();
        }

        private void logins_button_Click(object sender, RoutedEventArgs e)
        {
           if(Regist() && checkNames() && checkEmail())
           {
                var book_table = new User_Table
                {
                    fnm = full_name.Text,
                    u_unm = user_name.Text,
                    pwd = pass.Text,
                    u_qender = confirm_pass.Password,
                    u_email = email_add.Text,
                };
                book_table.ToString();
           }
        }

        private bool Regist()
        {
           if(pass.Text.Length > 5 && confirm_pass.Password.Length == pass.Text.Length) 
           {
                return true;
           }
            SnackBar.MessageQueue.Enqueue("Не правильный пароль");
            return false;
        }
        private bool checkNames()
        {
            if (!string.IsNullOrWhiteSpace(full_name.Text)) 
            {
                return true;
            }
            SnackBar.MessageQueue.Enqueue("Не правильное ФИО");
            return false;
        }
        private bool checkEmail()
        {
            try
            {
                var gmail = new MailAddress(email_add.Text);  
                return true;
            }
            catch (ArgumentException)
            {
                SnackBar.MessageQueue.Enqueue("Не правельный email");
                return false;
            }
        }


        private void login_Click(object sender, RoutedEventArgs e)
        {

        }

        private void search_button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void username_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void user_name_TextChanged(object sender, TextChangedEventArgs e)
        {
            using(StreamWriter fileStream = new StreamWriter("user_name.txt", false))
            {
                fileStream.WriteLine(user_name.Text);
            }
        }

        private void pass_TextChanged(object sender, TextChangedEventArgs e)
        {
            using (StreamWriter fileStream = new StreamWriter("user_password.txt", false))
            {
                fileStream.WriteLine(pass.Text);
            }
        }
    }
}

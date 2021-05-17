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
using System.IO;
using System.Net.Mail;
using System.Net;

namespace Project_WPF_Stap
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            if(Password() && User() && checkEmail())  
            {
                SnackBar.MessageQueue.Enqueue("Поздравляем вы зарегистрировались");
                Buying_books library = new Buying_books();
                library.Show();
            }
        }

        private void registr_Click(object sender, RoutedEventArgs e)
        {
            Registeration registeration = new Registeration();
            registeration.Show();
        }

        private void contact_Click(object sender, RoutedEventArgs e)
        {
            Contact kontact = new Contact();
            kontact.Show();
        }

        private void about_us_Click(object sender, RoutedEventArgs e)
        {
            Library library = new Library();
            library.Show();
        }

        private void view_cart_Click(object sender, RoutedEventArgs e)
        {
            Basket basket = new Basket();
            basket.Show();
        }

        private void username_TextChanged(object sender, TextChangedEventArgs e)
        {
            User();
        }
        private bool Password()
        {
            using (StreamReader sr = new StreamReader("loginP.txt", false))
            {
                if(password.Text != null)
                {
                    password.Text = sr.ReadToEnd();
                    return true;
                }
                SnackBar.MessageQueue.Enqueue("Не верный password");
                return false;
            }
        }
        private bool User()
        {
            using(StreamReader sr = new StreamReader("loginU.txt", false))
            {
                if (username.Text != null)
                {
                    username.Text = sr.ReadToEnd();
                    return true; 
                }
                SnackBar.MessageQueue.Enqueue("Не верный user");
                return false;
            }
        }
        private void password_TextChanged(object sender, TextChangedEventArgs e)
        {
            Password();
        }

        private bool Regist()
        {
            if (pass.Text.Length > 5 && confirm_pass.Password.Length == pass.Text.Length)
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
                var addr = new System.Net.Mail.MailAddress(email_add.Text);
                return addr.Address == email_add.Text;

                MailAddress from = new MailAddress(email_add.Text, "Ramis");
                MailAddress to = new MailAddress(email_add.Text);
                MailMessage m = new MailMessage(from, to);
                m.Subject = "Тест";
               
                
                return false;
                m.IsBodyHtml = true;
                // адрес smtp-сервера и порт, с которого будем отправлять письмо
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                // логин и пароль
                smtp.Credentials = new NetworkCredential("somemail@gmail.com", "mypassword");
                smtp.EnableSsl = true;
                smtp.Send(m);
                Console.Read();
            }
            catch
            {
                SnackBar.MessageQueue.Enqueue("Не правельный email");
                return false;
            }
           
        }

        private void user_name_TextChanged(object sender, TextChangedEventArgs e)
        {
            Open_Click();
        }

        private void pass_TextChanged(object sender, TextChangedEventArgs e)
        {
            Open_Click();
        }

        private void email_add_TextChanged(object sender, TextChangedEventArgs e)
        {
            checkEmail();
        }

        private void registration_Open_Click(object sender, RoutedEventArgs e)
        {
            Open_Click();
        }
        private bool Open_Click()
        {
                Regist();
                using (StreamWriter sw = new StreamWriter("loginP.txt", false))
                {
                    if (pass.Text != null)
                    {
                        sw.WriteLine(pass.Text);
                    }
                    
                }
                using (StreamWriter sw = new StreamWriter("loginU.txt", false))
                {
                    if (user_name.Text != null)
                    {
                        sw.WriteLine(user_name.Text);
                    }
                }
                return true;
        }
    }
}


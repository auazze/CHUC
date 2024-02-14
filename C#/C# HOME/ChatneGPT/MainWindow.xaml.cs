using System;
using System.Collections.Generic;
using System.IO;
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

//https://chat.openai.com/share/4699e90b-800c-4e50-9e44-e430354e4b2e
namespace ChatneGPT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loginTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = loginTextBox.Text;
            string password = passwordBox.Password;

            if (IsLoginValid(username, password))
            {
                MessageBox.Show("Успешный вход!");
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.");
            }
        }

        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            string username = loginTextBox.Text;
            string password = passwordBox.Password;

            if (RegisterUser(username, password))
            {
                MessageBox.Show("Регистрация успешна!");
            }
            else
            {
                MessageBox.Show("Этот пользователь уже существует.");
            }
        }

        private bool IsLoginValid(string username, string password)
        {
            string filePath = "ChatneGPT.txt";
            if (File.Exists(filePath))
            {
                foreach (var line in File.ReadAllLines(filePath))
                {
                    var parts = line.Split(';');
                    if (parts[0] == username && parts[1] == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool RegisterUser(string username, string password)
        {
            string filePath = "ChatneGPT.txt";
            if (!File.Exists(filePath) || !File.ReadAllLines(filePath).Any(line => line.StartsWith(username + ";")))
            {
                using (var sw = File.AppendText(filePath))
                {
                    sw.WriteLine($"{username};{password}");
                }
                return true;
            }
            return false;
        }

    }
}

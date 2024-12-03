using MySqlConnector;
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

namespace Sportivnie_Tovari
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

        private void LoginButtonClick(object sender, RoutedEventArgs e)
        {
          
        }
        private void TextBox1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            textBox1.Clear();
        }
        private void TextBox2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
          textBox2.Clear();
        }

        private void GuestButton(object sender, RoutedEventArgs e)
        {
           Window1 window = new Window1();
           window.Show();
           this.Close();
        }
        
        private void RegButton(object sender, RoutedEventArgs e) 
        {
            Registration registration = new Registration();
            registration.Show();
            this.Close();
        }
    }
}

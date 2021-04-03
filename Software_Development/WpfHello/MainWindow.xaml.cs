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

namespace WpfHello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button1.IsEnabled = false;
            Button2.IsEnabled = false; 
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var sw = new StreamWriter("username.txt");
                sw.WriteLine(TextBox.Text);
                sw.Close();
                Button2.IsEnabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var sr = new StreamReader("username.txt");
                Label.Content = "Приветствую Вас, уважаемый " + sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Button1.IsEnabled = true;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MyTextBox.Text = DateTime.Now.ToString();
        }
    }
}

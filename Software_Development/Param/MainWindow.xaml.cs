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

namespace Param
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = Properties.Settings.Default.ApplicationName;
            this.Background = new SolidColorBrush(Color.FromArgb(
                Properties.Settings.Default.BackgroundColor.A,
                Properties.Settings.Default.BackgroundColor.R,
                Properties.Settings.Default.BackgroundColor.G,
                Properties.Settings.Default.BackgroundColor.B
                ));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (!(listBox1.SelectedItem == null))
            {
                String astring = ((ListBoxItem)listBox1.SelectedItem).Content.ToString();
                switch (astring)
                {
                    case "Red":
                        Properties.Settings.Default.BackgroundColor = System.Drawing.Color.Red;
                        break;
                    case "Blue":
                        Properties.Settings.Default.BackgroundColor = System.Drawing.Color.Blue;
                        break;
                    case "Green":
                        Properties.Settings.Default.BackgroundColor = System.Drawing.Color.Green;
                        break;
                    case "Tomato":
                        Properties.Settings.Default.BackgroundColor = System.Drawing.Color.Tomato;
                        break;
                }
                this.Background = new System.Windows.Media.SolidColorBrush(Color.FromArgb(
                    Properties.Settings.Default.BackgroundColor.A,
                    Properties.Settings.Default.BackgroundColor.R,
                    Properties.Settings.Default.BackgroundColor.G,
                    Properties.Settings.Default.BackgroundColor.B
                ));
                Properties.Settings.Default.Save();
            }
        }
    }
}

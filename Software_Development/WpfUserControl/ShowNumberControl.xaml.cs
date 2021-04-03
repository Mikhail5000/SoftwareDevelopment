using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfUserControl
{
    /// <summary>
    /// Логика взаимодействия для ShowNumberControl.xaml
    /// </summary>
    public partial class ShowNumberControl : UserControl
    {

        private int currNumber = 0;
        public ShowNumberControl()
        {
            InitializeComponent();
        }

        // Регистрирует свойство встроенным способом, а не в статическом конструкторе
        public int CurrentNumber
        {
            get { return (int)GetValue(CurrentNumberProperty); }
            set { SetValue(CurrentNumberProperty, value); }
        }

        // Скелет свойства зависимости. Фрагмент кода регистрирует свойство встроенным способом, а не в статическом конструкторе.
        // Using a DependencyProperty as the backing store for CurrentNumber.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentNumberProperty =
            DependencyProperty.Register("CurrentNumber", typeof(int), typeof(ShowNumberControl), 
                new UIPropertyMetadata(100, new PropertyChangedCallback(CurrentNumberChanged)),
                new ValidateValueCallback(ValidateCurrentNumber)); // спеиальный делегат 

        // true, если входящее значение находится в заданном диапазоне, false — в противном случае
        public static bool ValidateCurrentNumber(object value)
        {
            if (Convert.ToInt32(value) >= 0 && Convert.ToInt32(value) <= 500)
                return true;
            else
                return false;
        }

        //метод меняет свойство content у label
        private static void CurrentNumberChanged(DependencyObject depObj,
            DependencyPropertyChangedEventArgs args)
        {
            ShowNumberControl s = (ShowNumberControl)depObj;
            Label theLabel = s.numberDisplay;
            theLabel.Content = args.NewValue.ToString();
        }

        /*public int CurrentNumber
        {
            get { return currNumber; }
            set
            {
                currNumber = value;
                // Передаем в метку текущее значение
                numberDisplay.Content = CurrentNumber.ToString();
            }
        }*/
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace NCommand
{
    class CustomCommands
    {
        static CustomCommands()
        {
            var myInputGestures = new InputGestureCollection();
            myInputGestures.Add(new KeyGesture(Key.L, ModifierKeys.Control));
            Launch = new RoutedUICommand("Запуск", "Launch", typeof(CustomCommands), myInputGestures);
        }

        public static RoutedUICommand Launch { get; }
    }
}

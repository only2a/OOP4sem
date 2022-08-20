using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _6_7_8.CustomControlElem
{
    public class Pasport : DependencyObject
    {
        public static readonly DependencyProperty NumberProperty;
        static Pasport()
        {
            FrameworkPropertyMetadata metadata =
            new FrameworkPropertyMetadata();
            NumberProperty = DependencyProperty.Register("Number",
            typeof(string),
            typeof(Pasport), metadata,
            new ValidateValueCallback(ValidateValue));
        }
        public string Number
        {
            get { return (string)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }
        private static bool ValidateValue(object value)
        {
            string currentValue = (string)value;
            if (currentValue.Contains("MP")) // если
                return true;
            return false;
        }
    }
}

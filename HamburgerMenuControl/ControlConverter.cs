using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;

namespace HamburgerMenuControl
{
    public class ControlConverter : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isChecked = (bool)value;
            var textblock = new TextBlock();
            textblock.Margin = new Thickness(5, 5, 5, 5);
            textblock.Foreground = new SolidColorBrush(Colors.White);
            textblock.FontSize = 16;
            textblock.FontFamily = new FontFamily(new Uri("pack://application:,,,/"), "./Resources/#fontawesome");

            if (isChecked)
            {
                textblock.Text = "\uf060";
            }
            else
            {
                textblock.Text = "\uf061";
            }
            return textblock;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}

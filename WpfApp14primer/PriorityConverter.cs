using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfApp14primer
{
    class PriorityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //if (((int) value)==1)
            //{
            //    return "Data/желтый.jpg";
            //}
            //return "Data/красный.jpg";

            switch((int)value)
            {
                case 1:
                    {
                        return "Data/хлеб.jpg";
                       
                    }
                case 2:
                    {
                        return "Data/фен.jpg";
                        
                    }
                case 3:
                    {
                        return "Data/пылесос.jpg";

                    }
                case 4:
                    {
                        return "Data/маслосливочное.jpg";

                    }
                default:
                    {
                        return "Data/красный.jpg";
                       
                    }
            }


        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}

using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace _33_SwipeView.Converter
{
    public class BoolToCompleteTextConverter : IValueConverter
    {
        public object Convert(object? value, Type targetType, object? paramter, CultureInfo culture) {
            if (value is bool isComplete) {
                return isComplete ? "Completed" : "Not Completed";
            }

            return "Not Completed";
        }


        public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
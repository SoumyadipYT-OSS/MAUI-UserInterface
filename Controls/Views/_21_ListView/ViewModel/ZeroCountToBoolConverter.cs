﻿using System;
using System.Globalization;
using Microsoft.Maui.Controls;


namespace _21_ListView.ViewModel
{
    public class ZeroCountToBoolConverter : IValueConverter
    {
        public object Convert(object? value, Type? targetType, object? parameter, CultureInfo culture) {
            if (value is int count) {
                return count == 0;
            }
            return false;
        }

        public object ConvertBack(object? value, Type? targetType, object? parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}

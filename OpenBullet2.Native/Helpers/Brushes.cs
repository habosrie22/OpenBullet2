﻿using System.Windows;
using System.Windows.Media;

namespace OpenBullet2.Native.Helpers
{
    public static class Brushes
    {
        public static Color GetColor(string propertyName)
        {
            try
            {
                return ((SolidColorBrush)Application.Current.Resources[propertyName]).Color; 
            }
            catch
            {
                return ((SolidColorBrush)Application.Current.Resources["ForegroundMain"]).Color;
            }
        }

        public static SolidColorBrush Get(string propertyName)
        {
            try
            {
                return (SolidColorBrush)Application.Current.Resources[propertyName];
            }
            catch
            {
                return (SolidColorBrush)Application.Current.Resources["ForegroundMain"];
            }
        }
    }
}

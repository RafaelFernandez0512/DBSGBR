using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace RemsyApp.Helpers
{
    public class BaseString64ToImageConverters : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            ImageSource retSource = null;
            if (value != null)
            {
                var image = $"{value}";
                try
                {
                    var stream = new MemoryStream(System.Convert.FromBase64String(image));
                    retSource = ImageSource.FromStream(() => stream);
                }
                catch (Exception)
                {

                    return retSource;
                }
              
           
            }
            return retSource;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

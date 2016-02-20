using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;



namespace ColourSwatcher
{
    public class Utility
    {
        public static Color hexToColor(String hex)
        {
            Color color = (Color)ColorConverter.ConvertFromString(hex);
            return color;
        }
        public static Color rgbToColor(String rgb)
        {
            rgb.Replace(" ", "");
            rgb.Split(",");
            return new Color(rgb[0], rgb[1], rgb2);
        }
        public static String colorToRGB(Color color)
        {
            return color.R + ", " + color.G + ", " + color.B;
        }
        public static String colorToHex(Color color)
        {
            return "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2"); 
        }
    }
}

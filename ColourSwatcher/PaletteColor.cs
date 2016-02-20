using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ColourSwatcher
{
    public class PaletteColor
    {
        private Color color;
        private bool favorite;

        private PaletteColor(Color color)
        {
            this.color = color;
        }

        public static PaletteColor parse(string parse)
        {
            try
            {
                if (parse.Contains(","))
                {
                    byte R = 0;
                    byte G = 0;
                    byte B = 0;

                    parse.Replace(" ", "");
                    string[] seg = parse.Split(',');
                    R = byte.Parse(seg[0]);
                    G = byte.Parse(seg[1]);
                    B = byte.Parse(seg[2]);
                    return new PaletteColor(Utility.rgbToColor(parse));
                }
                else
                {

                    string newCol = parse.Replace("#", "");

                    Color color = (Color)ColorConverter.ConvertFromString("#" + newCol);

                    return new PaletteColor(Utility.hexToColor(parse));
                }

            }
            catch
            {
                throw new Exception("Eorror");
            }

        }

        public void setFavorite(bool favorite)
        {
            this.favorite = favorite;
        }

        public bool isFavorite()
        {
            return favorite;
        }

        public Color getColor()
        {
            return color;
        }

    }
}

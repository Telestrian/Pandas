using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ColourSwatcher
{
    /// <summary>
    /// Interaction logic for ColourSlider.xaml
    /// </summary>
    public partial class ColourSlider : Window
    {
        private Slider R;
        private Slider G;
        private Slider B;

        private Category category;

        public ColourSlider(Category category)
        {
            InitializeComponent();
            this.category = category;
        }

        private void sldR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            sldR.Background = new SolidColorBrush(Color.FromArgb((byte)sldR.Value, (byte)sldR.Value, 0, 0));
            result.Fill = new SolidColorBrush(Color.FromRgb((byte)sldR.Value, (byte)sldG.Value, (byte)sldB.Value));
        }

        private void sldG_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            sldG.Background = new SolidColorBrush(Color.FromArgb((byte)sldG.Value, 0, (byte)sldG.Value, 0));
            result.Fill = new SolidColorBrush(Color.FromRgb((byte)sldR.Value, (byte)sldG.Value, (byte)sldB.Value));
        }

        private void sldB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            sldB.Background = new SolidColorBrush(Color.FromArgb((byte)sldB.Value, 0, 0, (byte)sldB.Value));
            result.Fill = new SolidColorBrush(Color.FromRgb((byte)sldR.Value, (byte)sldG.Value, (byte)sldB.Value));
        }

        private void Finish_Click(object sender, RoutedEventArgs e)
        {
            string parse = (int)sldR.Value + ", " + (int)sldG.Value + ", " + (int)sldB.Value;
            
            category.add(PaletteColor.parse(parse));
            this.Close();
        }
    }
}

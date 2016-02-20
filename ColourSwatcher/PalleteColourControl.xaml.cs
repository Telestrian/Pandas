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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ColourSwatcher
{
    /// <summary>
    /// Interaction logic for PalleteColourControl.xaml
    /// </summary>
    public partial class PalleteColourControl : UserControl
    {

        public static ColourPreview preview = new ColourPreview();

        private MainWindow owner;

        private PaletteColor col;

        public PalleteColourControl(PaletteColor col)
        {
            InitializeComponent();
            this.owner = MainWindow.Instance;
            this.col = col;
            recCol.Fill = new SolidColorBrush(col.getColor());

        }

        private void recCol_MouseEnter(object sender, MouseEventArgs e)
        {
            preview.Show();
            
            double xCor = Mouse.GetPosition(owner).X;
            double yCor = Mouse.GetPosition(owner).Y;
            Console.WriteLine(xCor);
            preview.Margin = new Thickness(xCor + 70, yCor + 70, 0, 0);
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }
    }
}

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
using System.Diagnostics;

namespace ColourSwatcher
{
    /// <summary>
    /// Interaction logic for PalleteColourControl.xaml
    /// </summary>
    public partial class PalleteColourControl : UserControl
    {

        private MainWindow owner;
        private ColourPreview preview;

        private PaletteColor col;

        public PalleteColourControl(PaletteColor col)
        {
            InitializeComponent();
            this.owner = MainWindow.Instance;
            this.col = col;
            recCol.Fill = new SolidColorBrush(col.getColor());
            preview = new ColourPreview(col.getColor());

        }

        private void recCol_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }

        private void UserControl_MouseEnter(object sender, MouseEventArgs e)
        {
            try
            {
                preview.Show();
            }
            catch { }
            
        }

        private void UserControl_MouseLeave(object sender, MouseEventArgs e)
        {
            try
            {
                preview.Close();
            }
            catch { }
        }
    }
}

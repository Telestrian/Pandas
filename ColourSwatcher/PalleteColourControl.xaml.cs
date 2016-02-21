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
using System.Windows.Forms;


namespace ColourSwatcher
{
    /// <summary>
    /// Interaction logic for PalleteColourControl.xaml
    /// </summary>
    public partial class PalleteColourControl : System.Windows.Controls.UserControl
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

        private void UserControl_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            try
            {

           
            }
            catch { }
            
        }

        private void UserControl_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            try
            {
               
            }
            catch { }
        }

        private void UserControl_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Clipboard.SetText(Utility.colorToRGB(col.getColor()));
        }

        private void UserControl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Clipboard.SetText(Utility.colorToHex(col.getColor()));
        }
    }
}

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
    /// Interaction logic for Category.xaml
    /// </summary>
    public partial class Category : UserControl
    {


        public static readonly int MAX = 39;

        MainWindow owner;

        private string category;

        public string _Category
        {
            get { return category; }
            set { category = value; }
        }


        public Category(string category)
        {
            InitializeComponent();
            this.category = category;
            this.owner = MainWindow.Instance;
            this.lblName.Content = category;
        }

        public void add(PaletteColor col)
        {
            if(stkColours.Children.Count >= 39)
            {
                MessageBox.Show("You cannot add anymore colours for this pallet", 
                    "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                stkColours.Children.Add(new PalleteColourControl(col));
            }
        }


    }
}

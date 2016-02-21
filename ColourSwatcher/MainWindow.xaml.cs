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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private static MainWindow instance;

        public static MainWindow Instance
        {
            get { return instance; }

        }

        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public MainWindow()
        {
            InitializeComponent();

            instance = this;
        }

        public void addColourToSwatch(Color col)
        {
            
        }

        private void cmdAddCategory_Click(object sender, RoutedEventArgs e)
        {
            //stkColourCategory.Children.Add(new Category(txtCategoryName.Text));
        }
    }
}

using Bikeshop.StartAssets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bikeshop
{
    /// <summary>
    /// Interaction logic for ProductsManagment.xaml
    /// </summary>
    public partial class ProductsManagment : Page
    {
        ProductsFactory factory = new ProductsFactory();
        public ProductsManagment()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            dataGrid.ItemsSource = factory.FindProducts(textBox.Text);
        }
    }
}

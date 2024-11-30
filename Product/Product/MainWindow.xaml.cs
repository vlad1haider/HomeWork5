using System.Collections.Generic;
using System.Windows;

namespace WpfProductApp
{
    public partial class MainWindow : Window
    {
        private List<Products> products = new List<Products>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text;
            if (double.TryParse(PriceTextBox.Text, out double price) &&
                int.TryParse(QuantityTextBox.Text, out int quantity))
            {
                Products product = new Products(name, price, quantity);
                products.Add(product);
                ProductListBox.Items.Add(product);
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Please enter valid price and quantity.");
            }
        }

        private void ProductListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            
        }

        private void ShowSelectedProduct_Click(object sender, RoutedEventArgs e)
        {
            if (ProductListBox.SelectedItem is Products selectedProduct)
            {
                selectedProduct.Deconstruct(out string name, out double price, out int quantity);
                MessageBox.Show($"Name: {name}\nPrice: ${price:F2}\nQuantity: {quantity}");
            }
            else
            {
                MessageBox.Show("Please select a product.");
            }
        }

        private void ClearInputFields()
        {
            NameTextBox.Clear();
            PriceTextBox.Clear();
            QuantityTextBox.Clear();
        }
    }
}
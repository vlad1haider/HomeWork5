namespace WpfProductApp
{
    public class Products
    {
        public string Name { get; }
        public double Price { get; }
        public int Quantity { get; }

        
        public Products(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        
        public Products(string name, double price) : this(name, price, 0) 
        {
        }

        
        public void Deconstruct(out string name, out double price, out int quantity)
        {
            name = Name;
            price = Price;
            quantity = Quantity;
        }

        public override string ToString()
        {
            return $"{Name} - ${Price:F2} (Quantity: {Quantity})";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineOrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some products
            Product product1 = new Product("Laptop", "P001", 1200.00m, 1);
            Product product2 = new Product("Mouse", "P002", 25.00m, 2);
            Product product3 = new Product("Keyboard", "P003", 75.00m, 1);
            Product product4 = new Product("Monitor", "P004", 300.00m, 1);
            Product product5 = new Product("USB Cable", "P005", 10.00m, 3);

            // Create some addresses
            Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
            Address address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");

            // Create some customers
            Customer customer1 = new Customer("John Doe", address1);
            Customer customer2 = new Customer("Jane Smith", address2);

            // Create some orders
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);
            order1.AddProduct(product3);

            Order order2 = new Order(customer2);
            order2.AddProduct(product4);
            order2.AddProduct(product5);

            // Display order details
            DisplayOrderDetails(order1);
            DisplayOrderDetails(order2);
        }

        static void DisplayOrderDetails(Order order)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine();

            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();

            Console.WriteLine("Total Price: $" + order.GetTotalPrice());
            Console.WriteLine("-------------------------");
        }
    }

    public class Product
    {
        private string _name;
        private string _productId;
        private decimal _price;
        private int _quantity;

        public Product(string name, string productId, decimal price, int quantity)
        {
            _name = name;
            _productId = productId;
            _price = price;
            _quantity = quantity;
        }

        public string Name => _name;
        public string ProductId => _productId;
        public decimal Price => _price;
        public int Quantity => _quantity;

        public decimal TotalCost => _price * _quantity;
    }

    public class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        public string Name => _name;
        public Address Address => _address;

        public bool IsInUSA()
        {
            return _address.IsInUSA();
        }
    }

    public class Address
    {
        private string _street;
        private string _city;
        private string _stateOrProvince;
        private string _country;

        public Address(string street, string city, string stateOrProvince, string country)
        {
            _street = street;
            _city = city;
            _stateOrProvince = stateOrProvince;
            _country = country;
        }

        public string Street => _street;
        public string City => _city;
        public string StateOrProvince => _stateOrProvince;
        public string Country => _country;

        public bool IsInUSA()
        {
            return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return $"{_street}\n{_city}, {_stateOrProvince}\n{_country}";
        }
    }

    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public decimal GetTotalPrice()
        {
            decimal total = 0;
            foreach (var product in _products)
            {
                total += product.TotalCost;
            }
            total += _customer.IsInUSA() ? 5.00m : 35.00m;
            return total;
        }

        public string GetPackingLabel()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var product in _products)
            {
                sb.AppendLine($"{product.Name} (ID: {product.ProductId})");
            }
            return sb.ToString();
        }

        public string GetShippingLabel()
        {
            return $"{_customer.Name}\n{_customer.Address}";
        }
    }
}


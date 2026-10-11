Product product1 = new Product("Keyboard", 49.99, 15);
Product product2 = new Product("Mouse", 29.99, 30);

Console.WriteLine($"{product1.Name} - Price: {product1.Price} - Stock: {product1.Stock}");
Console.WriteLine($"{product2.Name} - Price: {product2.Price} - Stock: {product2.Stock}");

class Product {
  public string Name;
  public double Price;
  public int Stock;

  public Product(string name, double price, int stock) {
    Name = name;
    Price = price;
    Stock = stock;
  }
}

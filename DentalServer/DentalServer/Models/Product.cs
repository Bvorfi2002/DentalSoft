public class Product
{
    public string Description { get; set; }
    public double Price { get; set; }
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Code { get; set; }
    public string Unit { get; set; }
    public Supplier supplier { get; set; }
    public int Quantity { get; set; } = 0;
    public int StockAlert { get; set; }

}

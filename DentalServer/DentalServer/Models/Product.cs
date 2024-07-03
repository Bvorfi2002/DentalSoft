using DentalServer.Models;

public class Product
{
    public string Description { get; set; }
    public double Price { get; set; }
    public Guid ProductId { get; set; }
    public Guid InventoryId { get; set; }
    public Inventory Inventory { get; set; }
    public string ProductName { get; set; }
    public string Code { get; set; }
    public string Unit { get; set; }
    public Supplier supplier { get; set; }
    public Guid SupplierId { get; set; }
    public int Quantity { get; set; } = 0;
    public int StockAlert { get; set; }


}

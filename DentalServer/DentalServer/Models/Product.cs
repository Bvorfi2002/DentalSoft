using System;

public class Product
{
	public string Description { get; set; }
	public double Price { get; set; }
	public int ProductId { get; set; }
	public string ProductName { get; set; }
	public string Code { get; set; }
	public string Unit {  get; set; }
	public Supplier supplier { get; set; }
	public int Quantity { get; set; }
	public int StockAlert {  get; set; }

	public Product() { 
		Quantity = 0;
	}

}

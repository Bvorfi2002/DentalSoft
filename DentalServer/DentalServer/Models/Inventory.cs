using System;

public class Inventory
{
	public IList<Product> products { get; set; }
	public Clinic clinic { get; set; }

	public Inventory()
	{
		products = new List<Product>();
	}
}

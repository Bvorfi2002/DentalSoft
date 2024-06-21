using System;

public class Invoice
{

	public string Type { get; set; }
	public string Description { get; set; }
	public double TotalAmount { get; set; }
	public DateTime date { get; set; }
	// TODO: Add user

	public Invoice()
	{
		date = DateTime.Now;
	}
}

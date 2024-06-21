using System;

public class BuyingBill
{

	public int BuyingBillId { get; set; }
	public Product product { get; set; }
	public Supplier supplier { get; set; }
	public double amount { get; set; }
	public DateTime date { get; set; }
	public double Tax { get; set; }
	public Clinic clinic { get; set; }

	public BuyingBill()
	{
		date = DateTime.Now;
		Tax = calculateTax(amount);
	}

	// TODO: Add logic
	private double calculateTax(double amount)
	{
		return 0;
	}
}

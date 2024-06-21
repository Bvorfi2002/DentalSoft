using System;

public class Bill
{
	public int BillId { get; set; }
	public Clinic clinic { get; set; }
	public DateTime date { get; set; }
	public string QrLink { get; set; }
	// TODO: Add patient
	public AppointmentResult appointment { get; set; }
	public double Tax { get; set; }
	public double Amount { get; set; }
	

	public Bill()
	{
		date = DateTime.Now;
		Amount = calculateAmount(appointment);
		Tax = calculateTax(Amount);
	}

	// TODO: Iterate services to calculate amount
	private double calculateAmount(AppointmentResult appointment)
	{
		return 0;
	}

	// TODO: Add logic of tax calculation
	private double calculateTax(double amount) { return 0; }
}

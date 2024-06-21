using System;

public class Clinic
{
	public string ClinicName { get; set; }
	public Inventory inventory { get; set; }
	public IList<Supplier> suppliers { get; set; }

	public Clinic()
	{
		inventory = new Inventory() { clinic = this };
		suppliers = new List<Supplier>();
	}
}

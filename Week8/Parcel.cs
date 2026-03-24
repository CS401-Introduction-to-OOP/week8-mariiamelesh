namespace Week8;
public class Parcel : DeliveryItem
{
	public string Dimensions { get ; private set ; }

	public Parcel ( string trackingNumber, double weight, string dimensions) : base ( trackingNumber, weight )
	{
	Dimensions = dimensions;
	}
	
	public override double CalculateCost ()
	{
		const int fee = 50;
		double cost = fee + (Weight * 25);
		return cost;
	}

	public override void PrintInfo ()
	{
	base . PrintInfo () ;
	Console.WriteLine ($"Dimensions : {Dimensions }") ;
	}
}
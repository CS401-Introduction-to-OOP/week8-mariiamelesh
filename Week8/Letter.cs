namespace Week8;

public class Letter : DeliveryItem
{
	public Letter ( string trackingNumber, double weight ) : base ( trackingNumber, weight )
	{

	}

	public override double CalculateCost ()
	{
		const int fee = 15;
		double cost = fee + (Weight * 10);
		return cost;
	}

}
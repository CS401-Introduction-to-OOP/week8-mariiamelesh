namespace Week8 {
	public class Program {
		static void Main(string[] args) {
			DeliveryItem letter1 = new Letter("TCA234", 1);
			DeliveryItem letter2 = new Letter("BBC546", 0.5);
			
			DeliveryItem parcel1 = new Parcel("SDJ495", 10, "30x15x20");
			DeliveryItem parcel2 = new Parcel("SND456", 15, "20x20x20");
			
			letter1.PrintInfo();
			parcel1.PrintInfo();
			
			CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem> (); 
			myCargo.AddItem(letter1);
			myCargo.AddItem(letter2); 
			myCargo.AddItem(parcel1); 
			myCargo.AddItem(parcel2);
			Console.WriteLine(myCargo.GetTotalCost());
		}
	}
}
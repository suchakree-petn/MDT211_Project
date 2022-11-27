public class Payment{
public void CalcPrice()
    {
        FlightData flightData = new FlightData();
        double x = flightData.GetPrice();
        //flightData.GetPrice() = price; //
        //this.CalcPrice = price * multiplier;
        Console.WriteLine(x);      
        Console.ReadLine();
    }
}
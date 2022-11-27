public class Payment
{
    public void CalcPrice(int ticketAmount, Reserve reserve)
    {
        FlightData reserveInfo = reserve.GetFlightData();
        Console.WriteLine("Ticket Amount: " + ticketAmount);
        Console.WriteLine("{0} to {1}", reserveInfo.GetOrigin(reserveInfo.GetFlightOrigin()), reserveInfo.GetDestination(reserveInfo.GetFlightDestination()));
        Console.WriteLine("Depart Date: {0}/{1}/{2}", reserveInfo.GetDepartDate()[0], reserveInfo.GetDepartDate()[1], reserveInfo.GetDepartDate()[2]);
        if (reserve.GetTripMultiplier() == 2)
        {
            Console.WriteLine("Return Date: {0}/{1}/{2}", reserveInfo.GetReturnDate()[0], reserveInfo.GetReturnDate()[1], reserveInfo.GetReturnDate()[2]);
        }
        double price = reserveInfo.GetPrice() * ticketAmount;
        Console.WriteLine("Result: " + price + " Bath");
    }
}
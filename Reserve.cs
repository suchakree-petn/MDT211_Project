public class Reserve
{
    private FlightData flightData = new FlightData();
    private int inputOptionTrip;

    public void SelectRoundOrOneway()
    {
        this.inputOptionTrip = int.Parse(Console.ReadLine());
    }

    public void SelectSeat(int[] input)
    {
        this.flightData.SetSeat(input);
    }
    public void SelectOrigin(int input)
    {
        this.flightData.SetOrigin(input);
    }
    public void SelectDestination(int input)
    {
        this.flightData.SetDestination(input);
    }
    public void SelectDepartDate(int[] input)
    {
        this.flightData.SetDepartDate(input);

    }
    public void SelectReturnDate(int[] input)
    {
        this.flightData.SetReturnDate(input);
    }
    public int GetTripMultiplier()
    {
        return this.inputOptionTrip;
    }
    public FlightData GetFlightData()
    {
        return this.flightData;
    }
}
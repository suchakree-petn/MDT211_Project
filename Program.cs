public class Program
{
    private static Login login = new Login();
    private static SignUp signup = new SignUp();
    private static Reserve reserve = new Reserve();
    private static Payment payment = new Payment();
    public static void Main(string[] args)
    {
        initialSeat();
        while (true)
        {
            ChooseLoginOrSignUp();
            ShowReserveUI();
        }
    }
    public static void ChooseLoginOrSignUp()
    {
        Console.Clear();
        Console.WriteLine("   *==Welcome==*");
        Console.WriteLine("");
        Console.WriteLine("   Please Select");
        Console.WriteLine("-+-------------------");
        Console.WriteLine("1| Login");
        Console.WriteLine("2| Signup");
        Console.WriteLine("-+-------------------");
        InputType();
    }
    public static void InputType()
    {
        Console.Write("Input Type: ");
        string Type = Console.ReadLine();
        Console.Clear();
        if (Type == "1")
        {
            bool checkLogin = login.RunLogin(signup);
            if (checkLogin == false)
            {
                BackToMenu();
            }
        }
        else if (Type == "2")
        {
            signup.RunSignUp();
            BackToMenu();
        }
        else
        {
            Console.WriteLine("Try Again!!");
            Console.ReadLine();
            ChooseLoginOrSignUp();
        }
    }
    static void BackToMenu()
    {
        Console.WriteLine("back to menu");
        ChooseLoginOrSignUp();
    }
    public static void ShowReserveUI()
    {
        Console.Clear();
        Console.WriteLine(" Select One-way trip or Round ");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("1 : One-way  2 : Round");
        Console.Write("Input: ");
        Program.reserve.SelectRoundOrOneway();
        FlightData flightData = Program.reserve.GetFlightData();
        Console.WriteLine("Avaiable Origin");
        Console.WriteLine("------------------");
        flightData.ShowOrigin();
        Console.Write("Input: ");
        Program.reserve.SelectOrigin(int.Parse(Console.ReadLine()));
        Console.WriteLine("");
        Console.WriteLine("Select Destination");
        Console.WriteLine("------------------");
        flightData.ShowDestination();
        Console.Write("Input: ");
        Program.reserve.SelectDestination(int.Parse(Console.ReadLine()));
        Console.WriteLine("");
        Console.Clear();
        Console.WriteLine("Select Depart Date");
        Console.WriteLine("------------------");
        int[] departDate = new int[3];
        Console.Write("Date: ");
        departDate[0] = int.Parse(Console.ReadLine());
        Console.Write("Month: ");
        departDate[1] = int.Parse(Console.ReadLine());
        Console.Write("Year: ");
        departDate[2] = int.Parse(Console.ReadLine());
        Program.reserve.SelectDepartDate(departDate);
        if (reserve.GetTripMultiplier() == 2)
        {
            Console.WriteLine(" Select Return Date");
            Console.WriteLine("--------------------");
            int[] returnDate = new int[3];
            Console.Write("Date: ");
            returnDate[0] = int.Parse(Console.ReadLine());
            Console.Write("Month: ");
            returnDate[1] = int.Parse(Console.ReadLine());
            Console.Write("Year: ");
            returnDate[2] = int.Parse(Console.ReadLine());
            Program.reserve.SelectReturnDate(returnDate);
        }
        Console.Write("\nTicket Amount: ");
        int ticketAmount = int.Parse(Console.ReadLine());
        int tmpTicketAmount = ticketAmount;
        while (tmpTicketAmount > 0)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("   Avaiable Seat");
            Console.WriteLine("--------------------");
            flightData.ShowSeat();
            Console.WriteLine("");
            Console.WriteLine("   Select Seat");
            Console.WriteLine("--------------------");
            int[] selectedSeat = { Console.Read() - 65, int.Parse(Console.ReadLine()) - 1 };
            Program.reserve.SelectSeat(selectedSeat);
            tmpTicketAmount--;
        }
        ShowPaymentUI(ticketAmount);
    }
    public static void ShowPaymentUI(int ticketAmount)
    {
        Console.Clear();
        Program.reserve.GetFlightData().ShowSeat();
        Console.WriteLine("");
        Console.WriteLine("    Payment List ");
        Console.WriteLine("--------------------");
        payment.CalcPrice(ticketAmount, Program.reserve);
        Console.WriteLine("");
        Console.WriteLine("Input any key to back to menu.");
        Console.ReadLine();
    }
    private static void initialSeat()
    {
        char[,] seat = Program.reserve.GetFlightData().GetSeat();
        for (int i = 0; i < seat.GetLength(0); i++)
        {
            for (int j = 0; j < seat.GetLength(1); j++)
            {
                seat[i, j] = '-';
            }
        }
    }
}
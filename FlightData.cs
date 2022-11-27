public class FlightData
{
    private string[] Origin = { "Chiang Rai", "Bangkok", "Chanthaburi", "Yala" };
    private string[] Destination = { "Chiang Rai", "Bangkok", "Chanthaburi", "Yala" };
    private int flightOrigin;
    private int flightDestination;
    private int[] Depart_date = { 0, 0, 0 };
    private int[] Return_date = { 0, 0, 0 };
    private double Price = 200;
    private char[,] Seat = new char[16, 4];

    public void ShowOrigin()
    {
        for (int i = 0; i < this.Origin.Length; i++)
        {
            Console.WriteLine(i + 1 + ") " + this.Origin[i]);
        }
    }
    public string GetOrigin(int input)
    {
        return this.Origin[input - 1];
    }
    public int GetFlightOrigin()
    {
        return this.flightOrigin;
    }
    public void SetOrigin(int input)
    {
        this.flightOrigin = input;
    }
    public void ShowDestination()
    {
        for (int i = 0; i < this.Destination.Length; i++)
        {
            Console.WriteLine(i + 1 + ") " + this.Destination[i]);
        }
    }
    public int GetFlightDestination()
    {
        return this.flightDestination;
    }
    public string GetDestination(int input)
    {
        return this.Destination[input - 1];
    }
    public void SetDestination(int input)
    {
        if (input == this.flightOrigin)
        {
            Console.WriteLine("Please select other destination.");
            SetDestination(int.Parse(Console.ReadLine()));
        }
        else
        {
            this.flightDestination = input;
            return;
        }
    }


    public void SetDepartDate(int[] input)
    {
        this.Depart_date = input;
    }
    public int[] GetDepartDate()
    {
        return this.Depart_date;
    }
    public void SetReturnDate(int[] input)
    {
        this.Return_date = input;
    }
    public int[] GetReturnDate()
    {
        return this.Return_date;
    }
    public void SetSeat(int[] input)
    {
        while (this.Seat[input[1], input[0]] == 'X')
        {
            Console.WriteLine("This seat already reserved. Please try again.");
            int[] newInput = { Console.Read() - 65, int.Parse(Console.ReadLine()) - 1 };
            input = newInput;
        }
        this.Seat[input[1], input[0]] = 'X';
    }

    public void ShowSeat()
    {
        Console.WriteLine("AB CD");
        for (int i = 0; i < Seat.GetLength(0); i++)
        {
            for (int j = 0; j < Seat.GetLength(1); j++)
            {
                Console.Write(Seat[i, j]);
                if ((j + 1) % 2 == 0)
                {
                    Console.Write(" ");
                }
                if ((j + 1) % 4 == 0)
                {
                    Console.Write(" " + (i + 1));
                    Console.WriteLine(" ");
                }
            }
            if ((i + 1) % 4 == 0)
            {
                Console.WriteLine(" ");
                Console.WriteLine("AB CD");
            }
        }
    }
    public double GetPrice()
    {
        return this.Price * Math.Abs(this.flightDestination - this.flightOrigin);
    }
    public char[,] GetSeat()
    {
        return this.Seat;
    }
}
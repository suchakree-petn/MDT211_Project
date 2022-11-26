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

    public void ShowOrigin(string input)
    {
        for (int i = 0; i < Origin.Length; i++)
        {
            Console.WriteLine(i + 1 + ") " + Origin[i]);
        }
    }
    public string GetOrigin(int input)
    {
        return this.Origin[input];
    }
    public void SetOrigin(int input)
    {
        this.flightOrigin = input;
    }



    public void ShowDestination(string input)
    {
        for (int i = 0; i < Destination.Length; i++)
        {
            Console.WriteLine(i + 1 + ") " + Destination[i]);
        }
        // int count = 1;
        // for (int i = 0; i < Destination.Length; i++)
        // {
        //     Console.WriteLine(i + 1 + ") ");
        //     if (input != Destination[i])
        //     {
        //         Console.WriteLine(count + ") " + Destination[i]);
        //         count++;
        //     }
        // }
    }

    public void SetDestination(int input)
    {
        if (input == flightOrigin)
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
    public void SetReturnDate(int[] input)
    {
        this.Return_date = input;
    }
    public void SetSeat(int[] input)
    {
        this.Seat[input[0], input[1]] = 'X';
    }

    public void ShowSeat()
    {
        for (int i = 0; i < Seat.GetLength(0); i++)
        {
            for (int j = 0; j < Seat.GetLength(1); j++)
            {
                Console.Write(Seat[i, j]);
                if (j == 1)
                {
                    Console.Write("  ");
                }
            }
            if (i % 4 == 0)
            {
                Console.WriteLine(" ");
            }
        }
    }
    public double GetPrice()
    {
        this.Price *= Math.Abs(this.flightDestination-this.flightOrigin);
        return this.Price;
    }
}
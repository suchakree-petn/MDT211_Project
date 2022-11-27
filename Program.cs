using System;
public class Program
{
    
     static Login login = new Login();
     static SignUp signup = new SignUp();
     static Reserve reserve = new Reserve();
     static Payment payment = new Payment();
    public static void Main(string[] args)
    { 

      ChooseLoginOrSignUp();
    }
    public static void ChooseLoginOrSignUp()
    {
        Console.Clear();
        Console.WriteLine("   *==Wellcome==*");
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
        Console.WriteLine("Input Type: ");
        for(int i = 0; i  <= 0;)
    {
        int Type = int.Parse(Console.ReadLine());
        if(Type == 1)
        {
          // Test
          ShowLoginUI();
        }
        else if (Type == 2)
        {
          // Test//
           ShowSignUpUI();
        }
        else
        {
        Console.WriteLine("Try Again!!");
        }
    }
    BackToMenu();
}
static void BackToMenu()
    {
        Console.Clear();
        ChooseLoginOrSignUp();
    }
    public static void ShowSignUpUI()
    {
        
        Console.Clear();
        Console.WriteLine(" ----SignUp----");
        Console.WriteLine("--------------------");
        Console.WriteLine(" Username: ");
        Console.WriteLine(" Password: ");
        Console.WriteLine("--------------------");
        signup.RunSignUp();
    }
     public static void ShowLoginUI()
    {
     
        Console.Clear();
        Console.WriteLine(" ----Login----");
        Console.WriteLine("--------------------");
        Console.WriteLine(" Username: ");
        Console.WriteLine(" Password: ");
        Console.WriteLine("--------------------");
        login.RunLogin(signup);
    }
    public static void ShowReserveUI()
    {
 
    Console.Clear();
    Console.WriteLine(" Payment List ");
    Console.WriteLine("--------------------");
    reserve.GetTripMultiplier();
    }
     public static void ShowPaymentUI()
    {
        
        Console.Clear();
        Console.WriteLine(" Payment List ");
        Console.WriteLine("--------------------");
        payment.CalcPrice();
        Console.ReadLine();
        Console.WriteLine("Input any key to back to menu.");
        BackToMenu();
       
    }


}
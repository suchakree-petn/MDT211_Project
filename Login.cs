class Login
{
    UserData userData = new UserData();

    private bool CheckUsername(string username, SignUp signup)
    {
        List<User> data = signup.GetUserData().GetDataUser();
        foreach (User user in data)
        {
            if (username == user.GetUsername())
            {
                return true;
            }
        }
        return false;
    }

    private bool CheckPassword(string password, SignUp signup)
    {
        List<User> data = signup.GetUserData().GetDataUser();
        foreach (User user in data)
        {
            if (password == user.GetPassword())
            {
                return true;
            }
        }
        return false;
    }

    public bool RunLogin(SignUp signupUserdata)
    {
        string username;
        string password;
        bool check = true;
        while (check)
        {
            Console.WriteLine("--------------Login--------------");
            Console.Write("Username: ");
            username = Console.ReadLine();
            if (username != "exit")
            {
                if (CheckUsername(username, signupUserdata))
                {
                    Console.Write("Password: ");
                    password = Console.ReadLine();
                    if (CheckPassword(password, signupUserdata))
                    {
                        Console.Clear();
                        Console.WriteLine("----------Login Success!---------");
                        Console.WriteLine("Please enter someting to continue");
                        Console.ReadLine();
                        Console.Clear();

                        check = false;
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Password isn't correct. Please try again.");
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("Please enter someting to continue");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("User isn't already registered. Please try again.");
                    Console.WriteLine("Enter \"exit\" to back to menu.");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Please enter someting to continue");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else
            {
                Console.Clear();
                check = false;
                return false;
            }
        }
        return false;
    }
}
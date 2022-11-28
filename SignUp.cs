class SignUp
{
    UserData userData = new UserData();
    public string SignUpUsername()
    {
        Console.Write("Username: ");
        return Console.ReadLine();
    }
    public string SignUpPassword()
    {
        Console.Write("Password: ");
        return Console.ReadLine();
    }
    public void RunSignUp()
    {
        Console.WriteLine("-------------Sign Up-------------");
        string username = SignUpUsername();
        if (username != "exit")
        {
            string password = SignUpPassword();
            User user = new User(username, password);
            userData.AddNewUser(user);
            Console.Clear();
            Console.WriteLine("---------Sign Up Success!--------");
            Console.WriteLine("Please enter someting to continue");
            Console.ReadLine();
            Console.Clear();
        }
        else
        {
            Console.Clear();
        }

    }
    public UserData GetUserData()
    {
        return this.userData;
    }
}
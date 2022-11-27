class Login
{
    UserData userData = new UserData();
    
    private bool CheckUsername(string username,SignUp signup)
    {
        List<User> data = signup.GetUserData().GetDataUser();
        foreach (User user in data){
            if (username == user.GetUsername())
            {
                return true;
            }
        }
        return false;
    }
    private bool CheckPassword(string password,SignUp signup)
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
    
    public void RunLogin(SignUp signup){
        string username;
        string password;
        bool check = true;
        while(check){
            Console.WriteLine("--------------Login--------------");
            Console.Write("Username: ");
            username = Console.ReadLine();
            if(CheckUsername(username,signup)){
                Console.Write("Password: ");
                password = Console.ReadLine();
                if(CheckPassword(password,signup)){
                    Console.Clear();
                    Console.WriteLine("----------Login Success!---------");
                    Console.WriteLine("Please enter someting to continue");
                    Console.ReadLine();
                    Console.Clear();

                    check = false;
                }else{
                    Console.WriteLine("Password isn't correct. Please try again.");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Please enter someting to continue");
                    Console.ReadLine();
                    Console.Clear();
                }
            }else{
                Console.WriteLine("User isn't already registered. Please try again.");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Please enter someting to continue");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
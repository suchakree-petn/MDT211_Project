class SignUp{
    UserData userData = new UserData();
    public string SignUpUsername(){
        Console.Write("Username: ");
        string username = Console.ReadLine();
        return username;
    }
    public  string SignUpPassword(){
        Console.Write("Password: ");
        string password = Console.ReadLine();
        return password;
    }
    public void RunSignUp(){
        Console.WriteLine("-------------Sign Up-------------");
        string signUpUsername = SignUpUsername();
        string signUpPassword = SignUpPassword();
        User user = new User(signUpUsername, signUpPassword);
        userData.AddNewUser(user);
        Console.Clear();
        Console.WriteLine("---------Sign Up Success!--------");
        Console.WriteLine("Please enter someting to continue");
        Console.ReadLine();
        Console.Clear();
    }
    public UserData GetUserData(){
        return this.userData;
    }
}
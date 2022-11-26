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
        Console.WriteLine("Sign Up");
        Console.WriteLine("---------");
        string signUpUsername = SignUpUsername();
        string signUpPassword = SignUpPassword();
        User user = new User(signUpUsername, signUpPassword);
        userData.AddNewUser(user);
        Console.Clear();
    }
    public UserData GetUserData(){
        return this.userData;
    }
}
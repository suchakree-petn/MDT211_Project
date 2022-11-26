//ตัวอย่างตอนรันโปรแกรม
class Program{
    static SignUp signup = new SignUp();
    static Login login = new Login();
    static void Main(string[] args)
    {
        Program.signup.RunSignUp();
        Program.login.RunLogin(signup);
    }
}
using System.Collections.Generic;
class UserData
{
    private List<User> userData = new List<User>();
    public void AddNewUser(User user)
    {
        this.userData.Add(user);
    }
    public List<User> GetDataUser()
    {
        return this.userData;
    }
}
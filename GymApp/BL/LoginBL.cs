namespace GymApp.BL;

public class LoginBL
{
    internal bool Login(string userName, string password)
    {
        if(userName == "manager" && password == "123")
        {
            return true;
        }
        else
        {
            return true;
        }
    }
}
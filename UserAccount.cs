public class UserAccounts : Account
{

    public int Age {get;  set;}
    public void GetAge(int a)
    {
        Age = a;
    }
    public override void AccAbs()
    {
        System.Console.WriteLine("This is User Account");
    }
}
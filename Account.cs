public abstract class Account
{
    public abstract void AccAbs();

    public string Name {get;  set;}
    public string LastName{get; set;}

    public void GetInfo(string n, string l)
    {
        Name = n;
        LastName = l;
    }
}
public class BusinessAccount : Account
{
    public string PhoneNumber{get; set;}
    public string CompanyName{get; set;}

    public void GetBusiness(string ph, string c)
    {
        PhoneNumber = ph;
        CompanyName = c;
    }
        public override void AccAbs()
    {
        System.Console.WriteLine("This is Business Account");
    }

}
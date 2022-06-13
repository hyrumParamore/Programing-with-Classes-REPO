namespace BYUI.InheritanceExamples;

class Dealer : Customer
{
    public long DealerId { get; set; }
    public double Discount { get; set; }

    public Dealer(string name, long dealerId, double discount) : base (name)
    {
        DealerId = dealerId;
        Discount = discount;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        // Console.WriteLine("");
        Console.WriteLine($"My Dealer ID is {DealerId} and my discount is {Discount}");
    }

}
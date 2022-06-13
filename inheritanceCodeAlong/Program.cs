using BYUI.InheritanceExamples;

Console.WriteLine();
Customer John = new Customer("John Smith");
John.Purchase(50.00);
John.GetInfo();
Console.WriteLine(John.Name);
Console.WriteLine();

Dealer Ace = new Dealer("Ace Hardware", 12345678, 0.05);
Ace.Purchase(50.00);
Ace.GetInfo();
Console.WriteLine(Ace.Name);
Console.WriteLine(Ace.DealerId);
Console.WriteLine(Ace.Discount);
Console.WriteLine();
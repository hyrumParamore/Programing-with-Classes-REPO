
public class Deck {

    public int firstCard;
    public int secondCard;
    public int secondcardd;

    public Deck(){
        
        firstCard = 0;
        secondCard = 0;
        
    }

    public int FirstCard() 
    {
        Random random = new Random();
        firstCard = random.Next(1, 13);
        return firstCard;
    }


    public int SecondCard() {
        Random random = new Random();
        secondCard = random.Next(1, 13);
        return secondCard;
    }

    public void ShowCard(){
        Console.WriteLine($"First Card: {FirstCard()}");
        Console.WriteLine($"Second Card: {SecondCard()}");
    }

}
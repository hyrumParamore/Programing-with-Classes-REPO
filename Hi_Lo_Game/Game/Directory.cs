
public class Director {

    public int points;
    public string guess;
    public bool keepPlaying;


    public Director() {
        points = 0;
        guess = "";
        keepPlaying = true;
    }


    public void StartGame() {
        
        points = 300;
        
        while (points > 0 && keepPlaying == true)
        {
            
            UpdatePoints();
            DonePlaying();
            
            Console.WriteLine(""); 
        }

        Console.WriteLine("Thanks for playing!");
        Console.WriteLine("");
    }


    public int DrawFirstCard(){
        Deck d = new Deck();
        int card1 = d.FirstCard();
        return card1;
    }


    public int DrawSecondCard(){
        Deck d = new Deck();
        int card2 = d.SecondCard();
        return card2;
    }


    public string UserGuess(){
        Console.Write("Higher or lower? (h/l) ");
        guess = Console.ReadLine();

        return guess;
    }


    public bool DonePlaying(){
        Console.Write($"Keep playing? (y/n) ");
        string user_input = Console.ReadLine();

        if (user_input == "y") 
        {
            keepPlaying = true;
        }
        else if(user_input == "n") 
        {
            keepPlaying = false;
        }
        
        return keepPlaying;
    }


    public int UpdatePoints() {

        Deck d = new Deck();
        int card1 = d.FirstCard();
        int card2 = d.SecondCard();
        
        Console.WriteLine("");
        Console.WriteLine($"The card is: {card1}");
        
        UserGuess();

        if (card2 > card1 && guess == "h")
        {
            Console.WriteLine("Correct!");
            points = points + 100;
        }
        else if (card2 < card1 && guess == "l")
        {
            Console.WriteLine("Correct!");
            points = points + 100;
        }
        else if (card1 == card2 && (guess == "h" || guess == "l")) 
        {
            Console.WriteLine("The numbers are the same");
        }
        else 
        {
            Console.WriteLine("Wrong...");
            points = points - 75;
        }

        Console.WriteLine($"Next card was: {card2}");
        Console.WriteLine($"Your score is: {points}");

        return points;

    }

}



public class Enemies : Actor
{

    public int health = 100;
    public string text = "";

    public int x = 0;
    public int y = 0;

    // private Color color = new Color(255, 255, 255); // white

    // public Point point = new Point(x, y);



    // Constructor
    public Enemies()
    {

        // This is taking the method from the actor class and using it here.
        SetText("X");
        
    }


    public string DisplayWords() 
    {
        text = "This is an enemy";
        return text;
    }

    // public int TakeDamage()
    // {
    //     this.health = this.health - 20;
    //     return health;
    // }

    // public Point EnemyPosition(int x, int y)
    // {
    //     return position;
    // }

   


}
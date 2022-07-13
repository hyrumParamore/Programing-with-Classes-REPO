

public class Turret : Actor
{

    public int damage = 100;

    public string text = "";

    public int x = 0;
    public int y = 0;

    private int range = 50;


    // public Point point = new Point(x, y);



    // Constructor
    public Turret()
    {
        // this.text = text;

        

        // This is taking the method from the actor class and using it here.
        SetText("#");
        
        
    }

    public string DisplayWords() 
    {
        text = "This is a turret";
        return text;
    }

    // public void DealDamage()
    // {

    // }

    // public int TurretRange()
    // {
    //     return range;
    // }
    
    




}
using System;


public class Actor
{

    private string text = "";
    private int fontSize = 30;
    public int health = 100;
    private int damage = 10;

    private Point position = new Point(0, 0);

    private Color color = new Color(0, 0, 0); // black

    private Point velocity = new Point(0, 0);


    public int range = 50;

    // Velocity maybe...?

    // public Actor(int damage) 
    // {
    //     this.damage = damage;
    // }



    // Gets the actor's current velocity.
    public Point GetVelocity()
    {
        return velocity;
    }


    // Gets the actor's position.
    public Point GetPosition() 
    {
        return position;
    }

    // Gets the actor's text.
    public string GetText()
    {
        return text;
    }
    public int GetDamage()
    {
        return damage;
    }


    // Sets the actor's position to the given value.
    public void SetPosition(Point position)
    {
        if (position == null)
        {
            throw new ArgumentException("position can't be null");
        }
        this.position = position;
    }


    // Sets the actor's text to the given value.
    public void SetText(string text)
    {
        if (text == null)
        {
            throw new ArgumentException("text can't be null");
        }
        this.text = text;
    }

    // Gets the actor's font size.
    public int GetFontSize()
    {
        return fontSize;
    }


    // Sets the actor's font size to the given value.
    // When font size is less than or equal to zero.
    public void SetFontSize(int fontSize)
    {
        if (fontSize <= 0)
        {
            throw new ArgumentException("fontSize must be greater than zero");
        }
        this.fontSize = fontSize;
    }


    public Color GetColor()
    {
        return color;
    }


    // Sets the actor's color to the given value.
    public void SetColor(Color color)
    {
        if (color == null)
        {
            throw new ArgumentException("color can't be null");
        }
        this.color = color;
    }

    public void SetVelocity(Point velocity)
    {
        if (velocity == null)
        {
            throw new ArgumentException("velocity can't be null");
        }
        this.velocity = velocity;
    }

    public void MoveNext(int maxX, int maxY)
    {
        int x = ((position.GetX() + velocity.GetX()) + maxX) % maxX;
        int y = ((position.GetY() + velocity.GetY()) + maxY) % maxY;
        position = new Point(x, y);
    }






    // Returns the range of the turret.
    public int TurretRange()
    {
        return range;
    }


    public int Health()
    {
        return health;
    }


    public int TakeDamage()
    {
        this.health = this.health - damage;
        return health;
    }

    public int DealDamage(int damage)
    {
        return damage;
    }


}
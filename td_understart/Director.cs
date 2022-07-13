using Raylib_cs;
using System;
using System.Collections.Generic;

public class Director 
{

    public int x = 300;
    public int y = 400;

    public string text = "";

    public float radius = 50; 

    Display display = new Display();
    Turret turret = new Turret();
    Cast cast = new Cast();
    Actor actor = new Actor();


    // Point point = new Point(x, y);

    // public Director(int x, int y)
    // {
    //     this.x = x;
    //     this.y = y;
    // }





    public void StartGame(Cast cast)
        {
            display.OpenWindow();

            while (display.IsWindowOpen())
            {

                GetInputs(cast);
                DoUpdates(cast);


                DoOutputs(cast);
            }

            display.CloseWindow();
        }


    public void DoOutputs(Cast cast)
    {
        List<Actor> actors = cast.GetAllActors();
        display.BeginDrawing();
        display.DrawActors(actors);
        display.EndDrawing();
    }




    private void GetInputs(Cast cast) 
    {
        List<Actor> enemies = cast.GetActors("enemy");
        foreach (Actor actor in enemies)
        {
            Point enemyvelocity = display.MoveActors();
            actor.SetVelocity(enemyvelocity);
            int maxX = display.GetWidth();
            int maxY = display.GetHeight();
            actor.MoveNext(maxX, maxY);
            
        }

        if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_BUTTON_LEFT))
        {
            display.MouseX(x);
            display.MouseY(y);

            // This is saving the position when the mouse is clicked and saving it into the x and y variables.
            this.x = display.MouseX(x);
            this.y = display.MouseY(y);
            
            
    
        }
        
        




        Collisions collision = new Collisions();
        // collision.HandleCollisions();

        // Actor enemy = cast.GetFirstActor("enemy");
        // Actor turret = cast.GetFirstActor("turret");
        // Point position1 = enemy.GetPosition();

        // Point position2 = turret.GetPosition();


        // if (position1 >= position2)
        // {
            
        // }
        


        
    }

    private void DoUpdates(Cast cast)
    {
        display.ClearBackground();

        Actor turret = cast.GetFirstActor("turret");
        Actor enemy = cast.GetFirstActor("enemy");
        Actor enemy2 = cast.GetFirstActor("enemy2");

        


        // This is taking the saved x and y variables and placing it into the turret and updating it's position.
        Point position = new Point(x, y);
        turret.SetPosition(position);


        // Turrets circle
        display.DrawCircle(x, y, radius);

        // Stationary enemy
        Point enemyposition2 = enemy2.GetPosition();
        int enemyX2 = enemyposition2.GetX();
        int enemyY2 = enemyposition2.GetY();

        // display.DrawCircle(enemyX2, enemyY2, radius);

        // Moving enemy
        Point enemyposition = enemy.GetPosition();
        int enemyX = enemyposition.GetX();
        int enemyY = enemyposition.GetY();
        Point enemyxy1 = new Point(enemyX, enemyY);

        // display.DrawCircle(enemyX2, enemyY2, radius);


        double area = (3.14 * radius * radius);
        double area2 = (3.14 * radius * radius);

        int x1 = x + 50;
        int y1 = y + 50;
        // Point xy1 = new Point(x1, y1);

        int x2 = x + 50;
        int y2 = y - 50;
        // Point xy2 = new Point(x2, y2);

        int x3 = x - 50;
        int y3 = y + 50;
        // Point xy3 = new Point(x3, y3);

        int x4 = x - 50;
        int y4 = y - 50;
        // Point xy4 = new Point(x4, y4);


        // Display if the enemy got hit.
        if (enemyX2 <= x1 && enemyY2 <= y1 && enemyX2 <= x2 && enemyY2 >= y2 && enemyX2 >= x3 && enemyY2 <= y3 && enemyX2 >= x4 && enemyY2 >= y4)
        {
            // display.DrawText("This is working", 25, 50);
            enemy2.TakeDamage();
            
            int health = enemy2.Health();
            string healthString = enemy2.Health().ToString();
            // health = health.ToString();
            display.DrawText("Enemy Health: " + healthString, 60, 20);

            if (health == 0)
            {
                cast.RemoveActor("enemy2", enemy2);
            }

        }
        
        

        
        

        // If enemy is in range of turret, enemy take damage.
        // if ( enemy.GetPosition() < turret.GetPosition(Point ));

        

        
    }

    


}
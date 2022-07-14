using System;
using System.Collections.Generic;
using Raylib_cs;

public class Program
{

    private static Color GREEN = new Color(128, 255, 0);
    private static Color RED = new Color(255, 0, 0);
    
    private static Color BLUE = new Color(0, 0, 204);


    static void Main()
    {

        

        Cast cast = new Cast();
        
        Actor turret = new Turret();
        turret.SetText("#");
        turret.SetFontSize(30);
        turret.SetColor(BLUE);
        turret.DealDamage(10);
        turret.TurretRange();
        
        
        // turret.SetPosition(new Point(500, 300));
        cast.AddActor("turret", turret);


        Actor enemy = new Actor();
        enemy.SetText("X");
        enemy.SetFontSize(15);
        enemy.SetColor(RED);
        enemy.SetPosition(new Point(500, 300));
        cast.AddActor("enemy", enemy);

        Actor enemy2 = new Actor();
        enemy2.SetText("X");
        enemy2.SetFontSize(15);
        enemy2.SetColor(RED);
        enemy2.SetPosition(new Point(300, 200));
        cast.AddActor("enemy2", enemy2);





        Director director = new Director();
        director.StartGame(cast);
    }


}
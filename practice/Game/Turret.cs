using System;
using System.Collections.Generic;
using Raylib_cs;


public class Turret : Actor 
{

    int damage = 0;
    string turret = "#";
    int x = 0;
    int y = 0;
    
    // public Point position = new Point(300, 400);

    
    private List<Actor> turrets = new List<Actor>();

    private VideoService videoService = null;
    


    public Turret(Point position) 
    {
        // PrepareTurret(pointStart);
        SetText("#");  //This is being taken from the actor class because the Actor class is the parent class.
        // placeTurret();
        // showPlacement();
        

    }

    // public void placeTurret() 
    // {
    //     if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT))
    //     {


    //         videoService.MouseX(x);
    //         videoService.MouseY(y);

    //         this.x = videoService.MouseX(x);
    //         this.y = videoService.MouseY(y);
            
            
    //         string mouseposition = $"This is the set position" + x + " " + y;

    //         videoService.DrawText(mouseposition, x, y);
    //     }
        
    // }

    



    

    // private void placeTurret() 
    // {
    //     if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT))
    //     {
    //         // videoService.MouseX(x);
    //         // videoService.MouseY(y);

    //         this.x = videoService.MouseX(x);
    //         this.y = videoService.MouseY(y);
            
    //         string mouseposition = $"This is the set position" + x + " " + y;

    //         // videoService.DrawText(mouseposition, x, y);
            

    //         // Point position = new Point(x, y);
    //         // Turret turret = new Turret(position);
            

    //     }


    // }

    







    // Position is equal to the mouse position when mouse is clicked.

    // public void PlaceTurret() 
    // {

        

    //     this.x = videoService.MouseX(x);
    //     this.y = videoService.MouseY(y);

    //     string turretplaced = $"This is the turret position" + x + " " + y;
    //     videoService.DrawText(turretplaced, 100, 450);
        
    //     // Actor actorTurret = new Actor();
    //     // Point position = new Point(400, 300);

    //     // // videoService.MouseX(x);
    //     // // videoService.MouseY(y);

    //     // actorTurret.SetPosition(position);


    //     // // VideoService videoService = new VideoService();
    //     // videoService.DrawText("Turret", 400, 300);





    //     // // string text = 1 == 0 ? "8" : "#";
    //     // // actorTurret.SetText(text);
    // }

    // public void PrepareTurret(Point pointStart)
    // {
    //     int x = pointStart.GetX();
    //     int y = pointStart.GetY();

    //     string text = "#";

    //     Actor turret = new Actor();
    //     turret.SetText(text);



    // }

    // public void DrawTurret() 
    // {
    //     Point point = new Point(400, 300);
    //     PrepareTurret(point);
    // }
    
    

}
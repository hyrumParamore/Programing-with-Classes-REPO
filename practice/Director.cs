using System;
using System.Collections.Generic;
using Raylib_cs;


public class Director 
{

    int health = 100;

    int x = 0;
    int y = 0;

    private VideoService videoService = null;
    private Turret turret = null;

    // private Point pointStart = null;


    public Director(VideoService videoService)
        {
            this.videoService = videoService;
            // this.turret = turret;
            // this.pointStart = pointStart;
            // this.y = y;
            // this.x = x;
        }

    // Starts the game
    public void StartGame(Cast cast, Script script)
    {
        videoService.OpenWindow();

        // Updates go in here. This is the game.
        while (videoService.IsWindowOpen())
        {
            GetInputs();
            
            GetUpdates();
            
            ExecuteActions("output", cast, script);
            // if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT))
            // {
                
            // }
            // DoOutputs();

        }


        videoService.CloseWindow();
    }

    private void ExecuteActions(string group, Cast cast, Script script)
        {
            List<Action> actions = script.GetActions(group);
            foreach(Action action in actions)
            {
                action.Execute(cast, script);
            }
        }


    // Get input from mouse and applies it in a way.
    private void GetInputs() 
    {
        if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_BUTTON_LEFT))
        {
            videoService.MouseX(x);
            videoService.MouseY(y);

            this.x = videoService.MouseX(x);
            this.y = videoService.MouseY(y);
            
            
            string mouseposition = $"This is the set position" + x + " " + y;

            videoService.DrawText(mouseposition, x, y);
            

            // Point position = new Point(x, y);
            // Turret turret = new Turret(position);
            

        }
    }



    // public Point updatePosition(Point newposition) 
    // {
    //     newposition = new Point(x, y);
    //     this.x = videoService.MouseX(x);
    //     this.y = videoService.MouseY(y);
            
    //     // string mouseposition = $"This is the set position" + x + " " + y;
    //     return newposition;
    // }
    

    


    // Updates the position and resolves any collisions or actions.
    private void GetUpdates() 
    {
        

        Point position = new Point(300, 400);
        Cast cast = new Cast();
        // cast.GetFirstActor("turret", position);
        // videoService.DrawActor("turret");

        


        // Turret turret = new Turret(null);
        // turret.placeTurret();


        
// ********************************************

        string text = "This is a string";

        videoService.DrawText(text, 15, 15);
        // int x = 10;
        // int y = 0;

        int mx = videoService.MouseX(x);
        int my = videoService.MouseY(y);

        string xAndY = $"This is the mouse position: " + mx + " " + my;
        videoService.DrawText(xAndY, 15, 50);

        string xpos_ypos = $"X: " + x + " " + "Y: " + y;
        videoService.DrawText(xpos_ypos, 500, 15);

// ***********************************

        // // Point point1 = new Point(400, 300);

        // Cast cast = new Cast();
        // // cast.AddActor("turret", new Turret(pointStart));



        // cast.GetFirstActor("turret");
        

        // Turret turret1 = (Turret)cast.GetFirstActor("turret");
        // videoService.DrawActor(turret1);

    }


    // Draws the stuff on the screen.
    private void DoOutputs() 
    {
        videoService.ClearBuffer();

            // Draws the stuff.
        // videoService.DrawActors(actors);


        videoService.FlushBuffer();
        
    }



}
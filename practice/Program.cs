using System;
using System.Collections.Generic;


public class Program
{

    private static int FRAME_RATE = 15;
        private static int MAX_X = 900;
        private static int MAX_Y = 600;
        private static int CELL_SIZE = 15;
        private static int FONT_SIZE = 15;
        private static int COLS = 60;
        private static int ROWS = 40;
        private static string CAPTION = "Tower Defence";
        private static int DEFAULT = 20;



    static void Main(string[] args)
    {
        VideoService videoService = new VideoService(false);
        // Point pointStart = new Point(400, 300);

        // Turret turret = new Turret();
        
        Point point = new Point(400, 300);


        Cast cast = new Cast();
        cast.AddActor("turret", new Turret(point));
        

        
        
        // Create the Script
        Script script = new Script();
        script.AddAction("output", new DrawActorsAction(videoService));
        



        Director director = new Director(videoService);
        director.StartGame(cast, script);

    }

}
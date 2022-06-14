using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Unit04.Game.Casting;
using Unit04.Game.Directing;
using Unit04.Game.Services;


namespace Unit04
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        private static int FRAME_RATE = 15;
        private static int MAX_X = 900;
        private static int MAX_Y = 600;
        private static int CELL_SIZE = 15;
        private static int FONT_SIZE = 15;
        private static int COLS = 60;
        private static int ROWS = 40;
        private static string CAPTION = "Greed";
        private static string DATA_PATH = "Data/messages.txt";
        private static Color WHITE = new Color(255, 255, 255);
        private static int DEFAULT_BOXES = 40;
        private static int DEFAULT_BALLS = 25;
        // private static int BALL_MOVEMENT = 0;


        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            // create the cast
            Cast cast = new Cast();

            // create the banner
            Actor banner = new Actor();
            banner.SetText("");
            banner.SetFontSize(FONT_SIZE);
            banner.SetColor(WHITE);
            banner.SetPosition(new Point(CELL_SIZE, 0));
            cast.AddActor("banner", banner);

            // create the robot
            Actor robot = new Actor();
            robot.SetText("#");
            robot.SetFontSize(FONT_SIZE);
            robot.SetColor(WHITE);
            robot.SetPosition(new Point(MAX_X / 2, MAX_Y / 2));
            cast.AddActor("robot", robot);

            // // create movement
            // Artifact ball = new Artifact();
            // ball.SetText("#");
            // ball.SetFontSize(FONT_SIZE);
            // ball.SetColor(WHITE);
            // ball.SetPosition(new Point(MAX_X / 2, MAX_Y / 2));
            // cast.AddActor("ball", ball);


            // load the messages
            List<string> messages = File.ReadAllLines(DATA_PATH).ToList<string>();

            // create the artifacts
            Random random = new Random();
            for (int i = 0; i < DEFAULT_BOXES; i++)
            {
                // string text = ((char)random.Next(33, 126)).ToString();
                // int unicode = 48;
                // char character = (char) unicode;
                // string text = character.ToString();

                string text = "0";

                int dx = 0;
                int dy = 10;
                Point direction = new Point(dx, dy);
                
                
                string message = messages[i];

                int x = random.Next(1, COLS);
                int y = random.Next(1, ROWS);
                Point position = new Point(x, y);
                position = position.Scale(CELL_SIZE);
                Actor move = new Actor();
                move.MoveNext(x, y);



            
                int r = random.Next(0, 256);
                int g = random.Next(0, 256);
                int b = random.Next(0, 256);
                Color color = new Color(r, g, b);

                Artifact artifact = new Artifact();
                artifact.SetText(text);
                artifact.SetFontSize(FONT_SIZE);
                artifact.SetColor(color);
                artifact.SetPosition(position);
                // artifact.SetMessage(message);
                cast.AddActor("artifacts", artifact);
            }


            // Create Balls
            for (int i = 0; i < DEFAULT_BALLS; i++)
            {

                string text = "x";

                int dx = 0;
                int dy = 10;
                Point direction = new Point(dx, dy);
                
                
                string message = messages[i];

                int x = random.Next(1, COLS);
                int y = random.Next(1, ROWS);
                Point position = new Point(x, y);
                position = position.Scale(CELL_SIZE);
                Actor move = new Actor();
                move.MoveNext(x, y);
                


            
                int r = 225;
                int g = 6;
                int b = 0;
                Color color = new Color(r, g, b);

                Artifact artifact = new Artifact();
                artifact.SetText(text);
                artifact.SetFontSize(FONT_SIZE);
                artifact.SetColor(color);
                artifact.SetPosition(position);
                // artifact.SetMessage(message);
                cast.AddActor("balls", artifact);
            }

            // // Create the Balls
            
            // for (int i = 0; i < DEFAULT_BALLS; i++)
            // {
            //     // string text = ((char)random.Next(33, 126)).ToString();

            //     string text = ("*").ToString();

            //     // int unicode = 48;
            //     // char character = (char) unicode;
            //     // string text = character.ToString();
                
            //     string message = messages[i];

            //     int dx = 0;
            //     int dy = 5;
            //     Point direction = new Point(dx, dy);

            //     int x = random.Next(1, COLS);
            //     int y = 0;
            //     Point position = new Point(10, y);
            //     position = position.Scale(CELL_SIZE);

            //     int r = random.Next(0, 256);
            //     int g = random.Next(0, 256);
            //     int b = random.Next(0, 256);
            //     Color color = new Color(r, g, b);

            //     Artifact artifact = new Artifact();
            //     artifact.SetText(text);
            //     artifact.SetFontSize(FONT_SIZE);
            //     artifact.SetColor(color);
            //     artifact.SetPosition(position);
            //     // artifact.SetMessage(message);
            //     cast.AddActor("artifacts", artifact);
            // }

            // start the game
            KeyboardService keyboardService = new KeyboardService(CELL_SIZE);
            VideoService videoService 
                = new VideoService(CAPTION, MAX_X, MAX_Y, CELL_SIZE, FRAME_RATE, false);
            Director director = new Director(keyboardService, videoService);
            director.StartGame(cast);

            // test comment
        }
    }
}
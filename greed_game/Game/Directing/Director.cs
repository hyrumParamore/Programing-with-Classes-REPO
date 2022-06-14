using System.Collections.Generic;
using Unit04.Game.Casting;
using Unit04.Game.Services;


namespace Unit04.Game.Directing
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private KeyboardService keyboardService = null;
        private VideoService videoService = null;

        public int score = 0;
        /// <summary>
        /// Constructs a new instance of Director using the given KeyboardService and VideoService.
        /// </summary>
        /// <param name="keyboardService">The given KeyboardService.</param>
        /// <param name="videoService">The given VideoService.</param>
        public Director(KeyboardService keyboardService, VideoService videoService)
        {
            this.keyboardService = keyboardService;
            this.videoService = videoService;
        }

        /// <summary>
        /// Starts the game by running the main game loop for the given cast.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        public void StartGame(Cast cast)
        {
            videoService.OpenWindow();
            while (videoService.IsWindowOpen())
            {
                GetInputs(cast);
                DoUpdates(cast);
                DoOutputs(cast);
            }
            videoService.CloseWindow();
        }

        /// <summary>
        /// Gets directional input from the keyboard and applies it to the robot.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        private void GetInputs(Cast cast)
        {
            Actor robot = cast.GetFirstActor("robot");
            Point velocity = keyboardService.GetDirection();
            robot.SetVelocity(velocity);     
        }

        /// <summary>
        /// Updates the robot's position and resolves any collisions with artifacts.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        private void DoUpdates(Cast cast)
        {
            Actor banner = cast.GetFirstActor("banner");
            Actor robot = cast.GetFirstActor("robot");
            List<Actor> artifacts = cast.GetActors("artifacts");
            List<Actor> balls = cast.GetActors("balls");

            // score = ToString(score);

            
            int maxX = videoService.GetWidth();
            int maxY = videoService.GetHeight();
            robot.MoveNext(maxX, maxY);

            // int r = 225;
            // int g = 6;
            // int b = 0;
            // Color color = new Color(r,g,b);

            foreach (Actor actor in artifacts)
            {
                

                banner.SetIntText(score);
                actor.MoveNext(maxX, maxY);
                // ball.MoveNext(maxX, maxY);
                if (robot.GetPosition().Equals(actor.GetPosition()))
                {   
                    
                    Artifact artifact = (Artifact) actor;
                    string message = artifact.GetMessage();
                    banner.SetText(message + score );
                    score = score - 100;
                    // r = 0;
                    // g = 0;
                    // b = 0;
                    // Color color = new Color(r, g, b);
                    // artifact.SetColor(color);
                }
                // else if (robot.GetPosition().Equals(ball.GetPosition())) 
                // {
                //     // robot.GetPosition().Equals(cast.GetFirstActor());
                    
                //     score = score - 100;
                // }
                // }
                } 
                foreach (Actor ball in balls)
                {
                    banner.SetIntText(score);
                    ball.MoveNext(maxX, maxY);
                    // ball.MoveNext(maxX, maxY);
                    if (robot.GetPosition().Equals(ball.GetPosition()))
                    {
                        
                        Artifact artifact = (Artifact) ball;
                        string message = artifact.GetMessage();
                        banner.SetText(message + score );
                        score = score + 100;
                        int r = 0;
                        int g = 0;
                        int b = 0;
                        Color color = new Color(r, g, b);
                        artifact.SetColor(color);
                        // if (r == 225 && g == 6 && b == 0)
                        // {
                        //     score = score + 100;
                        
                        //     r = 0;
                        //     g = 0;
                        //     b = 0;
                            
                        // }
                        // else 
                        // {
                            
                        // }
                    }
                }
        }

        /// <summary>
        /// Draws the actors on the screen.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        public void DoOutputs(Cast cast)
        {
            List<Actor> actors = cast.GetAllActors();
            videoService.ClearBuffer();
            videoService.DrawActors(actors);
            videoService.FlushBuffer();
        }

    }
}
using System.Collections.Generic;



    /// <summary>
    /// <para>An output action that draws all the actors.</para>
    /// <para>The responsibility of DrawActorsAction is to draw each of the actors.</para>
    /// </summary>
    public class DrawActorsAction  : Action
    {
        private VideoService videoService;

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public DrawActorsAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            // Snake snake2 = (Snake)cast.GetFirstActor("snake2");
            // Turret turret = (Turret)cast.GetFirstActor("turret");

            // List<Actor> segments2 = snake2.GetSegments();
            // List<Actor> segments = snake.GetSegments();

            // Actor turret = cast.GetFirstActor("score");
            Actor turret = cast.GetFirstActor("turret");
            
            // List<Actor> messages = cast.GetActors("messages");
            
            videoService.ClearBuffer();
            videoService.DrawActor(turret);
            // videoService.DrawActors(segments2);
            // videoService.DrawActor(score);
            // videoService.DrawActor(food);
            // videoService.DrawActors(messages);
            videoService.FlushBuffer();
        }
    }

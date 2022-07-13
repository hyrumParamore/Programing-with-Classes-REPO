using Raylib_cs;
using HelloWorld;

namespace HelloWorld
{
    public class Director {

        public void StartGame()
            {
                Raylib.InitWindow(800, 480, "Hello World");


                
                

                

                while (!Raylib.WindowShouldClose())
                {

                    // Get Mouse Position to add to Tower.
                    int mousex = Raylib.GetMouseX();
                    int mousey = Raylib.GetMouseY();
                    // Point position = new Point(mousex, mousey);
                    // Point.MousePosition(x, y);



                    
                    Raylib.ClearBackground(Color.WHITE);

                    Raylib.DrawText("Hello, world!", 12, 12, 20, Color.BLACK);

                    Raylib.EndDrawing();

                    // Raylib.HideCursor(); 

                    Raylib.DrawCircle(50, 50, 50, Color.BLUE);

                    VideoService video = new VideoService(true);
                    video.ClearBuffer();
                    // video.DrawGrid();
                    
                    
                    

                    
                    // Vector TEST
                    // int vector = Raylib.GetMousePosition(mousex, mousey);



                    int x = 0;
                    int y = 0;


                    // string stringmousex = mousex.ToString();
                    // string stringmousey = mousey.ToString();
                    // Raylib.DrawText(stringmousex, 30, 150, Constants.CELL_SIZE * 2, Color.BLACK);

                    if(Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT))
                    {
                        
                        // Place tower at pressed location
                        List<Actor> actors = Cast.GetFistActor()

                        Tower tower = new Tower();

                        VideoService videoservice = new VideoService(true);
                        videoservice.DrawActor(actor);




                        Raylib.DrawCircle(mousex, mousey, 50, Color.RED);
                        












                        // Raylib.DrawText("Hello, world!", mousex, mousey, 20, Color.BLACK);

                        // Cast cast = new Cast();
                        // // cast.AddActor("Bob", new Actor());
                        // cast.AddActor("hashtag", new Food());
                        
                        // List<Actor> act = cast.GetAllActors();
                        // Console.WriteLine(act);


                        Raylib.DrawText("Bob", mousex, mousey, 20, Color.BLACK);


                    }

                
                

                    
                }
                Raylib.CloseWindow();
            }
    }
}
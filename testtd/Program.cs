using Raylib_cs;
using HelloWorld;



namespace HelloWorld
{
    class Program
    {
        int screenWidth = 800;
        int screenHeight = 480;
        


        public bool mouseWasPressed = false;
    
        public Program(int screenWidth, int screenHeight) {
            this.screenWidth = screenWidth;
            this.screenHeight = screenHeight;
            // this.mouseWasPressed = mouseWasPressed;

        }
        
        public static void Main(string[] args) {
            Director director = new Director();
            director.StartGame(); 
        }

        


        // public void DrawGrid()
        // {
        //     for (int x = 0; x < Constants.MAX_X; x += Constants.CELL_SIZE)
        //     {
        //         Raylib.DrawLine(x, 0, x, Constants.MAX_Y, Raylib_cs.Color.GRAY);
        //     }
        //     for (int y = 0; y < Constants.MAX_Y; y += Constants.CELL_SIZE)
        //     {
        //         Raylib.DrawLine(0, y, Constants.MAX_X, y, Raylib_cs.Color.GRAY);
        //     }
        // }

    }
}




// private void DrawGrid()
//         {
//             for (int x = 0; x < Constants.MAX_X; x += Constants.CELL_SIZE)
//             {
//                 Raylib.DrawLine(x, 0, x, Constants.MAX_Y, Raylib_cs.Color.GRAY);
//             }
//             for (int y = 0; y < Constants.MAX_Y; y += Constants.CELL_SIZE)
//             {
//                 Raylib.DrawLine(0, y, Constants.MAX_X, y, Raylib_cs.Color.GRAY);
//             }
//         }
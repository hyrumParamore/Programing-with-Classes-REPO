using Raylib_cs;
using System;


public class Display 
{

    private string caption = "";
    private int width = 900;
    private int height = 600;
    private int frameRate = 10;
    public int cellSize = 30;

    public float radius = 50;

    private static Color BLUE = new Color(0, 0, 255);





    public Display()
    {

    }



    // Open window.
    public void OpenWindow() 
    {
        Raylib.InitWindow(width, height, caption);
        Raylib.SetTargetFPS(frameRate);
    }

    // Closes window.
    public void CloseWindow()
    {
        Raylib.CloseWindow();
    }

    public bool IsWindowOpen()
    {
        return !Raylib.WindowShouldClose();
    }


    // Gets the screen's width.
    public int GetWidth() 
    {
        return width;
    }

    // Gets the screen's height.
    public int GetHeight()
    {
        return height;
    }


    public void DrawText(string text, int width, int height)
    {
        // Raylib.ClearBackground(Color.WHITE);
        Raylib.DrawText(text, width, height, 25, Raylib_cs.Color.BLACK);
    }



    /// Copies the buffer contents to the screen. This method should be called at the end of
    /// the game's output phase.
    // public void FlushBuffer()
    // {
    //     Raylib.EndDrawing();
    // }


    // Gets the grids cell size
    public int GetCellSize()
    {
        return cellSize;
    }


    // Draws a grid
    private void DrawGrid()
    {
        for (int x = 0; x < width; x += cellSize)
        {
            Raylib.DrawLine(x, 0, x, height, Raylib_cs.Color.GRAY);
        }
        for (int y = 0; y < height; y += cellSize)
        {
            Raylib.DrawLine(0, y, width, y, Raylib_cs.Color.GRAY);
        }
    }

    public void BeginDrawing()
    {
        Raylib.BeginDrawing();
    }

    public void ClearBackground()
    {
        Raylib.ClearBackground(Raylib_cs.Color.WHITE);
    }

    public void EndDrawing()
    {
        Raylib.EndDrawing();
    }



    // Draws the given actor's text on the screen.

    public void DrawActor(Actor actor)
    {
        string text = actor.GetText();
        int x = actor.GetPosition().GetX();
        int y = actor.GetPosition().GetY();
        int fontSize = actor.GetFontSize();
        Color c = actor.GetColor();
        Raylib_cs.Color color = ToRaylibColor(c);
        Raylib.DrawText(text, x, y, 15, color);
    }

    private Raylib_cs.Color ToRaylibColor(Color color)
    {
        int r = color.GetRed();
        int g = color.GetGreen();
        int b = color.GetBlue();
        int a = color.GetAlpha();
        return new Raylib_cs.Color(r, g, b, a);
    }




    // Draws the given list of actors on the screen.
    // <param name="actors">The list of actors to draw.</param>
    public void DrawActors(List<Actor> actors)
    {
        foreach (Actor actor in actors)
        {
            DrawActor(actor);
        }
    }

    public int MouseX(int x)
    {
        x = Raylib.GetMouseX();
        return x;
    }

    public int MouseY(int y)
    {
        y = Raylib.GetMouseY();
        return y;
    }




    // Keeps Artifacts in motion.
    // <returns>The direction as an instance of Point.</returns>
    public Point MoveActors()
        {
            int dx = 0;
            int dy = 1;

            Point direction = new Point(dx, dy);
            direction = direction.Scale(cellSize);

            return direction;
        }




    public void DrawCircle(int x, int y, float radius)
    {
        Raylib.DrawCircleLines(x, y, radius, Raylib_cs.Color.BLACK); 
    }
}
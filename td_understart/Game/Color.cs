using System.Collections.Generic;




// <para>The responsibility of Color is to hold and provide information about itself. Color has 
// a few convenience methods for comparing and converting them.
public class Color
{
    private int red = 0;
    private int green = 0;
    private int blue = 0;
    private int alpha = 255;
    


    // Constructs a new instance of Color using the given red, green and blue values.
    public Color(int red, int green, int blue)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
    }


    // Gets the color's alpha value.
    // <returns>The alpha value.</returns>
    public int GetAlpha()
    {
        return alpha;
    }


    // Gets the color's blue value.
    // <returns>The blue value.</returns>
    public int GetBlue()
    {
        return blue;
    }


    // Gets the color's green value.
    // <returns>The green value.</returns>
    public int GetGreen()
    {
        return green;
    }

    // Gets the color's red value.
    // <returns>The red value.</returns>
    public int GetRed()
    {
        return red;
    }

}

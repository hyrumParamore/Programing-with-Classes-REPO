 
public class Director {

// I moved the variables to the top here
    public int counter = 0;
    public int rightLetters = 0;

    // public int wrong;


    public void PrintBoard(int wrong) {

        if (wrong == 1)
            {
                Console.WriteLine("\n_ _ _ _ _ _");
                Console.WriteLine("  ___  ");
                Console.WriteLine(" /___\\");
                Console.WriteLine(" \\   /");
                Console.WriteLine("  \\ /");
                Console.WriteLine("  \\O/");
                Console.WriteLine("   |");
                Console.WriteLine("  / \\");
                Console.WriteLine("\n^^^^^^^^^^^^");
            }
            else if (wrong == 2)
            {
                Console.WriteLine("\n_ _ _ _ _ _");
                Console.WriteLine("");
                Console.WriteLine(" /___\\");
                Console.WriteLine(" \\   /");
                Console.WriteLine("  \\ /");
                Console.WriteLine("  \\O/");
                Console.WriteLine("   |");
                Console.WriteLine("  / \\");
                Console.WriteLine("\n^^^^^^^^^^^^");
            }
            else if (wrong == 3)
            {
                Console.WriteLine("\n_ _ _ _ _ _");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(" \\   /");
                Console.WriteLine("  \\ /");
                Console.WriteLine("  \\O/");
                Console.WriteLine("   |");
                Console.WriteLine("  / \\");
                Console.WriteLine("\n^^^^^^^^^^^^");
            }
            else if (wrong == 4)
            {
                Console.WriteLine("\n_ _ _ _ _ _");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("  \\ /");
                Console.WriteLine("  \\O/");
                Console.WriteLine("   |");
                Console.WriteLine("  / \\");
                Console.WriteLine("\n^^^^^^^^^^^^");
            }
            else if (wrong == 5)
            {
                Console.WriteLine("\n_ _ _ _ _ _");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("  \\O/");
                Console.WriteLine("   |");
                Console.WriteLine("  / \\");
                Console.WriteLine("\n^^^^^^^^^^^^");
            }
            else if (wrong == 6)
            {
                Console.WriteLine("\n_ _ _ _ _ _");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("   x ");
                Console.WriteLine("  /|\\");
                Console.WriteLine("  / \\");
                Console.WriteLine("\n^^^^^^^^^^^^");
            }
    }

    public int printWord(List<char>guessedLetters, string randomWord) 
    {
        Console.WriteLine("\n");

        foreach (char c in randomWord)
        {
            if (guessedLetters.Contains(c))
            {
                Console.Write(c + " ");
                rightLetters++;
            }
            else 
            {
                Console.Write(" ");
            }
            counter++;
        }
        return rightLetters;
    }

    public void printLines(string randomWord){

        Console.Write("\r");
        foreach(char c in randomWord)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("\u0305 ");
        }

    }

        





}
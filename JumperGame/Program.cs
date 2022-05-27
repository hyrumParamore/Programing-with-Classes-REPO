using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;


namespace JumperGame {
    public class Program {
        
        

        static void Main(string[] args)
        {

            int amountOfTimesWrong = 0;
            int currentLettersRight = 0;

            
            Director director = new Director();
            RandomWord random = new RandomWord();
            string randomWord = random.CreateRandomWord();

            Console.WriteLine("Welcome to hangman :)");
            Console.WriteLine("-------------------------------------");


            // Pick a Random Word
            // Random random = new Random();
            // List<String> wordDictionary = new List<String> {"flower", "mission", "byuido", "popping", "pig", "pizza"};
            // int index = random.Next(wordDictionary.Count);
            // String randomWord = wordDictionary[index];



            foreach (char x in randomWord)
            {
                Console.Write("_ ");
            }

            int lengthOfWordToGuess = randomWord.Length;
            
            List<char> currentLettersGuessed = new List<char>();
            

            while(amountOfTimesWrong != 6 && currentLettersRight != lengthOfWordToGuess)
            {
                Console.Write("\nLetters guessed so far: ");
                foreach (char letter in currentLettersGuessed)
                {
                    Console.Write(letter + " ");
                }
                Console.Write("\nGuess a letter: ");
                char letterGuessed = Console.ReadLine()[0];
                if(currentLettersGuessed.Contains(letterGuessed))
                {
                    Console.Write("\r\nYou have already gussed this letter.");
                    director.PrintBoard(amountOfTimesWrong);
                    currentLettersRight = director.printWord(currentLettersGuessed,randomWord);
                    director.printLines(randomWord);
                }
                else
                {
                    bool right = false;
                    for(int i = 0; i < randomWord.Length; i++) {if(letterGuessed == randomWord[i]){right = true;}}

                    if (right)
                    {
                        director.PrintBoard(amountOfTimesWrong);
                        currentLettersGuessed.Add(letterGuessed);
                        currentLettersRight = director.printWord(currentLettersGuessed, randomWord);
                        Console.Write("\r\n");
                        director.printLines(randomWord);
                    }
                    else
                    {
                        amountOfTimesWrong++;
                        currentLettersGuessed.Add(letterGuessed);
                        director.PrintBoard(amountOfTimesWrong);
                        currentLettersRight = director.printWord(currentLettersGuessed, randomWord);
                        Console.Write("\r\n");
                        director.printLines(randomWord);



                    }
                }
                
            }
            Console.WriteLine("\r\nGame is over! Thank you for playing! ");

        }





    }
}
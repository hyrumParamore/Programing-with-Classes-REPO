// Player class controlls the guesses.

public class Player {

    public int guesses;


    public Player() {
        guesses = 0;
    }

    public int GuessedCorrect() {
        return guesses;
    }

    public int GuessedIncorrect() {
        guesses = guesses +1;
        return guesses;
    }


}
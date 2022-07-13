
public class RandomWord {

    private string randomWord;

    public RandomWord() {
        randomWord = "";
    }

    

    public string CreateRandomWord(){

        // Pick a Random Word
        Random random = new Random();
        List<string> wordList = new List<string> {"flower", "mission", "byuido", "popping", "pig", "pizza"};
        int index = random.Next(wordList.Count);
        string randomWord = wordList[index];

        return this.randomWord;
    }

}
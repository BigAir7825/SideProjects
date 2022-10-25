using System;

public class GetTwoWords
{
    public string ChooseWord(List<string> listOfWords)
    {
        Random random = new Random();
        int randomNumber = random.Next(0, listOfWords.Count - 1);
        string word = listOfWords[randomNumber];
        return word;
    }
    public List<string> RemoveChosenLetters(List<string> listOfWords, string word1, string word2)
    {
        listOfWords.Remove(word1);
        listOfWords.Remove(word2);
        return listOfWords;
    }
}

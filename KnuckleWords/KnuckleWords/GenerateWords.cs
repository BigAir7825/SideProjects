using System;

public class GenerateWords
{
    public string firstWord;
    public List<string> possibleLastWords;
    public List<string> listOfAllPossibleWords;
    public GenerateWords(string first, List<string> possibleLast)
    {
        this.firstWord =  first;
        this.possibleLastWords = possibleLast;
        this.listOfAllPossibleWords = new List<string>();
        listOfAllPossibleWords.AddRange(ListOfPossibleWordsSideToSide());
        listOfAllPossibleWords.AddRange(ListOfPossibleWordsInterspersed());
    }
    public List<string> ListOfPossibleWordsSideToSide()
    {
        List<string> words = new List<string>();
        foreach(string lastWord in possibleLastWords)
        {
            words.Add(firstWord.ToLower() + lastWord.ToLower());
        }
        return words;
    }
    public List<string> ListOfPossibleWordsInterspersed()
    {
        List<string> words = new List<string>();
        char[] firstLetters = firstWord.ToCharArray();
        foreach(string lastWord in possibleLastWords)
        {
            char[] lastLetters = lastWord.ToCharArray();
            string possibleWord = ($"{firstLetters[0]}{lastLetters[0]}{firstLetters[1]}{lastLetters[1]}{firstLetters[2]}{lastLetters[2]}{firstLetters[3]}{lastLetters[3]}");
            words.Add(possibleWord);
        }
        return words;
    }
}

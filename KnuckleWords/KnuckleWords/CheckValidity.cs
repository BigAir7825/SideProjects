using System;

public class CheckValidity
{
    public List<string> possibleWords;
    public List<string> actualWords;
    public List<string> matchingWords;
    public CheckValidity(List<string> possible, List<string> actual)
    {
        this.possibleWords = possible;
        this.actualWords = actual;
        matchingWords = new List<string>();
        FindPossibleInActual();
    }
    public void FindPossibleInActual()
    {
        foreach (string possibleWord in possibleWords)
        {
            try
            {
                actualWords.Find(item => item.Equals(possibleWord));
                matchingWords.Add(possibleWord.ToLower());
            } catch (Exception e)
            {
            }            
        }
 
    }
}

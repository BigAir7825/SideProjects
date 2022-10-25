internal class Program
{
    private static void Main(string[] args)
    {
        //Read values from file to get the 4 letter words, generate all possible words, then check if they are valid, then save the valid ones to a document
        ReadFromFile read = new ReadFromFile();
        List<string> listOfFourLetterWords = read.GetWordList("fourletterwords.txt");
        Console.WriteLine("Successfuly got the list of four letter words");
        List<string> listOfEigtLetterWords = read.GetWordList("eightletterwords.txt");
        Console.WriteLine("Successfuly got the list of eight letter words");
        GenerateWords generator;
        CheckValidity checkValidity;
        int numOfValidWords = 0;
        foreach (string word in listOfFourLetterWords)
        {
            //generate possible words
            generator = new GenerateWords(word, listOfFourLetterWords);
            generator.firstWord = word;
            generator.possibleLastWords = listOfFourLetterWords;
            List<string> possibleWords = generator.listOfAllPossibleWords;
            //find the valid words
            checkValidity = new CheckValidity(possibleWords, listOfEigtLetterWords);
            checkValidity.possibleWords = possibleWords;
            checkValidity.actualWords = listOfEigtLetterWords;
            List<string> matchingWords = checkValidity.matchingWords;
        foreach (string wordL in matchingWords)
            {
                Console.WriteLine(wordL);
            }
            numOfValidWords += matchingWords.Count;
            //TODO: output the valid words
        }

        Console.WriteLine($"The number of correct words is {numOfValidWords:N}, all valid words are in a text file");
    }
}
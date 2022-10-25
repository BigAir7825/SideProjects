//TODO: make this functional
using System;
public class WriteToFile
{
    public string filePath = "matchingwords.txt";
    public List<string> successfulWords;
    public WriteToFile(List<string> words)
    {
        this.successfulWords = words;
        WriteTheText();
    }
    public void WriteTheText()
    {
        StreamWriter writer = new StreamWriter(filePath);
        foreach (string word in successfulWords)
        {
            writer.WriteLine(word);
        }
        writer.Close();
    }
}
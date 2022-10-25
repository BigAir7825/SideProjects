using System;

public class ReadFromFile
{
	public List<string> GetWordList(string filepath)
	{
		StreamReader sr = new StreamReader(filepath);
		List<string> listOfWords = new List<string>();
		while (!sr.EndOfStream)
		{
			string line = sr.ReadLine();
			listOfWords.Add(line.Trim());
		}
		sr.Close();
		return listOfWords;
	}
}

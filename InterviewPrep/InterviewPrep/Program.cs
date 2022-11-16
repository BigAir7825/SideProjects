bool looper = true;
string input;
int choice;
Console.WriteLine("New question = 1\nGo over Questions = 2\n");
choice = Convert.ToInt32(Console.ReadLine());
if (choice == 1)
{
    StreamWriter writer = new StreamWriter("questions.txt", true);
    while (looper)
    {
        Console.WriteLine("Next question");
        input = Console.ReadLine();
        if (input != "end")
            writer.WriteLine(input);
        else if (input == "end")
            looper = false;
    }
    writer.Close();
}
else
{
    StreamReader reader = new StreamReader("newQuestions.txt");
    List<string> questions = new List<string>();
   for (int i = 0; i < 46; i++)
    {
        questions.Add(reader.ReadLine());
    }
    Random rand = new Random();
    while (looper)
    {
        int lineNum = rand.Next(0, 45);
        string output = (questions[lineNum]);
        Console.WriteLine("\n" + output + " struggled? y/n\n");
        string userInput = Console.ReadLine();
        if (userInput == "end")
            looper = false;
        else if (userInput == "y")
        {
            StreamWriter writer = new StreamWriter("questions.txt", true);
            writer.WriteLine(output);
            writer.Close();
        }
    }

    reader.Close();
}


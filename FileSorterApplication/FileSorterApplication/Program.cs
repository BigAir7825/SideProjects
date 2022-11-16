using FileSorterApplication;

Console.WriteLine("Checking startup status");
Startup start = new Startup();
Console.WriteLine("Startup complete, beginning regular function");
Search search = new Search(start.filePaths);
if (search.outOfPlace.Count > 0)
{
    Console.WriteLine("Sorting");
}
else
{
    Console.WriteLine("Search Complete, Clear");
}
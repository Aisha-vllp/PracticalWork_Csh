using System.IO;
using System.Dynamic;

public class LibraryCard
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Copies { get; set; }

    public LibraryCard(string title, string author, int copies)
    {
        Title = title;
        Author = author;
        Copies = copies;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Copies: {Copies}");
    }
}

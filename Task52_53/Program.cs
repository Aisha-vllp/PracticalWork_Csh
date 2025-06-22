// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

dynamic rFile = new ReadOnlyFile(@"..\..\..\TextFile1.txt"); //ReadOnlyFile(@"..\..\TextFile1.txt");
foreach (string line in rFile.Customer)
{
    Console.WriteLine(line);
}
Console.WriteLine("----------------------------");
foreach (string line in rFile.Customer(StringSearchOption.Contains, true))
{
    Console.WriteLine(line);
}

LibraryCard book1 = new LibraryCard("1984", "George Orwell", 5);
book1.DisplayInfo();

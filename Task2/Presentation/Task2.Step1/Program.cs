// See https://aka.ms/new-console-template for more information

using Task2.Step1;

string[] headers = { "Name", "Family", "Start Date", "End Date", "Sum", "Total" };

Console.WriteLine("Hello, World!");

var query = new Query(Data.People, Data.Transactions);
var result = query.Execute();

// Print the table headers
Console.WriteLine("| " + string.Join(" | ", headers) + " |");

// Print the separator row
Console.WriteLine("|" + new string('-', headers.Length * 5 + (headers.Length - 1) * 3) + "|");

// Print the table rows
foreach (var row in result)
{
    Console.WriteLine("| " + $"{row.Name} | {row.Family} | {row.StartDate} | {row.EndDate} | {row.Sum} | {row.Total}" + " |");
}
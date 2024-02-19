namespace Task2.Step1;

public class QueryResult
{
    public QueryResult()
    { }

    public QueryResult(string name, string family, DateTime startDate, DateTime? endDate, int sum, int total)
    {
        Name = name;
        Family = family;
        StartDate = startDate;
        EndDate = endDate;
        Sum = sum;
        Total = total;
    }

    public string Name { get; init; } = null!;
    public string Family { get; init; } = null!;
    public DateTime StartDate { get; init; }
    public DateTime? EndDate { get; init; }
    public int Sum { get; init; }
    public int Total { get; init; }
}
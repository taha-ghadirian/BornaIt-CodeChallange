using Task2.Core.People;
using Task2.Core.Transactions;

namespace Task2.Step1;

/// <summary>
/// Manual static Data
/// </summary>
public static class Data
{
    /// <summary>
    /// People given in the description document
    /// </summary>
    public static List<Person> People =
    [
        new Person(new PersonId(), "Jane", "Parker"),
        new Person(new PersonId(), "Mike", "Copper")
    ];

    /// <summary>
    /// Transactions given in the description document
    /// </summary>
    public static List<Transaction> Transactions =
    [
        new Transaction(new TransactionId(), 
            People[0].Id,
            new DateTime(2019, 11, 01, 12, 30, 00),
            100000),
        new Transaction(new TransactionId(), 
            People[0].Id,
            new DateTime(2019, 11, 01, 16, 30, 00),
            200000),
        new Transaction(new TransactionId(), 
            People[0].Id,
            new DateTime(2019, 11, 01, 18, 30, 00),
            50000),
        new Transaction(new TransactionId(), 
            People[0].Id,
            new DateTime(2019, 11, 03, 09, 30, 00),
            300000),
        //------------User 2--------------
        new Transaction(new TransactionId(), 
            People[1].Id,
            new DateTime(2019, 11, 01, 14, 30, 00),
            100000),
        new Transaction(new TransactionId(), 
            People[1].Id,
            new DateTime(2019, 11, 01, 12, 30, 00),
            20000),
    ];
}
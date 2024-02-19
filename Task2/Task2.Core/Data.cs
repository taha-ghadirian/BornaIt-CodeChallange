using Task2.Core.Base;
using Task2.Core.People;
using Task2.Core.Transactions;

namespace Task2.Core;

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
        new Person(new Guid("E16FE15F-94AB-46C9-AAAB-DB552327E183"), 
            "Jane", "Parker"),
        new Person(new Guid("D745193C-8A95-4828-918C-88390F2E212E"),
            "Mike", "Copper")
    ];

    /// <summary>
    /// Transactions given in the description document
    /// </summary>
    public static List<Transaction> Transactions =
    [
        new Transaction(new Guid("41f5bab3-6dcd-425c-bf4d-dbd1485d8a31"), 
            People[0].Id,
            new DateTime(2019, 11, 01, 12, 30, 00),
            100000),
        new Transaction(new Guid("6f58926d-7332-4446-b644-254d894438ce"), 
            People[0].Id,
            new DateTime(2019, 11, 01, 16, 30, 00),
            200000),
        new Transaction(new Guid("65a2d24f-f466-4cc4-b4e7-a5559fcd90a8"), 
            People[0].Id,
            new DateTime(2019, 11, 01, 18, 30, 00),
            50000),
        new Transaction(new Guid("4e6c1cbd-6b69-47ad-81b5-6ff0e31a8150"), 
            People[0].Id,
            new DateTime(2019, 11, 03, 09, 30, 00),
            300000),
        //------------User 2--------------
        new Transaction(new Guid("7c2856e1-efe4-4a71-8754-4c1cf0719675"), 
            People[1].Id,
            new DateTime(2019, 11, 01, 14, 30, 00),
            100000),
        new Transaction(new Guid("d4810df7-2d29-466e-a329-6eb045cc05ca"), 
            People[1].Id,
            new DateTime(2019, 11, 01, 12, 30, 00),
            20000),
    ];
}
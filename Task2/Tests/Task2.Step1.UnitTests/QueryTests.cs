using FluentAssertions;

namespace Task2.Step1.UnitTests;

public class QueryTests
{
    [Fact]
    public void ExecuteQuery_Should_ReturnTheTaskResult()
    {
        #region Prepration

        var query = new Query(Data.People, Data.Transactions);

        var result = new List<QueryResult>()
        {
            new QueryResult(
                "Jane",
                "Parker",
                new DateTime(2019, 11, 01),
                new DateTime(2019, 11, 03),
                350000,
                350000),
            new QueryResult(
                "Jane",
                "Parker",
                new DateTime(2019, 11, 03),
                null,
                300000,
                650000),
            new QueryResult(
                "Mike",
                "Copper",
                new DateTime(2019, 11, 01),
                null,
                120000,
                120000),
        };

        #endregion

        query
            .Execute()
            .Should()
            .BeEquivalentTo(result);
    }
}
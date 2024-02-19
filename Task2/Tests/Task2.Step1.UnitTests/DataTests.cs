using FluentAssertions;
using Task2.Core;

namespace Task2.Step1.UnitTests;

public class DataTests
{
    [Fact]
    public void People_Should_InitializedCorrectly()
    {
        Data
            .People
            .Should()
            .NotContain(p =>
                p.Id == Guid.Empty ||
                p.Version == Guid.Empty);
        Data
            .People
            .Should()
            .HaveCount(2);
        
        Data
            .People
            .Should()
            .OnlyHaveUniqueItems(p => p.Id);
    }

    [Fact]
    public void Transactions_Should_InitializedCorrectly()
    {
        Data
            .Transactions
            .Should()
            .NotContain(p =>
                p.Id == Guid.Empty ||
                p.Version == Guid.Empty ||
                p.PersonId == Guid.Empty);

        Data
            .Transactions
            .Should()
            .HaveCount(6);
        
        Data
            .Transactions
            .Should()
            .OnlyHaveUniqueItems(p => p.Id);
    }
}
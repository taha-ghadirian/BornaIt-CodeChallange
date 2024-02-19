namespace Task2.Core.ExceptionBase;


public class InvalidAggregateIdException()
    : DomainException($"Invalid aggregate id.")
{
    public override string Code => "invalid_aggregate_id";
}
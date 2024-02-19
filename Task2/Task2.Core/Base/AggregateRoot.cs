namespace Task2.Core.Base;

public class AggregateRoot
{
    public AggregateId Id { get; protected set; }

    public Guid Version { get; protected set; } = Guid.NewGuid();
}
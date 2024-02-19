namespace Task2.Core.Base;

public class AggregateRoot<TAggregateId> where TAggregateId : AggregateId
{
    public TAggregateId Id { get; protected set; }

    public Guid Version { get; protected set; } = Guid.NewGuid();
}
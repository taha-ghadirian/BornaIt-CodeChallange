namespace Task2.Core.ExceptionBase;


public abstract class DomainException(string message)
    : Exception(message)
{
    public virtual string Code { get; }
}
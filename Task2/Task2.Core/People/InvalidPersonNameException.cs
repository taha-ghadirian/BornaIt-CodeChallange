using Task2.Core.ExceptionBase;

namespace Task2.Core.People;

public class InvalidPersonNameException(string name)
    : DomainException($"Invalid name: {name}.")
{
    public override string Code { get; } = "invalid_name";
        
    public string Name{ get; } = name;
}
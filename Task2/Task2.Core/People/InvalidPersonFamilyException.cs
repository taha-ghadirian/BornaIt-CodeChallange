using Task2.Core.ExceptionBase;

namespace Task2.Core.People;

public class InvalidPersonFamilyException(string family)
    : DomainException($"Invalid family: {family}.")
{
    public override string Code { get; } = "invalid_family";
        
    public string Family{ get; } = family;
}
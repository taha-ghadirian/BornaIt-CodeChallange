using Task2.Core.Base;

namespace Task2.Core.People;

public class Person : AggregateRoot<PersonId>
{
    public string Name { get; set; }
    public string Family { get; set; }

    public Person(PersonId id, string name, string family)
    {
        if (string.IsNullOrWhiteSpace(name) || name.Length is > 50 or < 2)
            throw new InvalidPersonNameException(name);

        if (string.IsNullOrWhiteSpace(family) || family.Length is > 50 or < 2)
            throw new InvalidPersonFamilyException(family);

        Id = id;
        Name = name;
        Family = family;
    }
}
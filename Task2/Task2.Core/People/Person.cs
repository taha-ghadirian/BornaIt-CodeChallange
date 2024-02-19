using System.ComponentModel.DataAnnotations;
using Task2.Core.Base;
using Task2.Core.Transactions;

namespace Task2.Core.People;

public class Person : AggregateRoot
{
    [MaxLength(50)]
    public string Name { get; set; }
    [MaxLength(50)]
    public string Family { get; set; }

    public virtual ICollection<Transaction> Transactions { get; set; }

    public Person(AggregateId id, string name, string family)
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
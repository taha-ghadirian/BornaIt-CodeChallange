using Task2.Core.Base;
using Task2.Core.People;

namespace Task2.Core.Transactions;

public class Transaction : AggregateRoot<TransactionId>
{
    public PersonId PersonId { get; set; }

    public DateTime TransactionDate { get; set; }

    public int Price { get; set; }

    public Transaction(TransactionId id, PersonId personId, DateTime transactionDate, int price)
    {
        if(price is < 100 or > 1000000000)
        {
            throw new InvalidTransactionPriceException(price);
        }

        Id = id;
        PersonId = personId;
        TransactionDate = transactionDate;
        Price = price;
    }
}
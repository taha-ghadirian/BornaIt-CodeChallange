using Task2.Core.Base;
using Task2.Core.People;

namespace Task2.Core.Transactions;

public class Transaction : AggregateRoot
{
    public AggregateId PersonId { get; set; }

    public DateTime TransactionDate { get; set; }

    public int Price { get; set; }

    public virtual Person Person { get; set; }
        
    public Transaction(AggregateId id, AggregateId personId, DateTime transactionDate, int price)
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
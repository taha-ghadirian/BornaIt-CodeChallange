using Task2.Core.ExceptionBase;

namespace Task2.Core.Transactions;

public class InvalidTransactionPriceException(int price)
    : DomainException($"Invalid price: {price}, " +
                      $"price should be between 100 and 1,000,000,000.")
{
    public override string Code { get; } = "invalid_transaction_price";
        
    public int Price{ get; } = price;
}
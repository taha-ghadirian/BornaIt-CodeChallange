using Task2.Core;
using Task2.Core.People;
using Task2.Core.Transactions;

namespace Task2.Step1;

public class Query(List<Person> people, IEnumerable<Transaction> transactions)
{
    public IEnumerable<QueryResult> Execute()
    {
        // var result = transactions
        //     .GroupBy(t =>
        //         (t.PersonId, t.TransactionDate.Date)
        //     )
        //     .Select(t =>
        //     {
        //         var person = Data
        //             .People
        //             .Single(p => p.Id.Equals(t.Key.PersonId));
        //         
        //         var endDate = transactions.FirstOrDefault(tr =>
        //                 tr.TransactionDate.Date > t.Key.Date &&
        //                 tr.PersonId.Equals(t.Key.PersonId))?
        //             .TransactionDate
        //             .Date;
        //
        //         return new QueryResult(
        //             person.Name,
        //             person.Family,
        //             t.Key.Date,
        //             endDate,
        //             transactions.Where(p => p.PersonId.Equals(t.Key.PersonId) && p.TransactionDate.Date == t.Key.Date)
        //                 .Sum(p => p.Price),
        //             transactions.Where(p => p.PersonId.Equals(t.Key.PersonId) && p.TransactionDate.Date <= t.Key.Date)
        //                 .Sum(p => p.Price)
        //         );
        //     });

        var result = transactions
            .GroupBy(t => (t.PersonId, t.TransactionDate.Date))
            .Select(t => new QueryResult
            {
                Name = Data.People.Single(p => p.Id.Equals(t.Key.PersonId)).Name,
                Family = Data.People.Single(p => p.Id.Equals(t.Key.PersonId)).Family,
                StartDate = t.Key.Date,
                EndDate = transactions
                    .FirstOrDefault(tr => tr.TransactionDate.Date > t.Key.Date && tr.PersonId.Equals(t.Key.PersonId))
                    ?.TransactionDate.Date,
                Sum = t.Sum(p => p.Price),
                Total = transactions.Where(p => p.PersonId.Equals(t.Key.PersonId) && p.TransactionDate.Date <= t.Key.Date)
                    .Sum(p => p.Price)
            });

        return result;
    }
}
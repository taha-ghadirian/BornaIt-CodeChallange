SELECT 
    p.Name,
    p.Family,
    t.StartDate,
    t.EndDate,
    t.Sum,
    SUM(t.Sum) OVER (PARTITION BY t.PersonId ORDER BY t.StartDate, t.EndDate) AS Total
FROM (
    SELECT 
        PersonId,
        DATE(TransactionDate) AS StartDate,
        LEAD(DATE(TransactionDate), 1) OVER (PARTITION BY PersonId ORDER BY DATE(TransactionDate)) AS EndDate,
        SUM(Price) AS Sum
    FROM 
        Transactions
    GROUP BY 
        PersonId,
        DATE(TransactionDate)
) AS t
JOIN People p ON t.PersonId = p.PersonId;
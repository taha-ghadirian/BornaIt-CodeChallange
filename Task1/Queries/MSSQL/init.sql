------TABLE CREATION--------

-- Create the People table
CREATE TABLE People (
  PersonId int NOT NULL PRIMARY KEY,
  Name varchar(50)  NOT NULL,
  Family varchar(50) NOT NULL
);

-- Create the Transactions table
CREATE TABLE Transactions (
    TransactionId int NOT NULL PRIMARY KEY,
    PersonId int NOT NULL,
    TransactionDate DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    Price int NOT NULL,
    FOREIGN KEY (PersonId) REFERENCES People(PersonId)
);


------DATA INITIALIZATION--------
-- Insert data into the People table
INSERT INTO People (PersonId, Name, Family)
VALUES
    (1, 'Jane', 'Parker'),
    (2, 'Mike', 'Copper');

-- Insert data into the Transactions table
INSERT INTO Transactions (TransactionId, PersonId, TransactionDate, Price)
VALUES
    (1, 1, '2019-11-01 12:30:00', 100000),
    (2, 1, '2019-11-01 16:30:00', 200000),
    (3, 1, '2019-11-01 18:30:00', 50000),
    (4, 1, '2019-11-03 09:30:00', 300000),
    (5, 2, '2019-11-01 14:30:00', 100000),
    (6, 2, '2019-11-01 12:30:00', 20000);
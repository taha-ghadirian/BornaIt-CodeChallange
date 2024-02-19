## Task Description:

1. Please create Script to provide below tables:


| PersonId | Name | Family |
| ---------- | ------ | -------- |
| 1        | Jane | Parker |
| 2        | Mike | Copper |


| TransactionId | PersonId | TransactionDate  | Price   |
| --------------- | ---------- | ------------------ | --------- |
| 1             | 1        | 2019/11/01 12:30 | 100,000 |
| 2             | 1        | 2019/11/01 16:30 | 200,000 |
| 3             | 1        | 2019/11/01 18:30 | 50,000  |
| 4             | 1        | 2019/11/03 09:30 | 300,000 |
| 5             | 2        | 2019/11/01 14:30 | 100,000 |
| 6             | 2        | 2019/11/01 12:30 | 20,000  |

2. Please write one or more query to provide below result:


| Name | Family | StartDate  | EndDate    | Sum     | Total   |
| ------ | -------- | ------------ | ------------ | --------- | --------- |
| Jane | Parker | 2019/11/01 | 2019/11/03 | 350,000 | 350,000 |
| Jane | Parker | 2019/11/03 | NULL       | 300,000 | 650,000 |
| Mike | Copper | 2019/11/01 | NULL       | 120,000 | 120,000 |



Note:

* Column “EndDate” should be a first buy after that day
* Please consider “TransactionDate” is a datetime column and “StartDate”,”EndDate” are a date column.
* “Total” column representation a total Price of each person.

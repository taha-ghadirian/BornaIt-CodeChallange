## Devops docs:

### Quick guide:

* NOTE 1: Port 8081 should be open for `PhpMyAdmin`
* NOTE 2: First, copy `.env.example` to `.env`
* Run containers using: `docker compose up`
* Stop containers using: `docker compose down`
* Run PhpMyAdmin management server on: [localhost:8081](https://localhost:8081)

### Why using MariaDb/MySql and PhpMyAdmin?

This project needs a light database and easy acessable for testing, but also a full feature database that can easily migrated to another db.

So by using MariaDb, there is no need to install other local tools like `ssms` or `Sqlite Db Browser`, it can be managed using the web tool `phpMyAdmin` that can be deployed easily using docker.

And it's also have standard SQL structure so it wouldn't cause any conflict with other standard providers like `Ms Sql server`.
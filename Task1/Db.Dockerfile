FROM mariadb:10.6

COPY Queries/init.sql /docker-entrypoint-initdb.d/1-init.sql
drop database if exists ClickA_DB;

go
create database ClickA_DB;

go
use ClickA_DB;

go
create table Users (
id int,
username char(20)
)

go
insert into Users values
(1,'Testuser1'),
(2,'Testuser2'),
(3,'Testuser3'),
(4,'Testuser4'),
(5,'Testuser5'),
(6,'Testuser6'),
(7,'Testuser7'),
(8,'Testuser8'),
(9,'Testuser9'),
(10,'Testuser10');
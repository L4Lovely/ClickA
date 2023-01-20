if not exists (select * from sys.databases where name = 'ClickA_DB')
BEGIN
create DATABASE ClickA_DB;
end

go
use ClickA_DB;

drop TABLE if EXISTS  nutzer;

go
create table nutzer (
id int,
username char(20),
password char(20),
energy int,
clickpower int,
generator int,
transformer int,
clickbotfabrik int,
clickbot int
);

go
insert into nutzer values
(1,'Testuser1','test',0,0,0,0,0,0);
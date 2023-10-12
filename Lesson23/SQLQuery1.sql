create database Academy
use Academy
create table Student(
ID int Primary Key,
grade float,
fullName varchar(50),
birthDate date,
groupNo varchar(50)
)
drop table Student
insert into Student values (1,90,'Ehliman Muxtrali','01-01-2005','500.2E')
select * from Student

update Student
set fullName='Ehliman Muxtarli'
where ID=1
update Student
set grade=85.5
where ID=1
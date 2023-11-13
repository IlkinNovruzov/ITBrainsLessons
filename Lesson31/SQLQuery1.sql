create database Hotel
go 
use Hotel
create table RoomTypes(
TypeId int primary key identity(1,1),
TypeName varchar(50) not null,
)
create table Room(
RoomId int primary key identity(1,1),
RoomName varchar(50) not null,
RoomPrice float not null
)
create table Customer(
CustomerId int primary key identity(1,1),
CustomerName varchar(50) not null,
CustomerSurname varchar(50) not null,
)
create table Reservation(
ResereveId int primary key identity(1,1),
Customer int not null,
Room int not null
)
alter table Room
add RoomType int not null
 insert into RoomTypes values
 ('Single'),
 ('Double'),
 ('Family')
 select *from RoomTypes
 insert into Room values
 ('111',200,2)
 select *from Room






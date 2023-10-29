Create Database EmlakDb
go 
use EmlakDb
create table Users 
(
  UserId int Identity primary key, 
  UserName varchar (50) not null,
  Password varchar (50) not null,
  IsActive bit default 1
)
create table Daire 
(
  DaireId int identity primary key,
  DaireAd� varchar(50),
  DaireSay�s� int ,
)
create table M�steri
(
  M�steriId int identity primary key,
  M�steriAd� varchar(50),
  M�steriSoyad� varchar(50),
  M�steriTc int,
  M�steriMail varchar(50)
)
create table Odalar 
(
  OdaId int identity primary key,
  OdaAd� varchar(50),
  OdaSay�s� int
)
create table Semtler 
(
  SemtAd� varchar(50),
  SemtDurumu bit default 1
)
create table MalSahibi
(
  SahipId int identity primary key,
  SahipAd� varchar(50),
  SahipSoyad� varchar(50),
  SahipTc int,
  SahipEmail varchar(50)
)
create table Kiral�k
(
  Kiral�kId int identity primary key,
  KiraFiyat int,
  KiraTarihi date,
  Adres varchar(50)
)
create table Sat�l�k
(
  Sat�l�kId int identity primary key,
  Sat�l�kFiyat int,
  Adres varchar (50)
)

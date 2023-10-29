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
  DaireAdý varchar(50),
  DaireSayýsý int ,
)
create table Müsteri
(
  MüsteriId int identity primary key,
  MüsteriAdý varchar(50),
  MüsteriSoyadý varchar(50),
  MüsteriTc int,
  MüsteriMail varchar(50)
)
create table Odalar 
(
  OdaId int identity primary key,
  OdaAdý varchar(50),
  OdaSayýsý int
)
create table Semtler 
(
  SemtAdý varchar(50),
  SemtDurumu bit default 1
)
create table MalSahibi
(
  SahipId int identity primary key,
  SahipAdý varchar(50),
  SahipSoyadý varchar(50),
  SahipTc int,
  SahipEmail varchar(50)
)
create table Kiralýk
(
  KiralýkId int identity primary key,
  KiraFiyat int,
  KiraTarihi date,
  Adres varchar(50)
)
create table Satýlýk
(
  SatýlýkId int identity primary key,
  SatýlýkFiyat int,
  Adres varchar (50)
)

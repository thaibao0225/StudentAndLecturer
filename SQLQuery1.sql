create database StuAndLecManagement;

create table Student(
stdId varchar(8),
stdName varchar(50),
stdDoB date,
stdEmail varchar(50),
stdAddress varchar(100),
stdClass varchar(10),
);

create table Lecturer(
lecId varchar(8),
lecName varchar(50),
lecDoB date,
lecEmail varchar(50),
lecAddress varchar(100),
lecSubject varchar(50),
);

create table Grade(
gdId int,
gdStudent int,
gdLecturer int,
gdSubject int,
gdGrade1 int,
gdGrade2 int,
gdGrade3 int
);

create table Subjects(
sbjId varchar(4),
sbjName varchar(50),
sbjBranch varchar(50),
sbjClass int
);

Create table Accounts(
accId int,
accTypeId int,
accType varchar(10),
accUser varchar(20),
accPassword varchar(18),
);

create table Class(
claID varchar(8),
claRoom int,
);


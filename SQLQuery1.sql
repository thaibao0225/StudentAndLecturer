

CREATE DATABASE StuAndLecManagement;

CREATE TABLE Lecturer (
    lecId varchar(8) NOT NULL,
    lecName varchar(50) NOT NULL,
    lecDoB date,
	lecEmail varchar(50),
	lecAddress varchar(100),
	AccId int,
    PRIMARY KEY (lecId),
);

CREATE TABLE Student (
    stdId varchar(8) NOT NULL,
    stdName varchar(50) NOT NULL,
    stdDoB date,
	stdEmail varchar(50),
	stdAddress varchar(100),
	AccId int,
    PRIMARY KEY (stdId),
);

CREATE TABLE Adminn (
    adId varchar(8) NOT NULL,
    adName varchar(50) NOT NULL,
    adDoB date,
	adEmail varchar(50),
	adAddress varchar(100),
	AccId int,
    PRIMARY KEY (adId),
);

create table Register(
reId varchar(8),
stdId varchar(8),
lecId varchar(8),
sbjId varchar(4),
PRIMARY KEY (reId)
);

CREATE TABLE Accounts (
	AccId int not null,
    AccUser varchar(50) NOT NULL,
    AccPassWord varchar(50) NOT NULL,
    AccType  varchar(10),
    PRIMARY KEY (AccId),
);

CREATE TABLE Subjects (
	sbjId varchar(4),
	sbjName varchar(20),
	sbjBranch varchar(20),
    PRIMARY KEY (sbjId)
);


drop table Register
drop table Student
drop table Lecturer
drop table Adminn
drop table Accounts
drop table Subjects



ALTER TABLE Lecturer
ADD CONSTRAINT FK_LecturerAccounts
FOREIGN KEY (AccId) REFERENCES Accounts(AccId);

ALTER TABLE Student
ADD CONSTRAINT FK_StudentAccounts
FOREIGN KEY (AccId) REFERENCES Accounts(AccId);

ALTER TABLE Adminn
ADD CONSTRAINT FK_AdminAccounts
FOREIGN KEY (AccId) REFERENCES Accounts(AccId);

ALTER TABLE Register
ADD CONSTRAINT FK_SubjectsRegister
FOREIGN KEY (sbjId) REFERENCES Subjects(sbjId);

--				Lecturer -> Register
ALTER TABLE Register
ADD CONSTRAINT FK_StudentRegister
FOREIGN KEY (stdId) REFERENCES Student(stdId);

--				Lecturer -> Register
ALTER TABLE Register
ADD CONSTRAINT FK_LecturerRegister
FOREIGN KEY (lecId) REFERENCES Lecturer(lecId);


INSERT INTO Accounts (AccId, AccUser, AccPassWord, AccType)
VALUES 
('101','aaa','aaa','Admin'),
('102','lll','lll','Lecturer'),
('103','sss','sss','Student')
;

INSERT INTO Student (stdId, stdName, stdDoB, stdEmail, stdAddress, AccId)
VALUES ('GCS18008','Nguyen Van A','2000-01-01','nguyenvana@gmail.com','BC','103');

--				Lecturer
INSERT INTO Lecturer (lecId, lecName, lecDoB, lecEmail, lecAddress, AccId)
VALUES ('GTS10002','Tran Van A','2000-01-01','tranvana@gmail.com','BC','102');

INSERT INTO Adminn (adId, adName, adDoB, adEmail, adAddress, AccId)
VALUES ('GCS18004','Nguyen Van Tu','2000-01-01','nguyenvana@gmail.com','BS','101');


--				Register


--				Subject
INSERT INTO Subjects (sbjId, sbjName, sbjBranch)
VALUES ('1651', 'Advance Programming', 'IT'),
('1652', 'Project computing', 'IT'),
('1653', 'programing', 'IT');


select St.stdId,St.stdName, St.stdDoB, St.stdEmail,St.stdAddress, A.AccUser , A.AccPassWord, St.AccId from Student St left join Accounts A on St.AccID = A.AccId where A.AccUser = 'sss'and A.AccPassWord ='sss'
UPDATE Accounts SET AccUser = @UserName, AccPassWord = @Password WHERE AccId = @AccID
select L.lecId[ID],L.lecName[Name], L.lecDoB[Day of bird], L.lecEmail[Email], L.lecAddress[Address], A.AccUser[User name] , A.AccPassWord[Password] from Lecturer L left join Accounts A on L.accID = A.AccId
UPDATE Accounts SET AccUser = 'qqu',AccPassWord = 'qqu' WHERE AccId ='10'
insert into Register(reId, lecId, sbjId) values ('444' , 'GTS10002', '1651');
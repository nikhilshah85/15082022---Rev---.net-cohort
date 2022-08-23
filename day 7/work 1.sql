create database bankingDB

create table branchInfo
(
	branchNo int,
	branchName varchar(20),
	branchEmail varchar(60),
	branchContact bigint,
	branchIsActive bit
)


alter table branchInfo add branchManager varchar(20)
alter table branchInfo alter column branchName varchar(40)
alter table branchInfo drop column branchIsActive

drop table branchInfo

insert into BRANCHINFO values(101,'Tiffies Texas','tiffies@citibank.com',789456326,'Mark')
insert into BRANCHINFO values(102,'Cal Off road','caloffroad@citibank.com',3265659,'Steve')
insert into BRANCHINFO values(103,'Next street vagas','nxtstreet@citibank.com',865656,'Adam')
insert into BRANCHINFO values(104,'NYK Corner','nykcorner@citibank.com',554545,'Paul')
insert into BRANCHINFO values(105,'Street Offshore','streetoffshore@citibank.com',454546,'Marie')
insert into BRANCHINFO values(106,'May chamber','maychamber@citibank.com',4554,'Mriaha')



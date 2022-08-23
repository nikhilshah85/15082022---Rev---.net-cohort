--------------------------------------------------------------------------------------------------------
		-- DDL Commands - create, alter, drop
--------------------------------------------------------------------------------------------------------
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


create table accountsInfo
(
	accNo int,
	accName varchar(20),
	accType varchar(20),
	accBalance int,
	accIsActive bit
)
--------------------------------------------------------------------------------------------------------
			--DML Commands Insert, update and delete
--------------------------------------------------------------------------------------------------------
insert into BRANCHINFO values(101,'Tiffies Texas','tiffies@citibank.com',789456326,'Mark')
insert into BRANCHINFO values(102,'Cal Off road','caloffroad@citibank.com',3265659,'Steve')
insert into BRANCHINFO values(103,'Next street vagas','nxtstreet@citibank.com',865656,'Adam')
insert into BRANCHINFO values(104,'NYK Corner','nykcorner@citibank.com',554545,'Paul')
insert into BRANCHINFO values(105,'Street Offshore','streetoffshore@citibank.com',454546,'Marie')
insert into BRANCHINFO values(106,'May chamber','maychamber@citibank.com',4554,'Mriaha')

use bankingDB
-------------------------------------------------------------------------------

insert into accountsInfo values(1,'Nikhil','Savings',5000,1)
insert into accountsInfo values(2,'Mary','Checking',5000,1)
insert into accountsInfo values(3,'Evan','Loan',5000,0)
insert into accountsInfo values(4,'John','Checking',5000,1)
insert into accountsInfo values(5,'Rayder','Loan',5000,1)
insert into accountsInfo values(6,'Marshall','Savings',5000,1)
insert into accountsInfo values(7,'Katherine','Savings',5000,0)
insert into accountsInfo values(8,'Paris','Savings',5000,1)
insert into accountsInfo values(9,'Jennifer','Savings',5000,1)
insert into accountsInfo values(10,'Britney','Checking',5000,0)
insert into accountsInfo values(11,'Madona','Loan',5000,1)
insert into accountsInfo values(12,'Helle','Savings',5000,1)
insert into accountsInfo values(13,'Starius','Loan',5000,1)
insert into accountsInfo values(14,'Nichole','Checking',5000,0)



select * from accountsInfo
select * from branchinfo

update accountsInfo set accBalance = accBalance + 1000
update accountsInfo set accIsActive = 1 where accNo = 3
update accountsInfo set accBalance = 8000, accName= 'Mr. ' + accName where accNo = 1

--be careful with below query, it will delete all the records from your table
--delete from accountsInfo

delete from accountsInfo where accIsActive = 0
delete from accountsInfo where accNo = 9

---------------------------------------------------------------







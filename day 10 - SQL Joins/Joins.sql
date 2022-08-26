

select * from employeeInfo

select * from LoginInfo



create table branchInfo
(
	branchNo int primary key,
	branchName varchar(20),
	branchLocation varchar(20),
	branchManager varchar(20),
	branchEmail varchar(20),
	branchContactNo varchar(20)
)
insert into branchInfo values(10,'Titoos Lane','Texas','Alphonso','tittos@citi.com','123-456-789')
insert into branchInfo values(20,'Square Yard','California','Micheal','squareyard@citi.com','896-456-789')
insert into branchInfo values(30,'Milton Stake','New York','Sumacher','milton@citi.com','369-456-789')
insert into branchInfo values(40,'Marys Street','Las Vegas','Henry Ford','mary@citi.com','789-456-789')
create table accountsInfo
(
	accNo int primary key,
	accName varchar(20),
	accType varchar(20),
	accBalance int,
	accIsActive bit,
	accBranch int,
	constraint fk_accBranch foreign key(accBranch) references branchInfo
)
insert into accountsInfo values(1,'Steven','Savings',4000,1,30)
insert into accountsInfo values(2,'Klara','Checking',30000,0,10)
insert into accountsInfo values(3,'Mozes','Loan',5000,1,10)
insert into accountsInfo values(4,'Rabada','Savings',2500,1,30)
insert into accountsInfo(accNo,accName,accType,accBalance,accIsActive) values (5,'Michelle','Loan',4000,1)
insert into accountsInfo(accNo,accName,accType,accBalance,accIsActive) values (6,'Mariah','Savings',4000,1)
-------------JOINS in SQL -------------
--Joins are used to pull realated data from 2 or more tables
--There are different types of Joins
	--Equi Join - inner join - pulls the equal matching records from both the tables
	--Left Join - get all the records from left table and only matching records from the right table
	--Right Join
	--Full Join
	--Null Join

	--Equi Join
	--Equi Join with get all the columns
	select * from accountsInfo join branchInfo
		on accountsInfo.accBranch = branchInfo.branchNo

	--Equi Join with get your wanted columns
	select accNo,accName, branchInfo.branchName, branchInfo.branchLocation, branchInfo.branchNo
			from accountsInfo join branchInfo
			on accountsInfo.accBranch = branchInfo.branchNo
	--Equi Join with where clause
	select accNo,accName, branchInfo.branchName, branchInfo.branchLocation, branchInfo.branchNo
			from accountsInfo join branchInfo
			on accountsInfo.accBranch = branchInfo.branchNo
			where branchNo = 10
	--Equi Join with order by clause
		select accNo,accName, branchInfo.branchName, branchInfo.branchLocation, branchInfo.branchNo
			from accountsInfo join branchInfo
			on accountsInfo.accBranch = branchInfo.branchNo
			order by branchNo





		------------Left Join---------------------------------------------------------------------------------------------
select * from accountsInfo left join branchInfo
on accountsInfo.accBranch = branchInfo.branchNo		

select * from accountsInfo left join branchInfo
on accountsInfo.accBranch = branchInfo.branchNo
where accIsActive = 1

select * from accountsInfo left join branchInfo
on accountsInfo.accBranch = branchInfo.branchNo
order by accBalance desc
-------------------- Right---------------------------------------------------------------------------------------------
select * from accountsInfo right join branchInfo
on accountsInfo.accBranch = branchInfo.branchNo

select * from accountsInfo right join branchInfo
on accountsInfo.accBranch = branchInfo.branchNo	order by accNo desc
--------------------Full----------------------------------------------------------------------------------------------------
select * from accountsInfo full join branchInfo
on accountsInfo.accBranch = branchInfo.branchNo
--------------------Null Join -- show only non matching records---------------------------------------------------------------------------------------------
select * from accountsInfo full join branchInfo
on accountsInfo.accBranch = branchInfo.branchNo
where accountsInfo.accBranch is null





	select * from accountsInfo
	 ---how can we know how much of total accbalance is there in every branch

	select branchInfo.branchLocation as [Branch Location],
			sum(accountsInfo.accBalance) as [Total Balance]
			from accountsInfo join branchInfo
			on accountsInfo.accBranch = branchInfo.branchNo
			group by branchInfo.branchLocation

	select branchInfo.branchLocation as [Branch Location],
			sum(accountsInfo.accBalance) as [Total Balance]
			from accountsInfo left join branchInfo
			on accountsInfo.accBranch = branchInfo.branchNo
			group by branchInfo.branchLocation

	--with isNull operator	
	select ISNULL(branchInfo.branchLocation,'Others') as [Branch Location],
			sum(accountsInfo.accBalance) as [Total Balance]
			from accountsInfo left join branchInfo
			on accountsInfo.accBranch = branchInfo.branchNo
			group by branchInfo.branchLocation
	
	select ISNULL(branchInfo.branchLocation,'Others') as [Branch Location],
		ISNULL(sum(accountsInfo.accBalance),0) as [Total Balance]
			from accountsInfo right join branchInfo
			on accountsInfo.accBranch = branchInfo.branchNo
			group by branchInfo.branchLocation
---------------------------------------------------------------------------------------------------------------------------------

---give me the information of a person who has the highest balance ?


	select * from accountsInfo join branchInfo
		on accountsInfo.accBranch = branchInfo.branchNo
		where accBalance = (select min(accBalance) from accountsInfo)
		


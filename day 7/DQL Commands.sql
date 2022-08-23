use bankingDB

--select with all the columns (*)
select * from accountsInfo

--select with limited columns
select accNo,accName, accType from accountsInfo

--select with column alias
select accNo as [Account Number],accName as Name, accType as [Account Type] from accountsInfo

--select with distinct  (unique values from column)
select accType from accountsInfo
select distinct accType as [Account Types] from accountsInfo


--select with where clause
select * from accountsInfo
select * from accountsInfo where accNo=4
select * from accountsInfo where accType='Savings'
select * from accountsInfo where accType = 'Savings' and accbalance > 7000
select accNo as [Account Number],
		accName as [Account Holder],
		accType as Type
		from accountsInfo where accType='Loan' or accBalance = 8000

--select with wild card operator (like, %, _)

select * from accountsInfo where accName like 'E%'  -- when the first character in name starts with E
select * from accountsInfo where accName like '%l'
select * from accountsInfo where accName like '____N%'
select * from accountsInfo where accName like '%k___'
select * from accountsInfo where accName like '%ik%'
select * from accountsInfo where accName like '%ar%'

--select with orderby clause (sort)
select * from accountsInfo
select * from accountsInfo order by accName
select * from accountsInfo order by accType
select * from accountsInfo order by accType desc

--where clause and order by clause
select * from accountsinfo where accNo > 4 order by accType


--select with aggregate functions
--count
--sum
--min
--max
--avg

select count(*) as [Total Accounts] from accountsinfo

select * from accountsinfo

select sum(accBalance) as [Total Amount with bank] from accountsInfo

select min(accBalance) as [Minimum Balance] from accountsinfo


select max(accBalance) as [Maximum Balance] from accountsinfo


select avg(accBalance) as [Average Balance] from accountsinfo

--select with group by clause (grouping)
select accType,count(*) as Total from accountsinfo 
	group by accType













select * from empInfo
insert into empInfo values(3,'Rickishi','Sales',6200,20,'123-456-789','ricki@somewhere.com')
insert into empInfo values(4,'John','HR',6200,30,'123-456-739','john@somewhere.com')
insert into empInfo values(5,'Mariah','Developer',6200,10,'123-556-789','mariah@somewhere.com')
insert into empInfo values(6,'Britney','Developer',6200,40,'123-486-789','britney@somewhere.com')
insert into empInfo values(7,'Jeniffer','HR',6200,20,'123-456-899','jlo@somewhere.com')
insert into empInfo values(8,'Paris Hilton','Sales',6200,30,'568-456-789','paris@somewhere.com')
insert into empInfo values(9,'Weili','Sales',6200,10,'123-456-639','weili@somewhere.com')
insert into empInfo values(10,'Jason Voorhees','Sales',6200,20,'555-456-789','jason@somewhere.com')
insert into empInfo values(11,'Shrek','Sales',6200,30,'123-456-555','shrek@somewhere.com')
insert into empInfo values(12,'Drew berry','HR',6200,30,'123-456-369','drew@somewhere.com')
insert into empInfo values(13,'Helle Belly','Sales',6200,40,'123-753-789','helleb@somewhere.com')
insert into empInfo values(14,'Morgan Stanley','Developer',6200,40,'357-456-789','morgan@somewhere.com')
insert into empInfo values(15,'Arthur Roman','Developer',6200,40,'123-888-789','arthur@somewhere.com')

insert into empInfo values(16,'Monica','Advt',6200,40,'123-888-089','monica@somewhere.com')
insert into empInfo values(17,'Chrish','Advt',6200,40,'123-888-289','chrish@somewhere.com')
insert into empInfo values(18,'Steven','Advt',6200,40,'123-888-389','steven@somewhere.com')
insert into empInfo values(19,'Katherine','Advt',6200,40,'123-888-489','katherine@somewhere.com')


insert into empInfo values(20,'KATE winsLEt','HR',6200,40,'123-888-589','kate@somewhere.com')







select count(*)  as [Total Employee]from empInfo
select count(*) as Sales from empInfo where empDesignation='Sales'
select count(*) as HR from empInfo where empDesignation='HR'
select count(*) as Developer from empInfo where empDesignation='Developer'

--if you have 20 or more empDesignation, you will have to run the query for 20 times
--also you have to remember 20 values

--thus we have group by clause
select empDesignation as Designation, COUNT(*) As total from empInfo
	group by empDesignation order by total desc


	select min(empSalary) as 'Minimum Salary' from empInfo
	
	select max(empSalary) as 'Minimum Salary' from empInfo

	select avg(empSalary) as 'Average' from empInfo

	select sum(empSalary) as 'Total Salary Paid' from empInfo 

	
	select empDesignation,sum(empSalary) as 'Salary Paid' from empInfo group by empDesignation










	select empName from empInfo
	select empName,upper(empName) as Name from empinfo
	select empName, lower(empName) as Name from empInfo
	select empName,len(empName) as size from empInfo
	select empName,upper(concat(empName,' Is in ',empDesignation,' working in Dept No ',empDept)) as Info from empInfo
	select empName,upper( left(empName,2)) from empInfo
	select empName,upper(right(empName,3)) from empInfo

	update empInfo set empName =concat(upper(left(empName,1)),lower(substring(empName,2,len(empName) -1))) where empNo = 20
	delete from empInfo where empNo =20






	select getdate()


	select GETDATE()

select DATEPART(WEEKDAY,getdate())
select DATEPART(ISOWK,getdate())
select DATEPART(yyyy,getdate())

select DATEADD(month,5,getdate())

select DATEADD(DAY,5,getdate())

select DATEADD(WEEK,10,'08-15-2022')

select DATEDIFF(day,'08-15-2022',getdate())












	select substring(empName,2,len(empName) -1) from empInfo












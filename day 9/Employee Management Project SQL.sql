create database EmployeeManagementDB

use EmployeeManagementDB

create table LoginInfo
(
	empNo int,
	userName varchar(20),
	password varchar(20),
	constraint fk_empNo foreign key(empNo) references employeeInfo,
	constraint unk_userName unique(userName)
)

insert into LoginInfo values(1,'rickey1234','rick@123456')
insert into LoginInfo values(2,'martin5632','martin@123456')
insert into LoginInfo values(3,'enrique8965','enriq@123456')
insert into LoginInfo values(4,'ige963','ige@123456')
insert into LoginInfo values(5,'maddoo5632','madd@123456')
insert into LoginInfo values(6,'admin','addmini@123456')


create table employeeInfo
(
	empNo int primary key,
	empName varchar(20) not null,
	empDesignation varchar(20) not null,
	empSalary int not null,
	empIsPermenant bit,
	empDept int,
	constraint chk_empDesignation check (empDesignation in ('Developer','Manager','HR','Sales')),
	constraint chk_empSalary check (empSalary between 8000 and 25000)	
)
insert into employeeInfo values(1,'Ricky','Developer',9000,1,10)
insert into employeeInfo values(2,'Martin','Manager',9000,1,10)
insert into employeeInfo values(3,'Enrique','Sales',9000,1,10)
insert into employeeInfo values(4,'Iglasieus','Developer',9000,1,10)
insert into employeeInfo values(5,'Madonna','HR',9000,1,10)
insert into employeeInfo values(6,'Admin','Sales',8989,1,10)


select * from employeeInfo
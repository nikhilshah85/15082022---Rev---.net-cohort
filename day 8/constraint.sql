	create table deptInfo 
	(
		deptNo int,
		deptName varchar(20),
		deptLocation varchar(20),
		deptHead varchar(20)
	)
	insert into deptInfo values(1,'HR','Texas','Alex')
	insert into deptInfo values(1,'Football','Mumbai','a')
	drop table deptInfo



	create table deptInfo
	(
		deptNo int,
		deptName varchar(20) not null,
		deptLocation varchar(20),
		deptHead varchar(20),

		constraint pk_deptNo primary key(deptNo),
		constraint chk_deptLocation check ( deptLocation in ('Texas','California','New York')),
		constraint chk_deptHead check (len(deptHead) >= 3)
	)

	insert into deptInfo values(10,'HR','Texas','Annet')
	insert into deptInfo values(20,'IT','New York','Mary')
	insert into deptInfo values(30,'Sales','California','Peter')
	insert into deptInfo(deptNo,deptName,deptLocation, deptHead) values (40,'Advt','Texas','Miss May')

	select * from deptInfo

	------------------------------------------------------------------------------------------------------------------


	create table empInfo
	(
		empNo int,
		empName varchar(20) not null,
		empDesignation varchar(20) not null,
		empSalary int not null,
		empDept int,
		empSSN varchar(11) not null,
		empEmail varchar(40),

		constraint pk_empNo primary key(empNo),
		constraint chk_empSalary check(empSalary between 500 and 15000),
		constraint fk_empDept foreign key(empDept) references deptInfo,
		constraint unk_empSSN unique(empSSN),
		constraint unk_empEmail unique(empEmail),
		constraint chk_empEmail check (right(empEmail,4) = '.com')
		)

		alter table empInfo add constraint chk_empSSN check(len(empSSN) = 11)

		insert into empInfo values(1,'Peter','Sales',6000,30,'123-4567-23','peter@spiderman.com')		
		insert into empInfo values(2,'Mary Jane','HR',14000,10,'123-4567-63','mary@spiderman.com')



























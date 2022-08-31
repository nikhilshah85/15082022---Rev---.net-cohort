	create database myshoppingDBAPI
	
	use myshoppingDBAPI

	create table products
	(
		pId int primary key,
		pName varchar(20),
		pCategoty varchar(20),
		pPrice int,
		pIsInStock bit
	)

	insert into products values(1, 'Pepsi','Cold-Drink',1,1)
	insert into products values(2, 'IPhone','Electronics',1750,1)
	insert into products values(3, 'Air-pods','Electronics',800,0)
	insert into products values(4, 'Fossil Q','watch',2400,1)
	insert into products values(5, 'Trailhawk','SUV',40000,1)


	select * from products




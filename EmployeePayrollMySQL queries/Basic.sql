use employeepayroll;


create table employeepayroll
(
	EmployeeId int AUTO_INCREMENT PRIMARY KEY,
	EmployeeName varchar(255) not null,
    Salary int,   
	DA int,
	HRA int,
	Bonus int
	
);

SELECT * FROM employeepayroll;

SELECT * FROM employeepayroll WHERE Salary>12000;


Use employeepayroll;

create table EmployeeDemo(
 id int,
 name varchar(255),
 roll int
 );
 
 select * from EmployeeDemo;
 
 INSERT INTO EmployeeDemo(id,name,roll)employeedemoemployeedemoemployeepayrollemployeedemoemployeedemo
 values(1,'pankaj',1);
 
 SELECT * FROM employeepayroll INNER JOIN EmployeeDemo on employeepayroll.EmployeeId=EmployeeDemo.id;
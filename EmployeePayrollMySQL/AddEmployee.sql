CREATE DEFINER=`root`@`localhost` PROCEDURE `AddEmployee`(
	_employeeName varchar(255),
    _salary int,   
	_da int,
	_hra int,
	_bonus int
	 
)
BEGIN  
    INSERT INTO employeepayroll(EmployeeName,Salary,DA,HRA,Bonus)
VALUES (_employeeName,_salary,_da,_hra,_bonus);
END
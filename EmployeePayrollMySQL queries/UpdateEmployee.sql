CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateEmployee`(
	_employeeName varchar(255),
    _salary int,   
	_da int,
	_hra int,
	_bonus int,
    _employeeId int
	 
)
BEGIN
   Update employeepayroll set EmployeeName = _employeeName, 
					Salary = _salary, 
					DA = _da, 
					HRA= _hra,
					Bonus = _bonus
					
				where 
					EmployeeId = _employeeId;
END
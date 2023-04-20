CREATE DEFINER=`root`@`localhost` PROCEDURE `GetemployeeByemployeeId`(
   _employeeId int
)
BEGIN
	SELECT * FROM employeepayroll WHERE EmployeeId = _employeeId;
END
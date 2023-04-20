CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAllEmployees`()
BEGIN
	SELECT * FROM employeepayroll;
END
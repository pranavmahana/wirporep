CREATE TABLE Employees(
    EmployeeID INT PRIMARY KEY,
	FirtName VARCHAR(50),
	LastName VARCHAR(50),
	Department VARCHAR(50),
	Salary DECIMAL(10,2),
	Hiredate DATE
	);

INSERT INTO Employees(employeeid, FirtName, lastname, department, salary, hiredate)
VALUES
(1, 'KEERTHI', 'BUSA', 'IT', 50000,'2024-06-16'),
(2, 'HARSHIKA', 'CHAVVA', 'FINANCE', 60000, '2024-12-12'),
(3, 'HARSITHA', 'BANDHAM', 'SALES', 45000, '2024-10-10'),
(4, 'DEEPIKA', 'SEEPATHI', 'IT', 60000, '2024-08-10'),
(5, 'RAMYA', 'ANE', 'MARKETING', 55000, '2024-11-11');

SELECT * FROM EMPLOYEES;

UPDATE EMPLOYEES SET SALARY = 70000 WHERE EMPLOYEEID = 1;

DELETE FROM EMPLOYEES WHERE  LASTNAME = 'SEEPATHI';
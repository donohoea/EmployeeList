
SELECT [State], COUNT(EmployeeID) as NumberOfEmployees
FROM dbo.Employees
GROUP BY [State];


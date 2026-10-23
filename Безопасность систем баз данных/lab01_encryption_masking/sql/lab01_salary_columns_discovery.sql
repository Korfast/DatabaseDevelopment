USE AdventureWorks2017;
GO

SELECT
    s.name AS schema_name,
    t.name AS table_name,
    c.name AS column_name,
    ty.name AS data_type,
    c.max_length,
    c.precision,
    c.scale,
    c.is_nullable
FROM sys.columns AS c
INNER JOIN sys.tables AS t
    ON c.object_id = t.object_id
INNER JOIN sys.schemas AS s
    ON t.schema_id = s.schema_id
INNER JOIN sys.types AS ty
    ON c.user_type_id = ty.user_type_id
WHERE
    c.name LIKE '%Rate%'
    OR c.name LIKE '%Pay%'
    OR c.name LIKE '%Salary%'
    OR c.name LIKE '%Wage%'
ORDER BY
    s.name,
    t.name,
    c.column_id;
GO

SELECT TOP (10)
    BusinessEntityID,
    RateChangeDate,
    Rate,
    PayFrequency,
    ModifiedDate
FROM HumanResources.EmployeePayHistory
ORDER BY BusinessEntityID, RateChangeDate;
GO

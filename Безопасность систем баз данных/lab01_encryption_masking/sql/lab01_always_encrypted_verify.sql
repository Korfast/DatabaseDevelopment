USE AdventureWorks2017;
GO

SELECT TOP (10)
    BusinessEntityID,
    RateChangeDate,
    Rate,
    PayFrequency
FROM HumanResources.EmployeePayHistory
ORDER BY BusinessEntityID, RateChangeDate;
GO

SELECT
    s.name AS schema_name,
    t.name AS table_name,
    c.name AS column_name,
    c.encryption_type_desc,
    c.encryption_algorithm_name,
    cek.name AS column_encryption_key_name
FROM sys.columns AS c
INNER JOIN sys.tables AS t
    ON c.object_id = t.object_id
INNER JOIN sys.schemas AS s
    ON t.schema_id = s.schema_id
LEFT JOIN sys.column_encryption_keys AS cek
    ON c.column_encryption_key_id = cek.column_encryption_key_id
WHERE t.object_id = OBJECT_ID('HumanResources.EmployeePayHistory')
ORDER BY c.column_id;
GO

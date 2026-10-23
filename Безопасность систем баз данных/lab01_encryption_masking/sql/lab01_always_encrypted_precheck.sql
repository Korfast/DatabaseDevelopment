USE AdventureWorks2017;
GO

SELECT
    cc.name AS check_constraint_name,
    OBJECT_SCHEMA_NAME(cc.parent_object_id) AS schema_name,
    OBJECT_NAME(cc.parent_object_id) AS table_name,
    COL_NAME(cc.parent_object_id, c.parent_column_id) AS column_name,
    cc.definition
FROM sys.check_constraints AS cc
LEFT JOIN sys.check_constraints AS c
    ON cc.object_id = c.object_id
WHERE cc.parent_object_id = OBJECT_ID('HumanResources.EmployeePayHistory')
ORDER BY cc.name;
GO

SELECT
    i.name AS index_name,
    i.is_primary_key,
    i.is_unique,
    c.name AS column_name,
    ic.key_ordinal,
    ic.is_included_column
FROM sys.indexes AS i
INNER JOIN sys.index_columns AS ic
    ON i.object_id = ic.object_id
    AND i.index_id = ic.index_id
INNER JOIN sys.columns AS c
    ON ic.object_id = c.object_id
    AND ic.column_id = c.column_id
WHERE i.object_id = OBJECT_ID('HumanResources.EmployeePayHistory')
ORDER BY i.name, ic.key_ordinal, c.name;
GO

SELECT TOP (10)
    BusinessEntityID,
    RateChangeDate,
    Rate,
    PayFrequency
FROM HumanResources.EmployeePayHistory
ORDER BY BusinessEntityID, RateChangeDate;
GO

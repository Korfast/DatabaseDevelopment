USE AdventureWorks2017;
GO

ALTER TABLE HumanResources.EmployeePayHistory
DROP CONSTRAINT CK_EmployeePayHistory_Rate;
GO

SELECT
    cc.name AS check_constraint_name,
    COL_NAME(cc.parent_object_id, c.parent_column_id) AS column_name,
    cc.definition
FROM sys.check_constraints AS cc
LEFT JOIN sys.check_constraints AS c
    ON cc.object_id = c.object_id
WHERE cc.parent_object_id = OBJECT_ID('HumanResources.EmployeePayHistory')
ORDER BY cc.name;
GO

USE AdventureWorks2017;
GO

-- 1. Recreate a demo table for dynamic data masking.
DROP TABLE IF EXISTS HumanResources.EmployeePayHistoryMaskingDemo;
GO

CREATE TABLE HumanResources.EmployeePayHistoryMaskingDemo
(
    DemoID int IDENTITY(1,1) NOT NULL
        CONSTRAINT PK_EmployeePayHistoryMaskingDemo PRIMARY KEY,
    BusinessEntityID int MASKED WITH (FUNCTION = 'random(10000, 99999)') NOT NULL,
    RateChangeDate datetime NOT NULL,
    Rate money NOT NULL,
    PayFrequency tinyint NOT NULL,
    ModifiedDate datetime NOT NULL
);
GO

INSERT INTO HumanResources.EmployeePayHistoryMaskingDemo
(
    BusinessEntityID,
    RateChangeDate,
    Rate,
    PayFrequency,
    ModifiedDate
)
SELECT TOP (20)
    BusinessEntityID,
    RateChangeDate,
    CONVERT(money, 10.00 + ROW_NUMBER() OVER (ORDER BY BusinessEntityID, RateChangeDate) * 7.25) AS Rate,
    PayFrequency,
    ModifiedDate
FROM HumanResources.EmployeePayHistory
ORDER BY BusinessEntityID, RateChangeDate;
GO

-- 2. Create an analyst user without UNMASK permission.
DROP USER IF EXISTS Lab01SalaryAnalyst;
GO

CREATE USER Lab01SalaryAnalyst WITHOUT LOGIN;
GO

GRANT SELECT ON HumanResources.EmployeePayHistoryMaskingDemo TO Lab01SalaryAnalyst;
GO

-- 3. Administrator sees exact employee identifiers and exact salary rates.
SELECT TOP (10)
    DemoID,
    BusinessEntityID,
    RateChangeDate,
    Rate,
    PayFrequency
FROM HumanResources.EmployeePayHistoryMaskingDemo
ORDER BY DemoID;
GO

-- 4. Analyst sees exact salary rates but masked employee identifiers.
EXECUTE AS USER = 'Lab01SalaryAnalyst';
GO

SELECT TOP (10)
    DemoID,
    BusinessEntityID,
    RateChangeDate,
    Rate,
    PayFrequency
FROM HumanResources.EmployeePayHistoryMaskingDemo
ORDER BY DemoID;
GO

REVERT;
GO

-- 5. Metadata check for the configured mask.
SELECT
    OBJECT_SCHEMA_NAME(mc.object_id) AS schema_name,
    OBJECT_NAME(mc.object_id) AS table_name,
    c.name AS column_name,
    mc.masking_function
FROM sys.masked_columns AS mc
INNER JOIN sys.columns AS c
    ON mc.object_id = c.object_id
    AND mc.column_id = c.column_id
WHERE mc.object_id = OBJECT_ID('HumanResources.EmployeePayHistoryMaskingDemo')
ORDER BY c.column_id;
GO

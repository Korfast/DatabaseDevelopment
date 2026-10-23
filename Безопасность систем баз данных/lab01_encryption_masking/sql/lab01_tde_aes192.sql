USE master;
GO

-- 1. Create a master key in the master database.
IF NOT EXISTS (
    SELECT 1
    FROM sys.symmetric_keys
    WHERE name = '##MS_DatabaseMasterKey##'
)
BEGIN
    CREATE MASTER KEY ENCRYPTION BY PASSWORD = 'DBSecurity_Lab01_MasterKey_2026!';
END;
GO

-- 2. Create a certificate that will protect the database encryption key.
IF NOT EXISTS (
    SELECT 1
    FROM sys.certificates
    WHERE name = 'DBSecurity_Lab01_TDE_Certificate'
)
BEGIN
    CREATE CERTIFICATE DBSecurity_Lab01_TDE_Certificate
    WITH SUBJECT = 'TDE certificate for AdventureWorks2017 lab01';
END;
GO

-- 2.1. Back up the certificate and private key.
-- Change the paths if C:\DBSecurity\Backups does not exist in the VM.
BACKUP CERTIFICATE DBSecurity_Lab01_TDE_Certificate
TO FILE = 'C:\DBSecurity\Backups\DBSecurity_Lab01_TDE_Certificate.cer'
WITH PRIVATE KEY (
    FILE = 'C:\DBSecurity\Backups\DBSecurity_Lab01_TDE_Certificate_PrivateKey.pvk',
    ENCRYPTION BY PASSWORD = 'DBSecurity_Lab01_CertificateBackup_2026!'
);
GO

-- 3. Create the database encryption key in AdventureWorks2017.
USE AdventureWorks2017;
GO

IF NOT EXISTS (
    SELECT 1
    FROM sys.dm_database_encryption_keys
    WHERE database_id = DB_ID('AdventureWorks2017')
)
BEGIN
    CREATE DATABASE ENCRYPTION KEY
    WITH ALGORITHM = AES_192
    ENCRYPTION BY SERVER CERTIFICATE DBSecurity_Lab01_TDE_Certificate;
END;
GO

-- 4. Enable encryption for the database.
ALTER DATABASE AdventureWorks2017
SET ENCRYPTION ON;
GO

-- 5. Check encryption status.
USE master;
GO

SELECT
    DB_NAME(database_id) AS database_name,
    encryption_state,
    CASE encryption_state
        WHEN 0 THEN 'No database encryption key present'
        WHEN 1 THEN 'Unencrypted'
        WHEN 2 THEN 'Encryption in progress'
        WHEN 3 THEN 'Encrypted'
        WHEN 4 THEN 'Key change in progress'
        WHEN 5 THEN 'Decryption in progress'
        WHEN 6 THEN 'Protection change in progress'
        ELSE 'Unknown'
    END AS encryption_state_description,
    percent_complete,
    key_algorithm,
    key_length
FROM sys.dm_database_encryption_keys
WHERE database_id = DB_ID('AdventureWorks2017');
GO

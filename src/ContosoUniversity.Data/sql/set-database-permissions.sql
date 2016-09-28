IF NOT EXISTS (
	SELECT name 
	FROM [sys].[database_principals ]
	WHERE name = 'ContosoUniversitySite')
BEGIN
	CREATE USER ContosoUniversitySite FROM LOGIN ContosoUniversitySite;
END

ALTER ROLE db_datareader ADD MEMBER ContosoUniversitySite;
ALTER ROLE db_datawriter ADD MEMBER ContosoUniversitySite;
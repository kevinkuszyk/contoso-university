IF NOT EXISTS (SELECT name FROM master.sys.databases WHERE name = N'ContosoUniversity')
BEGIN   
	CREATE DATABASE ContosoUniversity COLLATE SQL_Latin1_General_CP1_CI_AS
	(
		EDITION = 'Basic',
		SERVICE_OBJECTIVE='Basic',
		MAXSIZE = 1 GB
	)
END
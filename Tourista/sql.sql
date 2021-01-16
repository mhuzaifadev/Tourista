USE [tourista]
CREATE LOGIN [Tourista] WITH PASSWORD=N'PWDTOURISTA',
		DEFAULT_DATABASE=[tourista], 
		DEFAULT_LANGUAGE=[us_english], 
		CHECK_EXPIRATION=OFF, 
		CHECK_POLICY=OFF
GO
GO
CREATE USER [Tourista] FOR LOGIN [Tourista] WITH DEFAULT_SCHEMA=[Tourista]
GO
EXEC sp_addrolemember N'db_owner', N'Tourista'
EXEC sp_addrolemember N'db_datareader', N'Tourista'
EXEC sp_addrolemember N'db_datawriter', N'Tourista'
GO
CREATE TABLE [dbo].[books]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Author] VARCHAR(50) NULL, 
    [LaunchDate] DATE NOT NULL, 
    [Price] DECIMAL(18, 2) NOT NULL, 
    [Title] VARCHAR(50) NULL
)
USE [Curso]

 CREATE TABLE [Student](
    [id] INT NOT NULL UNIQUE,
    [Name] NVARCHAR(80) NOT NULL,
    [Email] NVARCHAR(180) NOT NULL UNIQUE,
    [Birthdate] DATETIME NULL,
    [Active] BIT NOT NULL DEFAULT(0),
 )
 GO
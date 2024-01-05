USE [Curso]

DROP TABLE [Student]

 CREATE TABLE [Student](
    [Id] INT NOT NULL,
    [Name] NVARCHAR(80) NOT NULL,
    [Email] NVARCHAR(180) NOT NULL UNIQUE,
    [Birthdate] DATETIME NULL,
    [Active] BIT NOT NULL DEFAULT(0),

    CONSTRAINT [PK_Student] PRIMARY KEY([Id]),
    CONSTRAINT [UQ_Student_Email] UNIQUE([Email]),
 )
 GO

 ALTER TABLE[Student]
    DROP CONSTRAINT [PK_Student]
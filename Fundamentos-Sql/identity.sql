USE[Curso]

DROP TABLE [COURSE]

 CREATE TABLE [Course](
    [Id] INT NOT NULL IDENTITY(1,1),
    [Name] NVARCHAR(80) NOT NULL,
    [CategoryId] INT NOT NULL,
   
    CONSTRAINT [PK_Course] PRIMARY KEY([Id]),
    CONSTRAINT [FK_Course_Category] FOREIGN KEY([CategoryId])  
        REFERENCES [Category]([Id])

 )
 GO


DROP TABLE [StatusCourse]

  CREATE TABLE [StatusCourse](
    [StudentId] INT NOT NULL,
    [CourseId] INT NOT NULL,
    [Status] INT NOT NULL,
    [LastUpdate] DATETIME NOT NULL DEFAULT(GETDATE()),

    CONSTRAINT PK_StatusCourse PRIMARY KEY([StudentId], CourseId)
 )
 GO

  CREATE TABLE [Category](
    [Id] INT NOT NULL IDENTITY(1,1),
    [Name] NVARCHAR(80) NOT NULL,
   

    CONSTRAINT [PK_Category] PRIMARY KEY([Id]),
  )
  GO
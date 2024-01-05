CREATE DATABASE [school]
GO

USE [school]
GO

CREATE TABLE [student](
    [id] UNIQUEIDENTIFIER NOT NULL,
    [name] NVARCHAR(120) NOT NULL,
    [email] NVARCHAR(180) NOT NULL,
    [document] NVARCHAR(20) NOT NULL,
    [phone] NVARCHAR(20) NOT NULL,
    [birthdate] DATETIME NOT NULL,
    [createdAt] DATETIME NOT NULL,
    CONSTRAINT [pk_student] PRIMARY KEY([id])
)
GO

CREATE TABLE [author](
    [id] UNIQUEIDENTIFIER NOT NULL,
    [name] NVARCHAR(120) NOT NULL,
    [title] NVARCHAR(80) NOT NULL,
    [image] NVARCHAR(1024) NOT NULL,
    [bio] NVARCHAR(2000) NOT NULL,
    [url] NVARCHAR(450)NOT NULL,
    [email] NVARCHAR(160)NOT NULL,
    [type] TINYINT NOT NULL, --0 a 255
    CONSTRAINT [pk_author] PRIMARY KEY([id])
)
GO

CREATE TABLE [career](
    [id] UNIQUEIDENTIFIER NOT NULL,
    [title] NVARCHAR(160) NOT NULL,
    [summary] NVARCHAR(2000) NOT NULL,
    [url] NVARCHAR(1024)NOT NULL,
    [durationInMinutes] INT NOT NULL,
    [active] BIT NOT NULL,
    [featured] BIT NOT NULL, 
    [tags] NVARCHAR(160) NOT NULL,
    CONSTRAINT [pk_career] PRIMARY KEY([id])
)
GO

CREATE TABLE [category](
    [id] UNIQUEIDENTIFIER NOT NULL,
    [title] NVARCHAR(160) NOT NULL,
    [summary] NVARCHAR(2000) NOT NULL,
    [url] NVARCHAR(1024)NOT NULL,
    [order] INT NOT NULL,
    [description] TEXT NOT NULL,
    [featured] BIT NOT NULL, 
    CONSTRAINT [pk_category] PRIMARY KEY([id])
)
GO


CREATE TABLE [course]
(
    [id] uniqueidentifier NOT NULL,
    [tag] NVARCHAR(20) NOT NULL,
    [title] NVARCHAR(160) NOT NULL,
    [summary] NVARCHAR(2000) NOT NULL,
    [url] NVARCHAR(1024) NOT NULL,
    [level] TINYINT NOT NULL,
    [durationInMinutes] INT NOT NULL,
    [createdAt] DATETIME NOT NULL,
    [lastUpdateDate] DATETIME NOT NULL,
    [active] BIT NOT NULL,
    [free] BIT NOT NULL,
    [featured] BIT NOT NULL,
    [authorId] uniqueidentifier NOT NULL,
    [categoryId] uniqueidentifier NOT NULL,
    [tags] NVARCHAR(160) NOT NULL,
    CONSTRAINT [pk_course] PRIMARY KEY ([Id]),
    CONSTRAINT [fk_course_author_authorId] FOREIGN KEY ([authorId]) REFERENCES [author] ([id]),
    CONSTRAINT [fk_course_category_categoryId] FOREIGN KEY ([categoryId]) REFERENCES [category] ([id])
);
GO

CREATE TABLE [careerItem]
(
    [careerId] uniqueidentifier NOT NULL,
    [courseId] uniqueidentifier NOT NULL,
    [title] NVARCHAR(160) NOT NULL,
    [description] TEXT NOT NULL,
    [order] TINYINT NOT NULL,
    
    CONSTRAINT [pk_careerItem] PRIMARY KEY ([courseId], [careerId]),
    CONSTRAINT [fk_careerItem_career_careerId] FOREIGN KEY ([careerId]) REFERENCES [career] ([id]),
    CONSTRAINT [fk_careerItem_course_courseId] FOREIGN KEY ([courseId]) REFERENcES [course] ([id])
);
GO

CREATE TABLE [studentCourse]
(
    [courseId] uniqueidentifier NOT NULL,
    [studentId] uniqueidentifier NOT NULL,
    [progress] TINYINT NOT NULL,
    [favorite] BIT NOT NULL,
    [startDate] DATETIME NOT NULL,
    [lastUpdateDate] DATETIME NULL DEFAULT(GETDATE()),
    CONSTRAINT [pk_studentCourse] PRIMARY KEY ([courseId], [studentId]),
    CONsTRAINT [fk_studentCourse_course_courseId] FOREIGN KEY ([courseId]) REFERENCEs [course] ([id]),
    CONsTRAINT [fk_studentCourse_student_studentId] FOREIGN KEY ([studentId]) REFERENCEs [student] ([id])
);
GO

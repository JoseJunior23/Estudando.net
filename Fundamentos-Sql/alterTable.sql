USE [Curso]

ALTER TABLE[Student]
    ADD[Document] NVARCHAR(11)

ALTER TABLE [Student]
    DROP COLUMN[Document]

ALTER TABLE[Student]
    ALTER COLUMN[Document] CHAR(11)
CREATE OR ALTER VIEW vwCourses AS

    SELECT
        [Course].[Id],
        [Course].[Tag],
        [Course].[Title],
        [Course].[Summary],
        [Course].[Url],
        [category].[Title] as [category],
        [author].[name] AS [Author]
    FROM
        [Course]
        INNER JOIN [Category] ON [Course].[CategoryId] = [Category].[Id]
        inner JOIN [Author] ON [Course].[AuthorId] = [Author].[Id]
    WHERE
        [Active] = 1
GO
   
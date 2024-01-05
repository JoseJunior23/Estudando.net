SELECT top 10
    [Course].[Id],
    [Course].[Name],
    [Category].Id as Category,
    [Category].Name
FROM
    [Course]
    INNER JOIN [Category]
        on [Course].[CategoryId] = [Category].[Id]
GO

SELECT top 10
    [Course].[Id],
    [Course].[Name],
    [Category].Id as Category,
    [Category].Name
FROM
[Course]
LEFT JOIN [Category] ON [Course].[CategoryId] = [Category].[Id]
GO

SELECT top 10
    [Course].[Id],
    [Course].[Name],
    [Category].Id as Category,
    [Category].Name
FROM
[Course]
RIGHT JOIN [Category] ON [Course].[CategoryId] = [Category].[Id]
GO


CREATE OR ALTER VIEW vwCountCoursesByCategory AS 
    SELECT top 10
        [Category].[Id],
        [Category].[Name],
        COUNT([Course].[CategoryId]) AS [Cursos]
    FROM
        [Category]
        INNER JOIN [Course] on [Course].[CategoryId] = [Category].[Id]
    GROUP BY
        [Category].[Id],
        [Category].[Name],
        [Course].[CategoryId]
    HAVING 
        COUNT([Course].[CategoryId]) = 2
GO



SELECT * FROM vwCountCoursesByCategory
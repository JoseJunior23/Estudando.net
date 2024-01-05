
SELECT DISTINCT TOP 10 
    [Id], [Name], [CategoryId]
FROM 
    [Course] 
-- WHERE
--     [CategoryId] = 1 
ORDER BY
    [Name] ASC
    -- ASC => acendente 
    -- DESC=> decendente


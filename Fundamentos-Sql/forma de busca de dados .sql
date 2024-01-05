SELECT TOP 100
    [Id] as Codigo, 
    [Name]
FROM
    [Course]
WHERE
    [Id] IN (1,2,3)


    -- MIN => menor valor
    -- MAX => maior valor
    -- count => realiza o soma dos items
    -- AVG => tira a média 
    -- SUM => faz a soma
    --LIKE => Faz busca pela palavra entre aspas  %
    --IN => selecinar dados dentro de uma lista ex  curso com id de 1 e 10, (1,10)
    --BETWEEN => seleciona dados entre um dado e outro 
    -- AS => alias troca ou da um nome aos dados
SELECT * from [Category]

BEGIN TRANSACTION
    UPDATE
        [Category]
    SET
        [Name] = 'flutter'   
    WHERE
        [Id] = 6
-- ROLLBACK => para desfazer antes da mudança
COMMIT

SELECT * from [Category]

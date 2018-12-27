CREATE SEQUENCE StudentSequence
START WITH 9
INCREMENT BY 1;
GO

ALTER SEQUENCE dbo.CategorySequence
RESTART WITH 9;

Insert into Category(id_category, name)
VALUES (NEXT VALUE FOR CategorySequence, 'Violet')
delete from Category where id_category=10;
CREATE PROCEDURE [dbo].[spProduct_Add]
	@Name nvarchar(100),
	@Description nvarchar(100),
	@Price int
AS
	INSERT INTO dbo.Product (Name,Description,Price) VALUES (@Name,@Description,@Price);
RETURN 0

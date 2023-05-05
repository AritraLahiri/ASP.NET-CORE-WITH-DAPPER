CREATE PROCEDURE [dbo].[spProduct_Update]
	@Id int,
	@Price int,
	@Name nvarchar(100),
	@Description nvarchar(100)

AS
	UPDATE dbo.Product SET Name = @Name , Description = @Description, Price = @Price Where Id = @Id;
RETURN 0

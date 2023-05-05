CREATE PROCEDURE [dbo].[spProduct_Get]
	@Id int
AS
	SELECT * From dbo.Product Where Id = @Id;
RETURN 0

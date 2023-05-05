CREATE PROCEDURE [dbo].[spProduct_Delete]
	@Id int
AS
	DELETE From dbo.Product Where Id = @Id;
RETURN 0

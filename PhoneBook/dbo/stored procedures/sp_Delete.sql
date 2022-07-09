CREATE PROCEDURE [dbo].[Sp_Delete]
	@Id int
as
begin
	delete from dbo.[Contacts]
	where Id = @Id
end

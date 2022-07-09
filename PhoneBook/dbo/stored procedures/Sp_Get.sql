CREATE PROCEDURE [dbo].[Sp_Get]
	@Id int
AS
begin
	select *
	from dbo.[Contacts]
	where Id = @Id
end



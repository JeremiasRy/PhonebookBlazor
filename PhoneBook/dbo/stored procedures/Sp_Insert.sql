CREATE PROCEDURE [dbo].[Sp_Insert]
	@Name nvarchar(50),
	@Number nvarchar(50)
AS
begin
	Insert into dbo.[Contacts] (Name, Number)
	values (@Name, @Number)
end

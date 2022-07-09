CREATE PROCEDURE [dbo].[Sp_Update]
	@Id int,
	@Name nvarchar(50),
	@Number nvarchar(50)
as
	begin
	update dbo.[Contacts]
    set Name = @Name, Number = @Number
	where Id = @Id
	end
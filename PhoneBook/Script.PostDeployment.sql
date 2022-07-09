if not exists (select 1 from dbo.[Contacts])
begin	
insert into dbo.[Contacts] (Name, Number)
values ('Lennon', '998-8112212'), ('Jeremy', '21-12211221'), ('Piis', '123-12312312')
end

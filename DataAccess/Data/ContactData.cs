using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;

public class ContactData : IContactData
{
	private readonly ISqlAccess _db;

	public ContactData(ISqlAccess db)
	{
		_db = db;
	}

	public Task<IEnumerable<ContactModel>> GetContacts() => _db.LoadData<ContactModel, dynamic>("dbo.Sp_GetAll", new { });

	public async Task<ContactModel?> GetContact(int id)
	{
		var results = await _db.LoadData<ContactModel, dynamic>("dbo.Sp_Get", new { Id = id });

		return results.FirstOrDefault();
	}

	public Task InsertContact(ContactModel contact) => _db.SaveData("dbo.Sp_Insert", new { contact.Name, contact.Number });

	public Task UpdateContact(ContactModel contact) => _db.SaveData("dbo.Sp_Update", contact);

	public Task DeleteContact(int id) => _db.SaveData("dbo.Sp_Delete", new { Id = id });


}

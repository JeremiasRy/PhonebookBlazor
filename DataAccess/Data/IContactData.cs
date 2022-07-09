using DataAccess.Models;

namespace DataAccess.Data;

public interface IContactData
{
	Task DeleteContact(int id);
	Task<ContactModel?> GetContact(int id);
	Task<IEnumerable<ContactModel>> GetContacts();
	Task InsertContact(ContactModel contact);
	Task UpdateContact(ContactModel contact);
}

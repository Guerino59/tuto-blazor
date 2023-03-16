using Tuto.Models;

namespace Tuto
{
    public interface IContactService
    {
        
        List<Contact> GetContacts();
        void AddContact(Contact contact);
    }
}

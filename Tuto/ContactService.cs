using Tuto.Models;

namespace Tuto
{
    public class ContactService : IContactService
    {
        private List<Contact> contactList = new List<Contact>();

        public List<Contact> GetContacts()
        {
            return contactList;
        }
        public void AddContact(Contact contact)
        {
            contactList.Add(contact);
        }
    }
}

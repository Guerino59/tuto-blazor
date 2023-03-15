using Tuto.Models;

namespace Tuto
{
    public class ContactService
    {
        public List<Contact> ContactList = new List<Contact>();
        public void AddContact(Contact contact)
        {
            ContactList.Add(contact);
        }
    }
}

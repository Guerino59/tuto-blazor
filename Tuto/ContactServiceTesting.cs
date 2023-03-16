using Tuto.Models;

namespace Tuto
{
    public class ContactServiceTesting : IContactService
    {
        private List<Contact> contactList = new List<Contact>();
        public void AddContact(Contact contact)
        {
            contactList.Add(contact);
        }

        public List<Contact> GetContacts()
        {
            return new List<Contact>
            {
                new Contact
                {
                    FirstName = "Kevin",
                    LastName = "Paul",
                    Email = "kpaul@gmail.com"
                }
            };
        }
    }
}

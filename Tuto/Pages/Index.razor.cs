using Tuto.Models;

namespace Tuto.Pages
{
    public partial class Index
    {

        private List<Contact> contacts;
        private Dictionary<string, object> MyTextBoxAttributes = new Dictionary<string, object>
    {
        {"placeholder", "dzdzyydz"},
        {"type", "password"}
    };

        private void DeleteContact(Contact contact)
        {
            contacts.Remove(contact);
        }
        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(5000);
            contacts = new List<Contact>
        {
            new Contact
            {
                FirstName = "John",
                LastName = "Thomas",
                Email = "john@gmail.com"
            },
            new Contact
            {
                FirstName = "Louis",
                LastName = "Thomas",
                Email = "louis@gmail.com"
            },
            new Contact
            {
                FirstName = "Peter",
                LastName = "Thomas",
                Email = "peter@gmail.com"
            }
        };
            base.OnInitializedAsync();
        }
    }
}

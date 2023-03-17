using Tuto.Models;
using Microsoft.AspNetCore.Components;
using Tuto.Pages.ContactComponent;

namespace Tuto.Pages
{
    public partial class Index
    {
        [CascadingParameter]
        public Theme AppTheme { get; set; }
        [Inject]
        IContactService contactService { get; set; }

        [Inject]
        NavigationManager navigationManager { get; set; }

        private List<Contact> contacts;
        private bool IsContactDisplayed = true;
        private ContactList contactList;
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
          //  contacts = contactService.GetContacts(); 
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
        private void HideContacts()
        {
            IsContactDisplayed = !IsContactDisplayed;
            if (!IsContactDisplayed)
            {
                contactList.HideContact();
            }
            else
            {
                contactList.ShowContact();
            }
        }
        private void NavigateToTest()
        {
            navigationManager.NavigateTo("./testpage");
        }
    }
}

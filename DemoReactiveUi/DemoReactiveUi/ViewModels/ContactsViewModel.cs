using DemoReactiveUi.Models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System.Text;

namespace DemoReactiveUi.ViewModels
{
    public class ContactsViewModel : ReactiveObject
    {
        public List<Contact> _samples = new List<Contact>()
        {
            new Contact{FullName = "Dahi Mohsen", Email="mohsendahi@gmail.com", Phone ="75587568"},
            new Contact{FullName = "Mohamed Iskander", Email="mohamediskander@gmail.com", Phone ="58465788"},
            new Contact{FullName = "Nade Dkhil", Email="nadedkhil@gmail.com", Phone ="56774168"},
            new Contact{FullName = "Karim Ben Saad", Email="karimbensaad@gmail.com", Phone ="55217468"},
            new Contact{FullName = "omaïma Rezgui", Email="omïmarezgui@gmail.com", Phone ="51585520"}
        };

        public ContactsViewModel()
        {
            _contacts = new ObservableCollection<Contact>(_samples);

            this.WhenAnyValue(vm => vm.SearchQuery)
                .Throttle(TimeSpan.FromSeconds(1))
                .Subscribe(query =>
                {
                    var filteredContacts = _samples.Where(c => c.FullName.ToLower().Contains(query) || c.Phone.Contains(query) ||
                        c.Email.Contains(query)).ToList();

                    Contacts = new ObservableCollection<Contact>(filteredContacts);
                });
        }

        #region Properties
        private string _searchQuery = "";

        public string SearchQuery
        {
            get => _searchQuery;
            set { this.RaiseAndSetIfChanged(ref _searchQuery, value); }
        }


        private ObservableCollection<Contact> _contacts;

        public ObservableCollection<Contact> Contacts
        {
            get => _contacts;
            set { this.RaiseAndSetIfChanged(ref _contacts, value); }
        }

        #endregion
    }
}

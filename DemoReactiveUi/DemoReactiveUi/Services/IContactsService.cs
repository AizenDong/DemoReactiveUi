using DemoReactiveUi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoReactiveUi.Services
{
    public interface IContactsService
    {
        IEnumerable<Contact> GetAllContacts();
    }

    public class StaticContactsService : IContactsService
    {
        public List<Contact> _samples = new List<Contact>()
        {
            new Contact{FullName = "Dahi Mohsen", Email="mohsendahi@gmail.com", Phone ="75587568"},
            new Contact{FullName = "Mohamed Iskander", Email="mohamediskander@gmail.com", Phone ="58465788"},
            new Contact{FullName = "Nade Dkhil", Email="nadedkhil@gmail.com", Phone ="56774168"},
            new Contact{FullName = "Karim Ben Saad", Email="karimbensaad@gmail.com", Phone ="55217468"},
            new Contact{FullName = "omaïma Rezgui", Email="omïmarezgui@gmail.com", Phone ="51585520"}
        };

        public IEnumerable<Contact> GetAllContacts()
        {
            return _samples;
        }
    }
}

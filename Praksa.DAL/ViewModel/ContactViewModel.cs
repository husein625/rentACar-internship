using praksa_rent.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Praksa.DAL.ViewModel
{
    public class ContactViewModel
    {
        public ContactViewModel(IReadOnlyCollection<Contact> contacts )
        {
            Collection = contacts.Select(contact => new ContactDto(contact)).ToList();

        }

        public IReadOnlyCollection<ContactDto> Collection { get; set; }

    }
}

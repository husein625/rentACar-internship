using praksa_rent.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Praksa.DAL.ViewModel
{
   public class ContactDto
    {
        public ContactDto(Contact contact)
        {
            Id = contact.Id;
            UserId = contact.UserId;
            Question = contact.Question;
        }
        public int Id { get; set; }
        public int UserId { get; set; }

        public string Question { get; set; }

    }
}

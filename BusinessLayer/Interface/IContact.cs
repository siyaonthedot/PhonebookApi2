using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Model;
using System.Web;

namespace BusinessLayer.Interface
{
   public interface  IContact
    {
         List<ContactModel> GetAllContacts();
        string AddUpdateContact(ContactModel model);
        ContactModel GetContactByID(int id);
        void DeleteContact(int id);

    }
}
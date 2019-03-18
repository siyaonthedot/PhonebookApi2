using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer.Interface;
using BusinessLayer.Model;
namespace PhonebookApi.Controllers
{
    public class ContactsController : ApiController
    {
        // GET: api/Contacts

       private  IContact _icontact;
        public IEnumerable<ContactModel> Get()
        {
            var contacts = _icontact.GetAllContacts();
            return contacts.ToList();
        }

        // GET: api/Contacts/5
        public ContactModel Get(int id)
        {
            var contact = _icontact.GetContactByID(id);
            return contact;
        }

        // POST: api/Contacts
        public void Post([FromBody]ContactModel value)
        {

            var contact = _icontact.AddUpdateContact(value);
        }

        // PUT: api/Contacts/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Contacts/5
        public void Delete(int id)
        {
        }
    }
}

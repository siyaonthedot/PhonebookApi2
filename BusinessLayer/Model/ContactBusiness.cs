using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer;
using DataLayer.DBContext.Models;
using DataLayer.DBContext.Interface;
using BusinessLayer.Interface;
namespace BusinessLayer.Model
{
   public class ContactBusiness : IContact
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ContactRepository contactRepository;

        public ContactBusiness()
        {
            unitOfWork = new UnitOfWork();
            contactRepository = new ContactRepository(unitOfWork);
        }

        public ContactBusiness(IUnitOfWork _unitOfWork)
        {

            unitOfWork = _unitOfWork;
            contactRepository = new ContactRepository(unitOfWork);
        }

        #region

        public List<ContactModel> GetAllContacts()
        {
            List<ContactModel> list = contactRepository.GetAll().Select(m => new ContactModel
            { FirstName = m.FirstName, LastName = m.LastName, ID = m.ID }).ToList();
            return list;
        }

        #endregion

        public void DeleteContact(int id)
        {
            contactRepository.Delete(m => m.ID == id);
        }


        public ContactModel GetContactByID(int id)
        {
            var contact = contactRepository.SingleOrDefault(m => m.ID == id);

            if (contact != null)
            {
                ContactModel model = new ContactModel();
                model.ID = contact.ID;
                model.LastName = contact.LastName;
                model.FirstName = contact.FirstName;
                return model;
            }


            return null;
        }

        public string AddUpdateContact(ContactModel contModel)
        {
            string result = "";
            if (contModel.ID > 0)
            {
                var cont = contactRepository.SingleOrDefault(x => x.ID == contModel.ID);

                if (cont != null)
                {
                    cont.LastName = cont.LastName;
                    cont.FirstName = cont.LastName;
                    contactRepository.Update(cont);
                    result = "updated";

                }
            }
            else
            {
                Contact cont = new Contact();
                cont.LastName = cont.LastName;
                cont.FirstName = cont.LastName;
                var record = contactRepository.Insert(cont);
                result = "Inserted";
            }

            return result;
        }


    }

}


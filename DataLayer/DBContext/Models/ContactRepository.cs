using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DBContext.Interface;
using DataLayer;

namespace DataLayer.DBContext.Models
{
    public class ContactRepository : BaseRepository<Contact>
    {
        public ContactRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }
    }
}

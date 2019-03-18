using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using DataLayer.DBContext.Interface;
using DataLayer;

namespace DataLayer.DBContext.Models
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PhonebookEntities _dbContext;

        public UnitOfWork()
        {
            _dbContext = new PhonebookEntities();
        }

        public DbContext Db
        {
            get { return _dbContext; }
        }

        public void Dispose()
        {
        }
    }
}

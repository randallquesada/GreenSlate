using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using RandallQuesadaSPA.Interfaces;
using System.Data.Entity.Infrastructure;
using InterfaceDAL;

namespace RandallQuesadaSPA.EntityFrameworkDAL
{ 
    // Design pattern :- Adpater pattern ( class Adapter pattern)
    public class EfDal<AnyType> : IRepository<AnyType>
        where AnyType : class
    {
        DbContext dbcont = null;
        public EfDal()
        {
            dbcont = new EUow(); // Self contained transaction
        }
        public void Add(AnyType obj)
        {
            dbcont.Set<AnyType>().Add(obj); // in memory committ
        }

        public void Save()
        {
            dbcont.SaveChanges(); //physical committ
        }
        public void Update(AnyType obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AnyType> Search()
        {
            return dbcont.Set<AnyType>().
                     AsQueryable<AnyType>().
                         ToList<AnyType>();
        }

        public void SetUnitWork(IUow uow)
        {
            dbcont = ((EUow)uow); // Global transaction UOW
        }

        public IEnumerable<AnyType> GetData()
        {
            return dbcont.Set<AnyType>().
                     AsQueryable<AnyType>().
                         ToList<AnyType>();
        }

        public AnyType GetData(int Index)
        {
            throw new NotImplementedException();
        }


        public void Cancel(int Index)
        {
            throw new NotImplementedException();
        }
    }

    public class EUow : DbContext, IUow
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserBase>()
                      .ToTable("User");

            modelBuilder.Entity<ProjectBase>()
                       .ToTable("Project");
           
            modelBuilder.Entity<UserProjectBase>()
                       .ToTable("UserProject");
        }
        public EUow() : base("name=Conn")
        {

        }
        public void Committ()
        {
            SaveChanges();
        }

        public void RollBack()
        {
            Dispose();
        }
    }
}

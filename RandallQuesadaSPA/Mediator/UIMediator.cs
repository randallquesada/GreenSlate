using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceDAL;
using FactoryDAL;
using RandallQuesadaSPA.Interfaces;
using RandallQuesadaSPA.Factory;


namespace Mediator
{
    public class UIUserMediator
    {
        public UIUserMediator(string dal)
        {
            Idal = FactoryDalLayer<IRepository<UserBase>>.Create(dal);
        }        

        private IRepository<UserBase> Idal;

        public IEnumerable<UserBase> LoadUsers()
        {
            IEnumerable<UserBase> custs = Idal.GetData();

            return custs;
        }
    }

    public class UIProjectMediator
    {
        public UIProjectMediator(string dal)
        {
            Idal = FactoryDalLayer<IRepository<ProjectBase>>.Create(dal);
        }        

        private IEnumerable<ProjectBase> projects;

        private IRepository<ProjectBase> Idal;

        public IEnumerable<ProjectBase> LoadUsers()
        {
            IEnumerable<ProjectBase> custs = Idal.GetData();

            return custs;
        }
    }

    public class UIUserProjectMediator
    {
        public UIUserProjectMediator(string dal)
        {
            Idal = FactoryDalLayer<IRepository<UserProjectBase>>.Create(dal);
        }
        private UserProjectBase cust = null;
               
        private IRepository<UserProjectBase> Idal;

        public IEnumerable<UserProjectBase> LoadUsers()
        {
            IEnumerable<UserProjectBase> custs = Idal.GetData();

            return custs;
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using InterfaceDAL;
using System.ComponentModel.DataAnnotations;
using RandallQuesadaSPA.Interfaces;
using RandallQuesadaSPA.EntityFrameworkDAL;

namespace FactoryDAL
{
    public static class FactoryDalLayer<AnyType> // Design pattern :- Simple factory pattern
    {
        private static IUnityContainer Objects = null;

        public static AnyType Create(string Type)
        {
            // Design pattern :- Lazy loading
            if (Objects == null)
            {
                Objects = new UnityContainer();
                Objects.RegisterType<IRepository<ProjectBase>, EfDal<ProjectBase>>("ProjectEfDal");
                Objects.RegisterType<IRepository<UserBase>, EfDal<UserBase>>("UserEfDal");
                Objects.RegisterType<IRepository<UserProjectBase>, EfDal<UserProjectBase>>("UserProjectBaseEfDal");
            }
            //Design pattern :-  RIP Replace If with Poly
            return Objects.Resolve<AnyType>(Type);
        }
    }
}

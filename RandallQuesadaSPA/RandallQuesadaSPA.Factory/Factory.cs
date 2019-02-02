using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using RandallQuesadaSPA.Entities;
using RandallQuesadaSPA.Interfaces;


namespace RandallQuesadaSPA.Factory
{
    public static class UserFactory
    {
        private static IUnityContainer UserObjects = null;                

        public static UserBase Create(string Type)
        {
            // Design pattern :- Lazy loading. Eager loading
            if (UserObjects == null)
            {
                UserObjects = new UnityContainer();

                UserObjects.RegisterType<FactoryUserBase, FactoryUser>("User");
            }
            //Design pattern :-  RIP Replace If with Poly
            FactoryUserBase factorybase = UserObjects.Resolve<FactoryUserBase>(Type);
            return factorybase.CreateUser();
        }
    }

    public static class ProjectFactory
    {
        private static IUnityContainer ProjectObjects = null;

        public static ProjectBase Create(string Type)
        {
            // Design pattern :- Lazy loading. Eager loading
            if (ProjectObjects == null)
            {
                ProjectObjects = new UnityContainer();

                ProjectObjects.RegisterType<FactoryProjectBase, FactoryProject>("Project");
            }
            //Design pattern :-  RIP Replace If with Poly
            FactoryProjectBase factorybase = ProjectObjects.Resolve<FactoryProjectBase>(Type);
            return factorybase.CreateProject();
        }
    }

    public static class UserProjectFactory
    {
        private static IUnityContainer UserProjectObjects = null;

        public static UserProjectBase Create(string Type)
        {
            // Design pattern :- Lazy loading. Eager loading
            if (UserProjectObjects == null)
            {
                UserProjectObjects = new UnityContainer();

                UserProjectObjects.RegisterType<FactoryUserProjectBase, FactoryUserProject>("UserProject");
            }
            //Design pattern :-  RIP Replace If with Poly
            FactoryUserProjectBase factorybase = UserProjectObjects.Resolve<FactoryUserProjectBase>(Type);
            return factorybase.CreateUserProjectBase();
        }
    }


    public static class UserProjectViewFactory
    {
        private static IUnityContainer UserProjectViewObjects = null;

        public static UserProjectViewBase Create(string Type)
        {
            // Design pattern :- Lazy loading. Eager loading
            if (UserProjectViewObjects == null)
            {
                UserProjectViewObjects = new UnityContainer();

                UserProjectViewObjects.RegisterType<FactoryUserProjectViewBase, FactoryUserProjectView>("UserProjectView");
            }
            //Design pattern :-  RIP Replace If with Poly
            FactoryUserProjectViewBase factorybase = UserProjectViewObjects.Resolve<FactoryUserProjectViewBase>(Type);
            return factorybase.CreateUserProjectViewBase();
        }
    }

    public class FactoryUserBase
    {        
        public UserBase CreateUser()
        {
            return new User();
        }
    }

    public class FactoryUser : FactoryUserBase
    {

    }

    public class FactoryProjectBase
    {
        public ProjectBase CreateProject()
        {
            return new Project();
        }
    }

    public class FactoryProject : FactoryProjectBase
    {

    }

    public class FactoryUserProjectBase
    {
        public UserProjectBase CreateUserProjectBase()
        {
            return new UserProject();
        }
    }

    public class FactoryUserProject : FactoryUserProjectBase
    {

    }

    public class FactoryUserProjectViewBase
    {
        public UserProjectViewBase CreateUserProjectViewBase()
        {
            return new UserProjectView();
        }
    }

    public class FactoryUserProjectView : FactoryUserProjectViewBase
    {

    }

}

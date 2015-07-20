using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using MVC_Repository.Models;
using MVC_Repository.Repositories;

namespace MVC_Repository
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            //Register the Repository in the Unity Container
            container.RegisterType<IRepository<EmployeeInfo,int>,EmployeeInfoRepository>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
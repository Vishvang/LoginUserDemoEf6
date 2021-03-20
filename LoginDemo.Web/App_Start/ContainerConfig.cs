using Autofac;
using Autofac.Integration.Mvc;
using LoginDomain.DataModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginDemo.Web
{
    public class ContainerConfig
    {
        internal static void Registercaontainer()
        {
            //Tell container about your diff abstraction and component we have in project.
            //So what I want to inject other piece of container 

            //Build container
            var builder = new ContainerBuilder();

            //TEll this builder about your diff abstraction
            //This method will go through from project for diff controller type and
            //register with autofac. 
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            //Tell about specific services
            builder.RegisterType<InMemoryUserData>()
                .As<IUserData>()
                .SingleInstance(); //Only if one user is going to access at a time

            var container = builder.Build();

            //To resolve dependency
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
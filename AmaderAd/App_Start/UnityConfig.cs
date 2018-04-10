using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Practices.Unity;
using AmaderAd.Controllers;
using AmaderAd.DAL;
using AmaderAd.Models;
using System;
using System.Data.Entity;
using System.Web.Http;
using System.Web.Mvc;
using Unity.WebApi;

namespace AmaderAd
{
    public static class UnityConfig
    {
    

        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            //Log
            container.RegisterType<ILogAccessRepository<Log, int>, LogDataAccessRepository>();

            //Banner
            container.RegisterType<IBannerAccessRepository<Banner, int>, BannerDataAccessRepository>();
            //account
            container.RegisterType<IAccountAccessRepository<RegisterViewModel, int>, AccountDataAccessRepository>();

            //newspaper
            container.RegisterType<INewspaperAccessRepository<Newspaper, int>, NewspaperDataAccessRepository>();

            //OrderPaymentMethod
            container.RegisterType<IOrderPaymentMethodAccessRepository<OrderPaymentMethod, int>, OrderPaymentMethodDataAccessRepository>();
            //OrderPaymentStatus
            container.RegisterType<IOrderPaymentStatusAccessRepository<OrderPaymentStatus, int>, OrderPaymentStatusDataAccessRepository>();



            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}
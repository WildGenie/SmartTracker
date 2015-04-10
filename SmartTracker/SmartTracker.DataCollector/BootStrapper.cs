using System;
using ServiceStack.OrmLite;
using Nancy.Bootstrappers.Autofac;
using Autofac;
using Nancy.Bootstrapper;
using Nancy;

namespace SmartTracker.DataCollector
{
	public class BootStrapper : AutofacNancyBootstrapper
	{
		public BootStrapper ()
		{

		}


		protected override void ApplicationStartup (ILifetimeScope container, IPipelines pipelines)
		{
			// No registrations should be performed in here, however you may
			// resolve things that are needed during application startup.
		}

		protected override void ConfigureApplicationContainer (ILifetimeScope existingContainer)
		{
			// Perform registration that should have an application lifetime

			var dbFactory = new OrmLiteConnectionFactory (
				                "Server=192.168.1.20; Port=5432;User Id=hivie; Password=hivie; Database=hivie", ServiceStack.OrmLite.PostgreSQL.PostgreSQLDialectProvider.Instance);
			

			var builder = new ContainerBuilder ();
			builder.RegisterInstance (dbFactory).As<OrmLiteConnectionFactory> ();
			builder.RegisterType<DoorAndSensorRepository> ().As<IDoorAndSensorRepository> ();
			builder.Update (existingContainer.ComponentRegistry);
		
		}

		protected override void ConfigureRequestContainer (ILifetimeScope container, NancyContext context)
		{
			 
			var builder = new ContainerBuilder ();
			builder.RegisterType<DoorAndSensorRepository> ().As<IDoorAndSensorRepository> ();
			builder.Update (container.ComponentRegistry);
		}

		protected override void RequestStartup (ILifetimeScope container, IPipelines pipelines, NancyContext context)
		{
			// No registrations should be performed in here, however you may
			// resolve things that are needed during request startup.
		}
	}
}

	
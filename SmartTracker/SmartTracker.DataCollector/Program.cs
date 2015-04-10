using System;
using Nancy.Hosting.Self;
using ServiceStack.OrmLite;
using System.Data;
using Nancy;

namespace SmartTracker.DataCollector
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			

//			IDbConnection connection = dbFactory.CreateDbConnection ();
//			connection.Open ();
//			var data = new EventDataEntity (){ EventDate = DateTime.Now };
//			var t = connection.Select<EventDataEntity> ();
//			connection.Insert <EventDataEntity> (data, false);

			StaticConfiguration.DisableErrorTraces = false;
			using (var host = new NancyHost (new Uri ("http://localhost:1234"))) {
				host.Start ();
				Console.ReadLine ();
			}
		}
	}
}

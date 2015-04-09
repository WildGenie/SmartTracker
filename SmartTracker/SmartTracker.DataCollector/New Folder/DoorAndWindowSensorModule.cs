using System;

namespace SmartTracker.DataCollector
{
	public class DoorAndWindowSensorModule : Nancy.NancyModule
	{

		static IDoorAndSensorRepository doorAndSensorRepository;

		public DoorAndWindowSensorModule (IDoorAndSensorRepository doorAndSensorRepository)
		{
			DoorAndWindowSensorModule.doorAndSensorRepository = doorAndSensorRepository;

			if (doorAndSensorRepository == null)
				throw new ArgumentNullException ("doorAndSensorRepository");
			Get ["/door"] = _ => {

				return "Hello World";
			};
		}
	}



}


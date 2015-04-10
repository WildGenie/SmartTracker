using System;

namespace SmartTracker.DataCollector
{
	public class DoorAndWindowSensorModule : Nancy.NancyModule
	{

		IDoorAndSensorRepository doorAndSensorRepository;

		public DoorAndWindowSensorModule (IDoorAndSensorRepository doorAndSensorRepository)
		{
			this.doorAndSensorRepository = doorAndSensorRepository;

			if (doorAndSensorRepository == null) {
				throw new ArgumentNullException ("doorAndSensorRepository");
			}
			Get ["/door"] = _ => {
				doorAndSensorRepository.SaveSensorData (new EventDataEntity (){ device_id = "test id" });
				return "Hello World";
			};
		}
	}



}


using System;

namespace SmartTracker.DataCollector
{
	public interface IDoorAndSensorRepository
	{
		void SaveSensorData (EventDataEntity entity);
	}
}


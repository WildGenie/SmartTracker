using System;
using ServiceStack.OrmLite;
using System.Data;

namespace SmartTracker.DataCollector
{
	public class DoorAndSensorRepository : IDoorAndSensorRepository
	{
		OrmLiteConnectionFactory ormLiteConnectionFactory;

		public DoorAndSensorRepository (OrmLiteConnectionFactory ormLiteConnectionFactory)
		{
			if (ormLiteConnectionFactory == null) {
				throw new ArgumentNullException ("ormLiteConnectionFactory");
			}
				
			this.ormLiteConnectionFactory = ormLiteConnectionFactory;
		}

		#region IDoorAndSensorRepository implementation

		public void SaveSensorData (EventDataEntity entity)
		{
			using (IDbConnection db = ormLiteConnectionFactory.CreateDbConnection ()) {
				db.Open ();


				try {
					db.Save (entity);
					long meh = db.LastInsertId ();
					string uhhuh = db.GetLastSql ();
				} catch (Exception ex) {
					string uhhuh = db.GetLastSql ();

					var text = ex.Message;
				}

			}
		}

		#endregion
	}
}


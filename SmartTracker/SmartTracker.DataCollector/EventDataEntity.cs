using System;
using ServiceStack.DataAnnotations;
using ServiceStack.Model;

namespace SmartTracker.DataCollector
{
	[Alias ("event_data")]
	public class EventDataEntity : IHasId<int>
	{
		[Alias ("event_data_id")]
		[AutoIncrement]
		public int Id { get; set; }

		[Alias ("event_date")]
		public DateTime EventDate { get; set; }

		[Alias ("id")]
		public string id { get; set; }

		[Alias ("device_id")]
		public string device_id { get; set; }

		[Alias ("hub_id")]
		public string hub_id  { get; set; }

		[Alias ("location_id")]
		public string location_id { get; set; }

		[Alias ("installed_smart_app_id")]
		public string installed_smart_app_id { get; set; }

		[Alias ("is_state_change")]
		public string is_state_change { get; set; }

		[Alias ("is_physical")]
		public string is_physical { get; set; }

		[Alias ("description")]
		public string description { get; set; }

		[Alias ("description_text")]
		public string description_text { get; set; }

		[Alias ("display_name")]
		public string display_name { get; set; }

		[Alias ("iso_date")]
		public string iso_date { get; set; }

		[Alias ("name")]
		public string name { get; set; }

	
		[Alias ("unit")]
		public string unit { get; set; }

		[Alias ("source")]
		public string source  { get; set; }

		[Alias ("value")]
		public string value { get; set; }

		[Alias ("string_value")]
		public string string_value { get; set; }

		[Alias ("integer_value")]
		public int integer_value { get; set; }

		[Alias ("long_value")]
		public long long_value { get; set; }

		[Alias ("float_value")]
		public float float_value { get; set; }

		[Alias ("double_value")]
		public double double_value { get; set; }

		[Alias ("number_value")]
		public double number_value { get; set; }

		[Alias ("numeric_value")]
		public double numeric_value { get; set; }

		[Alias ("date_value")]
		public DateTime date_value { get; set; }

		[Alias ("xyz_value")]
		public string xyz_value { get; set; }


		[Alias ("json_value")]
		public string json_value { get; set; }

		public EventDataEntity ()
		{

			integer_value = 2;

			date_value = DateTime.Now;
		}
	}
}


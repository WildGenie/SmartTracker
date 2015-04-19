using System;
using System.Runtime.Serialization;
using ServiceStack.DataAnnotations;


namespace SmartTracker.DataCollector
{
	[DataContract]
	[Alias ("data")]
	public class EventDataDTO
	{
		[ DataMember (Name = "id")]
		[Alias ("id")]
		public string Id { get; set; }

		[ DataMember (Name = "date")]
		[Alias ("date")]
		public DateTime DateTime { get; set; }

		[ DataMember (Name = "value")]
		[Alias ("value")]
		public string Value { get; set; }

		[ DataMember (Name = "name")]
		[Alias ("name")]
		public string Name { get; set; }

		[ DataMember (Name = "display_name")]
		[Alias ("display_name")]
		public string DisplayName { get; set; }

		[ DataMember (Name = "description")]
		[Alias ("description")]
		public string Description { get; set; }

		[ DataMember (Name = "source")]
		[Alias ("source")]
		public string Source { get; set; }

		[ DataMember (Name = "state_changed")]
		[Alias ("state_changed")]
		public bool WasStateChanged { get; set; }

		[ DataMember (Name = "physical")]
		[Alias ("physical")]
		public bool IsPhysical { get; set; }

		[ DataMember (Name = "hub_id")]
		[Alias ("hub_id")]
		public string HubId { get; set; }

		[ DataMember (Name = "location_id")]
		[Alias ("location_id")]
		public string LocationId { get; set; }

		public EventDataDTO ()
		{

		}

	}
}


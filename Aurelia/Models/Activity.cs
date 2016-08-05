using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aurelia.Models
{
	public class Activity
	{
		public long UID { get; set; }
		public DateTime Date { get; set; }
		[ForeignKey("Shift")]
		public long Shift_ID { get; set; }
		[ForeignKey("Person")]
		public long Person_ID { get; set; }
		public DateTime Start { get; set; }
		public DateTime Stop { get; set; }

		public Shift Shift { get; set; }
		public Person Person { get; set; }
	}
}
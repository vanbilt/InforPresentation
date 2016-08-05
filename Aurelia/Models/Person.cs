using System.ComponentModel.DataAnnotations.Schema;

namespace Aurelia.Models
{
	public class Person
	{
		public long UID { get; set; }
		public string Name { get; set; }
		[ForeignKey("Job")]
		public long Job_ID { get; set; }

		public Job Job { get; set; }
	}
}
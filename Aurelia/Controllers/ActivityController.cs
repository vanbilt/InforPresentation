using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

using Aurelia.Models;
using Aurelia.Data;
using Aurelia.Authorize;

namespace Aurelia.Controllers
{
	[InforAuthorize]
	public class ActivityController : ApiController
	{
		public List<Activity> Activities = ActivitiesDb.Get();

		public List<Activity> GetAllActivities()
		{
			return Activities;
		}

		public IHttpActionResult GetActivity(long id)
		{
			var activity = Activities.FirstOrDefault((a) => a.UID == id);

			if (activity == null)
			{
				return NotFound();
			}
			return Ok(activity);
		}

	}
}

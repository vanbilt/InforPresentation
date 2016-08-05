using System;
using System.Linq;
using System.Web.Http;

using Aurelia.Data;
using Aurelia.Models;

namespace Aurelia.Authorize
{
	public class InforAuthorizeAttribute : AuthorizeAttribute
	{
		public override void OnAuthorization(
			System.Web.Http.Controllers.HttpActionContext actionContext)
		{
			if (Authorize(actionContext))
			{
				return;
			}
			HandleUnauthorizedRequest(actionContext);
		}

		protected override void HandleUnauthorizedRequest(
			System.Web.Http.Controllers.HttpActionContext actionContext)
		{
			actionContext.Response = 
				new System.Net.Http.HttpResponseMessage(
					System.Net.HttpStatusCode.Unauthorized);
		}

		private bool Authorize(
			System.Web.Http.Controllers.HttpActionContext actionContext)
		{
			try
			{
				// using "basic" authenticaion - 
				//{Basic aW5mb3I6aW50ZXJ2aWV3}
				// find the authentication header
				var authData = (from h 
								in actionContext.Request.Headers
								where h.Key == "Authorization"
								select h.Value.First()
								).FirstOrDefault();

				var base64EncodedBytes = 
					Convert.FromBase64String(authData.Replace("Basic ", ""));
				// unencode the base64 string
				var uidpwd = 
					System.Text.Encoding.UTF8.GetString(
						base64EncodedBytes).Split(':');

				// find the user with that uid/pwd combination
				User authorizedUser = 
					ActivitiesDb
						.Users
						.FirstOrDefault(u => 
							(uidpwd[0] == u.Email && uidpwd[1] == u.Pword)
						);

				if (authorizedUser != null)
				{
					return true;
				}
			}
			catch (Exception)
			{
			}

			// error or user not found == unauthorized
			return false;
		}
	}
}
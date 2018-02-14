using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;
using ActionFilterAttribute = System.Web.Http.Filters.ActionFilterAttribute;

namespace ExampleAPI.ActionFilters
{
    public class AuthenticationFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            IEnumerable<String> header;
            actionContext.Request.Headers.TryGetValues("auth", out header);
            if (header.Any())
            {
                if (header.First().Equals("YY61W-88IIN")) return;
            } 

            var response = actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Bad Auth");
            actionContext.Response = response;
        }
    }
}
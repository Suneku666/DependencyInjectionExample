using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using ExampleAPI.ActionFilters;
using ExampleAPI.ViewModels;
using ExampleCommon.Exceptions;
using ExampleService;

namespace ExampleAPI.Controllers
{
    public class ExampleController : ApiController
    {
        private IExampleService _ExampleService;

        public ExampleController(IExampleService ExampleSercive)
        {
            this._ExampleService = ExampleSercive;
        }

        [System.Web.Http.HttpPost]
        [AuthenticationFilter]
        public HttpStatusCode StatusCheck(StatusCheckRequestViewModel payload)
        {
            try
            {
                _ExampleService.StatusCheck(payload);
            }catch(ExampleException e)
            {
                return e.GetStatusCode();
            }

            return HttpStatusCode.OK;
        }



        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
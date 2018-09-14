using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using ExampleAPI.ActionFilters;
using ExampleAPI.ViewModels;
using ExampleCommon.Exceptions;
using ExampleCommon.Interfaces;

namespace ExampleAPI.Controllers
{
    public class ExampleController : ApiController
    {
        private ExampleService.ExampleService _ExampleService;

        public ExampleController()
        {
            this._ExampleService = new ExampleService.ExampleService();
        }

        [System.Web.Http.HttpPost]
        [AuthenticationFilter]
        public object StatusCheck(StatusCheckRequestViewModel payload)
        {
            try
            {
               return _ExampleService.StatusCheck(payload);
            }catch(ExampleException e)
            {
                return e.GetStatusCode();
            }
        }



        // GET api/<controller>
        public object Get(StatusCheckRequestViewModel payload)
        {
            try
            {
                return _ExampleService.StatusCheck(payload);
            }
            catch (ExampleException e)
            {
                return "OBJECTION!";
            }
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
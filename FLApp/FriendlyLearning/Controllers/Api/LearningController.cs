using FriendlyLearning.Models.cs.Domain;
using FriendlyLearning.Models.cs.Responses;
using FriendlyLearning.Services.Interfaces;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FriendlyLearning.Web.Controllers.Api
{
    [RoutePrefix("api/learning/users")][AllowAnonymous]
    public class LearningController : ApiController
    {
        private IUsersService usersService;
        public LearningController (IUsersService usersService)
        {
            this.usersService = usersService;
        }
        // GET: api/learning/{msg}
        [Route("{msg}"), HttpGet]
        public string Get(int id)
        {
            return "value";
        }

        // GET Default
        [Route, HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, "NOICE!");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        //GET all
        [Route("all"), HttpGet]
        public HttpResponseMessage SelectAll()
        {
            try
            {
                ItemsResponse<Users> resp = new ItemsResponse<Users>();
                resp.Items = usersService.SelectAll();
                return Request.CreateResponse(HttpStatusCode.OK, resp);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // GET by id
        [Route("{int:id}"), HttpGet]
        public HttpResponseMessage SelectById(int id)
        {
            try
            {
                ItemResponse<Users> resp = new ItemResponse<Users>();
                resp.Item = usersService.SelectById(id);
                return Request.CreateResponse(HttpStatusCode.OK, resp);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        // POST: api/Default
        [Route, HttpPost]
        public HttpResponseMessage Post(Users model)
        {
            try
            {
                int id = usersService.Insert(model);

                ItemResponse<int> resp = new ItemResponse<int>();
                resp.Item = id;

                return Request.CreateResponse(HttpStatusCode.OK, resp);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // PUT: api/Default/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Default/5
        [Route("{int:id}"), HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                usersService.Delete(id);
                SuccessResponse resp = new SuccessResponse();
                return Request.CreateResponse(HttpStatusCode.OK, resp);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}

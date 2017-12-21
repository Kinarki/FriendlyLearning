using FriendlyLearning.Models.cs.Domain;
using FriendlyLearning.Models.cs.Responses;
using FriendlyLearning.Models.cs.ViewModels;
using FriendlyLearning.Services;
using FriendlyLearning.Services.Interfaces;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FriendlyLearning.Web.Controllers.Api
{
    [RoutePrefix("api/users")]
    [AllowAnonymous]
    public class LearningController : ApiController
    {
        private IUsersService usersService = new UsersService();

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
        [Route("{id:int}"), HttpGet]
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

        // POST 
        [Route, HttpPost]
        public HttpResponseMessage Post(NewUser model)
        {
            try
            {
                UsersService user = new UsersService();
                ItemResponse<int> resp = new ItemResponse<int>();
                resp.Item = user.Insert(model);

                return Request.CreateResponse(HttpStatusCode.OK, resp);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // PUT
        [Route("{id:int}"), HttpPut]
        public HttpResponseMessage Put(int id, Users model)
        {
            try
            {
                usersService.Update(model);
                SuccessResponse resp = new SuccessResponse();
                return Request.CreateResponse(HttpStatusCode.OK, resp);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // DELETE by id
        [Route("{id:int}"), HttpDelete]
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

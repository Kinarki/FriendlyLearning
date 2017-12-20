using FriendlyLearning.Models.cs.Domain;
using FriendlyLearning.Models.cs.Responses;
using FriendlyLearning.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FriendlyLearning.Controllers.Api
{
    [RoutePrefix("api/numbers"), AllowAnonymous]
    public class NumbersController : ApiController
    {
        // GET all
        [Route, HttpGet]
        public HttpResponseMessage SelectAll()
        {
            try
            {
                ItemsResponse<NumbersModel> resp = new ItemsResponse<NumbersModel>();
                resp.Items = NumbersService.SelectAll();
                return Request.CreateResponse(HttpStatusCode.OK, resp);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
using FriendlyLearning.Services.Interfaces;
using FriendlyLearning.Services;
using System.Collections.Generic;
using System.Web.Http;
using System;
using System.Net;
using System.Net.Http;
using FriendlyLearning.Models.cs.Domain;
using FriendlyLearning.Models.cs.Responses;

namespace FriendlyLearning.Web.Controllers.Api
{
    [RoutePrefix("api/scrape"), AllowAnonymous]
    public class ScraperController : ApiController
    {
        // GET: all
        [Route, HttpGet]
        public HttpResponseMessage GetAll()
        {
            try
            {
                ItemResponse<AnimalModels> resp = new ItemResponse<AnimalModels>();
                ScraperService svc = new ScraperService();
                resp.Item = svc.GetAll();

                return Request.CreateResponse(HttpStatusCode.OK, resp);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}

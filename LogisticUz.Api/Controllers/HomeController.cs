// =================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
// =================================================

using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace LogisticUz.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string> Get() =>
            Ok("Hello Mario, the princess is in another castle.");
    }
}
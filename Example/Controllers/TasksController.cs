using Liquid.Activation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Tasks.Controllers
{
    [Route("/")]
    [Authorize]
    public class TasksController : LightController
    {
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Endpoint()
        {
            throw new NotImplementedException();
        }
    }
}
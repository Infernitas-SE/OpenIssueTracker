using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

using InfernitasSE.Projects.OpenIssueTracker.Backend.Models;

namespace InfernitasSE.Projects.OpenIssueTracker.Backend.Controllers
{
    [Route("api/security")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        [HttpPost]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public ActionResult Login([FromForm] WebCredential creds)
        { 
            if(creds == null)
            {
                return Problem("No credentials provided!", default, 401);
            }
            /*
             * LOGIN PROCESS
             */
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult Logout() => Ok();

        [HttpGet]
        [Produces("application/json", Type = typeof(bool))]
        public ActionResult<bool> IsAuthenticated() => this.HttpContext.User.Identity.IsAuthenticated;
    }
}
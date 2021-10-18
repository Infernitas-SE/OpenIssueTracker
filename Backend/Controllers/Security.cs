namespace InfernitasSE.Projects.OpenIssueTracker.Backend.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using InfernitasSE.Projects.OpenIssueTracker.Backend.Models;

    /// <summary>
    /// Security Controller (User, IAM).
    /// </summary>
    [Route("api/security")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        /// <summary>
        /// Login EP.
        /// </summary>
        /// <param name="creds">Credentials</param>
        [HttpPost]
        [Route("/login")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public ActionResult Login([FromForm] WebCredential creds)
        {
            if (creds == null)
            {
                return this.Problem("No credentials provided!", default, 401);
            }
            /*
             * LOGIN PROCESS
             */
            return this.Ok();
        }

        /// <summary>
        /// Logout EP
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/logout")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult Logout() => this.Ok();

        /// <summary>
        /// Check if User is Authenticated
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/isAuthenticated")]
        [Produces("application/json", Type = typeof(bool))]
        public ActionResult<bool> IsAuthenticated() => this.HttpContext.User.Identity.IsAuthenticated;
    }
}

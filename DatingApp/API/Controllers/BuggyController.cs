using API.Data;
using API.Entites;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController : BaseApiController
    {
        private readonly DataContext __contex;
        public BuggyController(DataContext _contex)
        {
            __contex = _contex;

        }
       [Authorize]
        [HttpGet("auth")]
        public ActionResult<string> GetSecret()
        {
            return "Secret taxt";
        }
       // [Authorize]
        [HttpGet("not-found")]
        public ActionResult<AppUser> GetNotFound()
        {
            var thing = __contex.Users.Find(-1);
            if (thing == null) return NotFound();
            return NotFound(thing);
        }
        //[Authorize]
        [HttpGet("server-error")]
        public ActionResult<string> GetServerError()
        {
            var thing = __contex.Users.Find(-1);
            var thingToReturn = thing.ToString();
            return thingToReturn;
        }
       // [Authorize]
        [HttpGet("bad-request")]
        public ActionResult<string> GetBadRequest()
        {
            return BadRequest("This was not a good request");
        }
    }
}
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SimpleApi.Models;

namespace SimpleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MyControllerBase : ControllerBase
    {
        protected readonly SimpleApiContext _context;

        public MyControllerBase (SimpleApiContext context)
        {
            _context = context;
        }
    }
}

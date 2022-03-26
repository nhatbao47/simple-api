namespace SimpleApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using SimpleApi.Entities;
using AuthorizeAttribute = SimpleApi.Helpers.AuthorizeAttribute;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class MyControllerBase : ControllerBase
{
    protected readonly SimpleApiContext _context;

    public MyControllerBase (SimpleApiContext context)
    {
        _context = context;
    }
}

using Microsoft.AspNetCore.Mvc;
using PlaygroundBE.Data;
using PlaygroundBE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaygroundBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserContext _userContext;

        public UsersController(UserContext userContext)
        {
            _userContext = userContext ?? throw new ArgumentNullException(nameof(userContext));
            Console.WriteLine("Hello");
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            var users = _userContext.User.ToList();
            return users;
        }
    }
}

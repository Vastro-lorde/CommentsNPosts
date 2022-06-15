using CommentsNPosts.Models;
using CommentsNPosts.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CommentsNPosts.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _userRepo;
        public UserController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet("all")]
        public async Task<IEnumerable<User>> GetUsers()
        {
            var user = await _userRepo.GetUsers();
            if (user == null)
            {
                return Enumerable.Empty<User>();
            }
            return await _userRepo.GetUsers();
        }

        [HttpPost("signup")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> SignUp(User user)
        {
            var Result = await _userRepo.CreateUser(user);
            return Result? Ok(await _userRepo.GetById(user.UserId)) : NotFound();
        }

        [HttpGet("id")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> GetUser(Guid id)
        {
            var Result = await _userRepo.GetById(id);
            return Result != null ? Ok(Result) : NotFound();
        }
    }
}
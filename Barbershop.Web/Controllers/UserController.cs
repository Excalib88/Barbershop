using Microsoft.AspNetCore.Mvc;

namespace Barbershop.Web.Controllers
{
	[ApiController]
	[Route("users")]
	public class UserController: ControllerBase
	{
		private readonly IUserService _userService;

		public UserController(IUserService userService)
		{
			_userService = userService;
		}

		[HttpGet("{id}")]
		public IActionResult GetUserById(int id)
		{
			if (id == 0)
			{
				return BadRequest("Invalid id");
			}
			
			var user = _userService.GetUserById(1);

			if (user == null)
			{
				return NotFound("User not found");
			}
			
			return Ok(user);
		}
	}
}

namespace printing_om_and_pm_system_app.Controllers
{
	[Route("api/users")]
	[ApiController]
	[Authorize]
	public class UserController : ControllerBase
	{
		private readonly IUserRepository _userRepo;
		private readonly IMapper _mapper;
		private readonly IConfiguration _configuration;

		public UserController(IUserRepository userRepo, IMapper mapper, IConfiguration configuration)
		{
			_userRepo = userRepo;
			_mapper = mapper;
			_configuration = configuration;
		}

		[HttpPost("login"), AllowAnonymous]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status401Unauthorized)]
		public async Task<ActionResult<string>> Login(UserLoginDto userLogin)
		{
			var user = _mapper.Map<User>(userLogin);
			var userFromDatabase = await _userRepo.GetUserByEmail(user.Email);

			if (userFromDatabase == null)
			{
				return NotFound("Error: Not found!");
			}
			return Ok("Succesful login");
		}

	}
}


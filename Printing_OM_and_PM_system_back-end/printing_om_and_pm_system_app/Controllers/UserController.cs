
using System.Text.RegularExpressions;

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
		private readonly IUserService _userService;

		public UserController(IUserRepository userRepo, IMapper mapper, IConfiguration configuration, IUserService userService)
		{
			_userRepo = userRepo;
			_mapper = mapper;
			_configuration = configuration;
			_userService = userService;
		}

		// LOGIN
		[HttpGet("login"), AllowAnonymous]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status401Unauthorized)]
		public async Task<ActionResult<string>> Login(UserLoginDTO userLogin)
		{
			var user = _mapper.Map<User>(userLogin);
			var userFromDatabase = await _userRepo.GetUserByEmail(user.Email);

			if (userFromDatabase == null)
			{
				return NotFound("Error: Not found!");
			}
			return Ok("Succesful login");
		}

		// REGISTRATION
        [HttpPost("registration"), AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult> Registration(UserRegistrationDTO userRegistration)
        {
            var user = _mapper.Map<User>(userRegistration);

			// Validate input is not null or empty
			if (string.IsNullOrEmpty(user.UserName)
				|| string.IsNullOrEmpty(user.FirstName)
                || string.IsNullOrEmpty(user.LastName)
                || string.IsNullOrEmpty(user.Password)
                || string.IsNullOrEmpty(user.Email))
			{
				return BadRequest();
			}
			// Validate password length
			if (user.Password.Length < 8)
			{
				return BadRequest("Error: Password must be at least 8 charachters long.");
			}
			// Validate e-mail address
			if (!_userService.RegexEmailCheck(user.Email))
			{
				return Conflict("Error: E-mail address already in use.");
			}
			// Check for duplicates entries
			var usernameExists = _userRepo.UsernameExists(user.UserName);
			if (usernameExists)
			{
				return Conflict("Error: Username already exists.");
			}

			var emailExists = _userRepo.EmailExists(user.Email);
			if (emailExists)
			{
				return Conflict("Error: E-mail address already in use.");
			}

			// Insert User
			try
			{
				_userRepo.AddUser(user);
				await _userRepo.SaveAsync();
				return Ok("User saved");
			}
			catch (Exception ex)
			{
				return Problem(ex.Message);
			}
        }

		// ALL USERS
		[HttpGet("get-all-user"), AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<IEnumerable<UserDTO>>> GetAllUsers()
		{
			var users = await _userRepo.GetAll();

			var userDtoList = _mapper.Map<IEnumerable<UserDTO>>(users);

			return Ok(userDtoList);
		}
    }
}



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

		public UserController(IUserRepository userRepo, IMapper mapper, IConfiguration configuration)
		{
			_userRepo = userRepo;
			_mapper = mapper;
			_configuration = configuration;
		}

		[HttpGet("login"), AllowAnonymous]
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
			if (!RegexEmailCheck(user.Email))
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

        static bool RegexEmailCheck(string input)
        {
            return Regex.IsMatch(input, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

    }
}


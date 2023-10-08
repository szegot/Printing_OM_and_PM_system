
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using printing_om_and_pm_system_app.Models;

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
		private readonly IUserUpdateRepository _userUpdateRepo;

		public UserController(IUserRepository userRepo, IMapper mapper, IConfiguration configuration, IUserService userService, IUserUpdateRepository userUpdateRepo)
		{
			_userRepo = userRepo;
			_mapper = mapper;
			_configuration = configuration;
			_userService = userService;
			_userUpdateRepo = userUpdateRepo;

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

		// GET USER BY ID
		[HttpGet("{id}"), AllowAnonymous]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<UserDTO>> GetUserById(int userId)
		{
			var user = await _userRepo.GetUserById(userId);

			if (user == null)
			{
				return NotFound();
			}
			var userDTO = _mapper.Map<UserDTO>(user);

			return Ok(userDTO);
		}

		// CHANGE USER DATA BY ID
		[HttpPatch("{userId}"), AllowAnonymous]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult> UpdateUser(int userId, UserUpdateDTO userUpdate)
		{
			var existingUser = await _userUpdateRepo.GetUserById(userId);

			if (existingUser == null)
			{
				return NotFound();
			}

			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			var propertiesToUpdate = new List<string>
			{
				"UserName",
				"FirstName",
				"LastName",
				"Email",
				"Password",
				"BillingAddress",
				"BillingCity",
				"BillingZipCode"
			};

			foreach (var propertyName in propertiesToUpdate)
			{
				var propertyValue = typeof(UserUpdateDTO).GetProperty(propertyName)?.GetValue(userUpdate, null);

				if (propertyValue != null && !string.IsNullOrEmpty(propertyValue.ToString()))
				{
					if (propertyName == "BillingZipCode")
					{
						if (int.TryParse(propertyValue.ToString(), out int zipCode))
						{
							existingUser.BillingZipCode = zipCode;
						}
						else
						{
							ModelState.AddModelError(propertyName, "Invalid zip code format.");
							return BadRequest(ModelState);
						}
					}
					else
					{
						typeof(User).GetProperty(propertyName)?.SetValue(existingUser, propertyValue, null);
					}
				}
				else
				{
					continue;
				}
			}

			await _userUpdateRepo.SaveChangesAsync();

			return Ok(existingUser);
		}

		// DELETE USER BY ID
		[HttpDelete("{userId}"), AllowAnonymous]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult> RemoveUser(int userID)
		{
            var user = await _userRepo.GetUserById(userID);

            if (user == null)
            {
                return NotFound();
            }

			_userRepo.DeleteUser(user);
			await _userRepo.SaveAsync();

			return Ok(user);
        }
    }
}

//{
//	"orders": [],
//    "lazyLoader": { },
//    "user_ID": 3,
//    "userName": "toth.peter",
//    "firstName": "Toth",
//    "lastName": "Peter",
//    "email": "toth.peter@example.com",
//    "password": "69030450",
//    "billingAddress": "Tisza Lajos korut 18.",
//    "billingCity": "Szeged",
//    "billingZipCode": 5678,
//    "roles": 0
//}
using printing_om_and_pm_system_app.Models;

namespace printing_om_and_pm_system_app.Repositories
{
	public class UserRepository : IUserRepository
	{
		private readonly ApplicationDbContext _userContext;
		public UserRepository(ApplicationDbContext userContext)
		{
			_userContext = userContext;
		}

		public Task<User> GetUserByEmail(string email)
		{
			return _userContext.Users.FirstOrDefaultAsync(u => u.Email == email);
		}

		public void AddUser(User user)
		{
			_userContext.Users.Add(user);
		}
		public Task SaveAsync()
		{
			return _userContext.SaveChangesAsync();
		}
		public bool UsernameExists(string username)
		{
			return _userContext.Users.Any(u => u.UserName == username);
		}
        public bool EmailExists(string email)
        {
            return _userContext.Users.Any(u => u.Email == email);
        }
		public Task<List<User>> GetAll()
		{
			return _userContext.Users.ToListAsync();
		}
		public Task<User?> GetUserById(int id)
		{
			return _userContext.Users.FirstOrDefaultAsync(u => u.User_ID == id);
		}
		public void DeleteUser(User user)
		{
			_userContext.Users.Remove(user);
		}
    }
}


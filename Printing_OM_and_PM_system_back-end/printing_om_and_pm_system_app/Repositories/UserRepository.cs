using printing_om_and_pm_system_app.Models;

namespace printing_om_and_pm_system_app.Repositories
{
	public class UserRepository : IUserRepository
	{
		private readonly ApplicationDbContext _appDb;
		public UserRepository(ApplicationDbContext context)
		{
			_appDb = context;
		}
		public Task<User> GetUserByEmail(string email)
		{
			return _appDb.Users.FirstOrDefaultAsync(u => u.Email == email);
		}
	}
}


using System;
namespace printing_om_and_pm_system_app.Repositories
{
	public class UserUpdateRepository : IUserUpdateRepository
	{
        private readonly ApplicationDbContext _userContext;
        public UserUpdateRepository(ApplicationDbContext userContext)
        {
            _userContext = userContext;
        }

        public Task<User?> GetUserById(int id)
        {
            return _userContext.Users.FirstOrDefaultAsync(u => u.User_ID == id);
        }
        public Task SaveChangesAsync()
        {
            return _userContext.SaveChangesAsync();
        }
    }
}


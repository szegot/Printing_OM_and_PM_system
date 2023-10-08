using System;
namespace printing_om_and_pm_system_app.Repositories
{
	public interface IUserUpdateRepository
	{
        Task<User?> GetUserById(int id);
        Task SaveChangesAsync();
    }
}


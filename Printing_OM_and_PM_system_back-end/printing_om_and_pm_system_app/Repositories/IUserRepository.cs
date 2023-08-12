namespace printing_om_and_pm_system_app.Repositories
{
	public interface IUserRepository
	{
		Task<User> GetUserByEmail(string email);
	}
}


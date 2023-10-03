namespace printing_om_and_pm_system_app.Repositories
{
	public interface IUserRepository
	{
		Task<User> GetUserByEmail(string email);
		void AddUser(User user);
		Task SaveAsync();
		bool UsernameExists(string username);
		bool EmailExists(string email);
		Task<List<User>> GetAll();
    }
}
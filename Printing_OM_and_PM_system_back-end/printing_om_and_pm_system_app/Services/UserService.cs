using System.Text.RegularExpressions;

namespace printing_om_and_pm_system_app.Services
{
	public class UserService : IUserService
	{
        public bool RegexEmailCheck(string input)
        {
            return Regex.IsMatch(input, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
    }
}


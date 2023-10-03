namespace printing_om_and_pm_system_app.DTO.Incoming
{
	public class UserLoginDTO
	{
		[JsonPropertyName("email")]
		[StringLength(maximumLength: 255, MinimumLength = 3)]
		[EmailAddress]
		public string Email { get; set; }

		[JsonPropertyName("password")]
		[StringLength(maximumLength: 64, MinimumLength = 8)]
		public string Password { get; set; }
	}
}


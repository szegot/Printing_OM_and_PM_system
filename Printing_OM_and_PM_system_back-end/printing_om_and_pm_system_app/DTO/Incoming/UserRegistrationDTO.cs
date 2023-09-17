namespace printing_om_and_pm_system_app.DTO.Incoming
{
	public class UserRegistrationDTO
	{
		[JsonPropertyName("username")]
		[StringLength(maximumLength: 255, MinimumLength = 1)]
		public string UserName { get; set; }

        [JsonPropertyName("firstname")]
        [StringLength(maximumLength: 50, MinimumLength = 1)]
        public string FirstName { get; set; }

        [JsonPropertyName("lastname")]
        [StringLength(maximumLength: 50, MinimumLength = 1)]
        public string LastName { get; set; }

        [JsonPropertyName("email")]
        [StringLength(maximumLength: 255, MinimumLength = 1)]
        public string Email { get; set; }

        [JsonPropertyName("password")]
        [StringLength(maximumLength: 64, MinimumLength = 8)]
        public string Password { get; set; }

        [JsonPropertyName("billingaddress")]
        [StringLength(maximumLength: 255, MinimumLength = 1)]
        public string BillingAddress { get; set; }

        [JsonPropertyName("billingcity")]
        [StringLength(maximumLength: 255, MinimumLength = 1)]
        public string BillingCity { get; set; }

        [JsonPropertyName("billingzipcode")]
        [MaxLength(4)]
        public string BillingZipCode { get; set; }
    }
}
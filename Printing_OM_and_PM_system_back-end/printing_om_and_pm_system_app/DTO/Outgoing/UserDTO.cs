namespace printing_om_and_pm_system_app.DTO.Outgoing
{
	public class UserDTO
	{
        [JsonPropertyName("id")]
        public int User_ID { get; set; }

        [JsonPropertyName("userName")]
        public string UserName { get; set; }

        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("billingAddress")]
        public string BillingAddress { get; set; }

        [JsonPropertyName("billingCity")]
        public string BillingCity { get; set; }

        [JsonPropertyName("billingZipCode")]
        public int BillingZipCode { get; set; }
    }
}
using System;
namespace printing_om_and_pm_system_app.DTO.Incoming
{
	public class UserUpdateDTO
	{
        [JsonPropertyName("username")]
        [StringLength(maximumLength: 255)]
        public string UserName { get; set; }

        [JsonPropertyName("firstname")]
        [StringLength(maximumLength: 50)]
        public string FirstName { get; set; }

        [JsonPropertyName("lastname")]
        [StringLength(maximumLength: 50)]
        public string LastName { get; set; }

        [JsonPropertyName("email")]
        [StringLength(maximumLength: 255)]
        public string Email { get; set; }

        [JsonPropertyName("password")]
        [StringLength(maximumLength: 64)]
        public string Password { get; set; }

        [JsonPropertyName("billingaddress")]
        [StringLength(maximumLength: 255)]
        public string BillingAddress { get; set; }

        [JsonPropertyName("billingcity")]
        [StringLength(maximumLength: 255)]
        public string BillingCity { get; set; }

        [JsonPropertyName("billingzipcode")]
        [MaxLength(4)]
        public string BillingZipCode { get; set; }
    }
}


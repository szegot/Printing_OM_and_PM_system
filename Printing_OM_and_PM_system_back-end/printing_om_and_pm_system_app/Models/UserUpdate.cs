namespace printing_om_and_pm_system_app.Models
{
	public class UserUpdate
	{
        [StringLength(maximumLength: 255, MinimumLength = 1)]
        public string UserName { get; set; }

        [StringLength(maximumLength: 50, MinimumLength = 1)]
        public string FirstName { get; set; }

        [StringLength(maximumLength: 50, MinimumLength = 1)]
        public string LastName { get; set; }

        [StringLength(maximumLength: 255, MinimumLength = 1)]
        public string Email { get; set; }

        [StringLength(maximumLength: 64, MinimumLength = 8)]
        public string Password { get; set; }

        [StringLength(maximumLength: 255, MinimumLength = 1)]
        public string BillingAddress { get; set; }

        [StringLength(maximumLength: 255, MinimumLength = 1)]
        public string BillingCity { get; set; }

        [MaxLength(4)]
        public int? BillingZipCode { get; set; }
    }
}


namespace printing_om_and_pm_system_app.Models
{
    public enum UserRoles
    {
        Admin,
        Staff,
        Customer
    }

    public class User
    {
        [Key]
        public int User_ID { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [StringLength(maximumLength: 255, MinimumLength = 1)]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(maximumLength: 50, MinimumLength = 1)]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(maximumLength: 50, MinimumLength = 1)]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required.")]
        [StringLength(maximumLength: 255, MinimumLength = 1)]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(maximumLength: 64, MinimumLength = 8)]
        public string Password { get; set; } = string.Empty;

        [StringLength(maximumLength: 255, MinimumLength = 1)]
        public string BillingAddress { get; set; } = string.Empty;

        [StringLength(maximumLength: 255, MinimumLength = 1)]
        public string BillingCity { get; set; } = string.Empty;

        [MaxLength(4)]
        public int BillingZipCode { get; set; }

        public UserRoles Roles { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}


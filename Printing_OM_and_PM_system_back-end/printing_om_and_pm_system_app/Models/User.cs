namespace printing_om_and_pm_system_app.Models
{
    public class User
    {
        [Key]
        public int User_ID { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [StringLength(maximumLength: 255, MinimumLength = 1)]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(maximumLength: 50, MinimumLength = 1)]
        public string First_Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(maximumLength: 50, MinimumLength = 1)]
        public string Last_Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required.")]
        [StringLength(maximumLength: 255, MinimumLength = 1)]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(maximumLength: 64, MinimumLength = 1)]
        public string Password { get; set; } = string.Empty;

        [MaxLength(255)]
        public string Billing_Address { get; set; } = string.Empty;

        [MaxLength(255)]
        public string Billing_City { get; set; } = string.Empty;

        [MaxLength(20)]
        public int Billing_Zipcode { get; set; }

        public bool IsAdmin { get; set; } = false;

        public virtual ICollection<Order> Orders { get; set; }
    }
}


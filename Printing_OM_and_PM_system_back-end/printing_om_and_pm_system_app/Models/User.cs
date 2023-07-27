namespace printing_om_and_pm_system_app.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Username is required.")]
        public string UserName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; } = string.Empty;
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Billing Adress is required.")]
        public string Billing_Adress { get; set; } = string.Empty;
        public bool IsAdmin { get; set; } = false;
        
    }
}


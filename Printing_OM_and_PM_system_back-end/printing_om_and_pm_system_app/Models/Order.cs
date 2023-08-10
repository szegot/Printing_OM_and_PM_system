using System;
namespace printing_om_and_pm_system_app.Models
{
	public class Order
	{
        [Key]
        public int Order_ID { get; set; }

        public int User_ID { get; set; }
        public User User { get; set; }

        public int Price { get; set; }

        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }

        public bool Status { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}


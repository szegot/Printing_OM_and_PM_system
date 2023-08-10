using System;
namespace printing_om_and_pm_system_app.Models
{
	public class Item
	{
        [Key]
        public int Item_ID { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public int Service_ID { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public int Price { get; set; }
        public int Size { get; set; }
        public bool Status { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<ItemService> ItemServices { get; set; }
    }
}


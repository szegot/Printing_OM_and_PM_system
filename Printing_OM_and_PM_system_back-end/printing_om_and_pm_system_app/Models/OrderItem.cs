using System;
namespace printing_om_and_pm_system_app.Models
{
	public class OrderItem
	{
        [Key]
        public int Order_Item_ID { get; set; }

        public int Order_ID { get; set; }
        public virtual Order Orders { get; set; }

        public int Item_ID { get; set; }
        public virtual Item Items { get; set; }
    }
}


using System;
namespace printing_om_and_pm_system_app.Models
{
	public class ItemService
	{
        [Key]
        public int Item_Service_ID { get; set; }

        public int Item_ID { get; set; }
        public virtual Item Items { get; set; }

        public int Service_ID { get; set; }
        public virtual Service Services { get; set; }

    }
}


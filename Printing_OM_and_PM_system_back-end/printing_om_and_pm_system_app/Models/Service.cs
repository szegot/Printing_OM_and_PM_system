using System;
namespace printing_om_and_pm_system_app.Models
{
	public class Service
    {
        [Key]
        public int Service_ID { get; set; }

        public int Machine_ID { get; set; }
        public virtual Machine Machines { get; set; }

        public int Material_ID { get; set; }
        public virtual Material Materials { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        public int Price { get; set; }
        public int Completion_Time { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<ItemService> ItemServices { get; set; }
        public virtual ICollection<ProcessService> ProcessServices { get; set; }
    }
}


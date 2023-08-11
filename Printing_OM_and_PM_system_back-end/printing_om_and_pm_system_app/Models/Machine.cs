using System;
namespace printing_om_and_pm_system_app.Models
{
	public class Machine
	{
        [Key]
        public int Machine_ID { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        public int Capacity { get; set; }
        public int Status { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}


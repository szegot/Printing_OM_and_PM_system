using System;
namespace printing_om_and_pm_system_app.Models
{
	public class Process
	{
        [Key]
        public int Process_ID { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        public bool Status { get; set; }

        public virtual ICollection<ProcessService> ProcessServices { get; set; }
    }
}


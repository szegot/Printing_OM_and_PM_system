using System;
namespace printing_om_and_pm_system_app.Models
{
	public class ProcessService
	{
        [Key]
        public int Process_Service_ID { get; set; }

        public int Process_ID { get; set; }
        public Process Process { get; set; }

        public int Service_ID { get; set; }
        public Service Service { get; set; }

        public bool Status { get; set; }
    }
}


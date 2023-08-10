using System;
namespace printing_om_and_pm_system_app.Models
{
	public class Material
	{
        [Key]
        public int Material_ID { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        public int Volume { get; set; }
        public int Price { get; set; }
        public int Inventory { get; set; }

        public ICollection<Service> Services { get; set; }
    }
}


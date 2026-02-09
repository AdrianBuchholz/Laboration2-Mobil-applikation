using System.Collections.Generic;

namespace MobilApplikation_Grupp_3.Models
{
    public class Concert
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        // Navigation properties
        public ICollection<Performance> Performances { get; set; } = new List<Performance>();
    }
}

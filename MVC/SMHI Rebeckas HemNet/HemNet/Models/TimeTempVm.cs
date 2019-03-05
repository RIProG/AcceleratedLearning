using System.Collections.Generic;

namespace HemNet_Azure.Models
{
    public class TimeTempVm
    {
        public TimeTemp TimeTemp { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public List<TimeTemp> TimeTemps { get; set; }
    }
}

    using System.ComponentModel.DataAnnotations;

namespace raceday_api.models
{//start of namespace
    public class Race_event
    {//start of class

        public int id { get; set; }

        [Required, MaxLength(200)] public string name { get; set; } = string.Empty;
        [Required, MaxLength(2000)] public string description { get; set; } = string.Empty;
        public DateTime date { get; set; }
        [Required, MaxLength(200)] public string location { get; set; } = string.Empty;
        public decimal distance_km { get; set; }
        public event_type event_type { get; set; }

        //the organiser who created the event
        public int organiser_id { get; set; }
        public user? organiser { get; set; }

        public List<event_category> categories { get; set; } = new();
        public List<enrolment> enrolments { get; set; } = new();

    }//end of class
}//end of namespace

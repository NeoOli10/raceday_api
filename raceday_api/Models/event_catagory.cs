using System.ComponentModel.DataAnnotations;

namespace raceday_api.models
{//start of namespace

    //an age or distance category inside one event
    //e.g. "Under 20" or "21km"
    public class event_category
    {//start of class

        public int id { get; set; }

        [Required, MaxLength(100)] public string name { get; set; } = string.Empty;
        public int? min_age { get; set; }
        public int? max_age { get; set; }
        public decimal? distance_km { get; set; }

        public int event_id { get; set; }
        public Race_event? race_event { get; set; }

    }//end of class
}//end of namespace

using System.ComponentModel.DataAnnotations;

namespace raceday_api.models
{//start of namespace

    //links a participant, an event and the category they picked
    public class enrolment
    {//start of class

        public int id { get; set; }
        public DateTime enrolled_at { get; set; } = DateTime.UtcNow;

        public int user_id { get; set; }
        public user? user { get; set; }

        public int event_id { get; set; }
        public Race_event? race_event { get; set; }

        public int category_id { get; set; }
        public event_category? category { get; set; }

        public race_result? race_result { get; set; }

    }//end of class
}//end of namespace

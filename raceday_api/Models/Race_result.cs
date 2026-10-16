using System.ComponentModel.DataAnnotations;

namespace raceday_api.models
{//start of namespace

    //one finish time and position per enrolment
    //captured by the organiser after the event
    public class race_result
    {//start of class

        public int id { get; set; }
        public TimeSpan finish_time { get; set; }
        public int position { get; set; }
        public DateTime captured_at { get; set; } = DateTime.UtcNow;

        public int enrolment_id { get; set; }
        public enrolment? enrolment { get; set; }

    }//end of class
}//end of namespace
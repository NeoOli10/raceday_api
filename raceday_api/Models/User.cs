
using System.ComponentModel.DataAnnotations;

namespace raceday_api.models
{//start of namespace
    public class user
    {//start of class

        public int id { get; set; }

        [Required, MaxLength(100)] public string first_name { get; set; } = string.Empty;
        [Required, MaxLength(100)] public string last_name { get; set; } = string.Empty;
        [Required, MaxLength(256)] public string email { get; set; } = string.Empty;

        //the hashed password, the real password is NEVER stored
        [Required] public string password_hash { get; set; } = string.Empty;

        //"Organiser" or "Participant" (see the roles class)
        [Required, MaxLength(20)] public string role { get; set; } = roles.participant;

        public DateTime date_of_birth { get; set; }
        [MaxLength(20)] public string? phone_number { get; set; }
        public DateTime created_at { get; set; } = DateTime.UtcNow;

        //events this user organises and events this user entered
        public List<Race_event> organised_events { get; set; } = new();
        public List<enrolment> enrolments { get; set; } = new();

    }//end of class
}//end of namespace

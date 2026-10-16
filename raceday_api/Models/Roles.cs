namespace raceday_api.models
{//start of namespace

    //the two kinds of event types an organiser can pick
    public enum event_type { run, walk, cycle }

    //role names kept in one place so we never mistype a string
    public static class roles
    {//start of class

        public const string organiser = "Organiser";
        public const string participant = "Participant";

    }//end of class
}//end of namespace

using System;

namespace Module6
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthday { get; set; }
        public Sport FavoriteSport { get; set; }
        public Gender Gender { get; set; }

    }

    public enum Sport
    {
        Tennis, Rugby, Soccer, Hurling, Squash
    }

    public enum Gender
    {
        Male, Female, Other
    }
}
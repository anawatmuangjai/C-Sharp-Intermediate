using System;

namespace Properties
{
    public class Person
    {
        // Auto implement properties (Auto implement private fields)
        public string Name { get; set; }
        public string UserName { get; set; }
        public DateTime Birthdate { get; private set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var year = timeSpan.Days / 365;

                return year;
            }
        }
    }
}

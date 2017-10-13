using System;

namespace AccessModifiers
{
    public class Person
    {
        // Encapsulation 
        // Define fields as private
        // Provide getter/setter methods as public
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
}

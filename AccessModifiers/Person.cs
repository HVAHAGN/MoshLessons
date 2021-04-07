using System;

namespace AccessModifiers
{
    public class Person
    {
        private DateTime _birthdate;
        public void SetBirthDate(DateTime birthDate)
        {
            _birthdate = birthDate;
        }
        public DateTime GetBirtDate()
        {
            return _birthdate;
        }
        public override string ToString()
        {
            return "Hello Vahagn";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebScraper
{
    class PersonBuilder
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private int _eyeColour;
        private int _hairColour;

        public PersonBuilder()
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            _firstName = "John";
            _lastName = "Smith";
            _age = 30;
            _eyeColour = 145;
            _hairColour = 230;
        }

        public PersonBuilder WithFirstName(string firstName)
        {
            _firstName = firstName;
            return this;
        }

        public PersonBuilder WithLastName(string lastName)
        {
            _lastName = lastName;
            return this;
        }

        public PersonBuilder WithAge(int age)
        {
            _age = age;
            return this;
        }

        public PersonBuilder WithEyeColour(int eyeColour)
        {
            _eyeColour = eyeColour;
            return this;
        }

        public PersonBuilder WithHairColour(int hairColour)
        {
            _hairColour = hairColour;
            return this;
        }

        public Person Build()
        {
            Person person = new Person(_firstName, _lastName, _age, _eyeColour, _hairColour);
            return person;

        }
    }
}

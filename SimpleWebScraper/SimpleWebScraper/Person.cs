﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebScraper
{
    class Person
    {
        public Person(string FirstName, string SecondName, int Age, int EyeColour, int HairColour)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.EyeColour = EyeColour;
            this.HairColour = HairColour;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int EyeColour { get; set; }
        public int HairColour { get; set; }
    }
}

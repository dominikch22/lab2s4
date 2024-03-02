using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2s4
{
    public class Person : EventArgs, ICloneable
    {
        public int Id;
        public string Name;
        public string Surname;
        public DateTime BirthDate;
        public string City;

        public Person() {
            Random random = new Random();
            Id = random.Next();
        }
        public Person(int id, string name, string surname, string birthDate, string city) {
            Id = id;
            Name = name;
            Surname = surname;
            BirthDate = DateTime.Parse(birthDate);
            City = city;
        }

        public Person(string name, string surname, string birthDate, string city)
        {
            Random random = new Random();
            Id = random.Next();
            Name = name;
            Surname = surname;
            BirthDate = DateTime.Parse(birthDate);
            City = city;
        }

        public override string ToString()
        {
            return $"{Name} {Surname} {BirthDate.Day}.{BirthDate.Month}.{BirthDate.Year} zamieszkaly/a: {City}";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}

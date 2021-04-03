using System;

namespace Queries.Entities
{
    public class Employee
    {
        public int Id { private set; get; }
        public int StationId { private set; get; }
        public string SurName { private set; get; }
        public string Name { private set; get; }
        public string Gender { private set; get; }
        public DateTime BirthDate { private set; get; }
        public string Position { private set; get; }
        public int Salary { private set; get; }

        public Employee(int staff_id, int station_id, string surname, string name, string gender, DateTime birthdate, string function, int salary)
        {
            Id = staff_id;
            StationId = station_id;
            SurName = surname;
            Name = name;
            Gender = gender;
            BirthDate = birthdate;
            Position = function;
            Salary = salary;
        }

        public Employee(int station_id, string surname, string name, string gender, DateTime birthdate, string function, int salary)
        {
            StationId = station_id;
            SurName = surname;
            Name = name;
            Gender = gender;
            BirthDate = birthdate;
            Position = function;
            Salary = salary;
        }

        public Employee(string surname, string name, string function, int salary)
        {
            SurName = surname;
            Name = name;
            Position = function;
            Salary = salary;
        }
    }
}

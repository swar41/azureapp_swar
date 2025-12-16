using System;

namespace azureapp_swar.Models
{
    public class Person
    {
        public int Id { get; set; }   // Primary Key

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public DateTime DateOfBirth { get; set; }
    }
}

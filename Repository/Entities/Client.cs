using System;
using System.Collections.Generic;

namespace Repository.Entities
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Year { get; set; }
        public string Email { get; set; }
        public Guid MovieId { get; set; }
        public Movie movie { get; set; }
        public Client(Guid id, string name, string surName, int year, string email)
        {
            Id = id;
            Name = name;
            SurName = surName;
            Year = year;
            Email = email;
        }
    }
}

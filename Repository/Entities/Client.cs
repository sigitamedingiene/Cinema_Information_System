using System;

namespace Repository.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Year { get; set; }
        public string Email { get; set; }
        public int MovieId { get; set; }
        public Client(int id, string name, string surName, int year, string email, int movieId)
        {
            Id = id;
            Name = name;
            SurName = surName;
            Year = year;
            Email = email;
            MovieId = movieId;
        }
    }
}

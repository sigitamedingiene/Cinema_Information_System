
using System;

namespace Repository.Entities
{
    public class Auditorium
    {
        public Guid Id { get; set; }
        public Guid MovieId { get; set; }
        public Movie movie { get; set; }
        public string Owner { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public int PlaceCount { get; set; }
        public Auditorium(Guid id, string owner, string city, string adress, int placeCount)
        {
            Id = id;
            Owner = owner;
            City = city;
            Adress = adress;
            PlaceCount = placeCount;
        }
    }
}

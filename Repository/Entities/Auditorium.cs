

namespace Repository.Entities
{
    public class Auditorium
    {
        public int Id { get; set; }
        public string MovieId { get; set; }
        public string Owner { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public int PlaceCount { get; set; }
        public Auditorium(int id, string movieId, string owner, string city, string adress, int placeCount)
        {
            Id = id;
            MovieId = movieId;
            Owner = owner;
            City = city;
            Adress = adress;
            PlaceCount = placeCount;
        }
    }
}

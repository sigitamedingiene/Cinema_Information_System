using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string CompanyCreated { get; set; }
        public DateTime ShowTime { get; set; }
        public Movie(Guid id, string name, string type, string companyCreated, DateTime showTime)
        {
            Id = id;
            Name = name;
            Type = type;
            CompanyCreated = companyCreated;
            ShowTime = showTime;
        }

    }
}

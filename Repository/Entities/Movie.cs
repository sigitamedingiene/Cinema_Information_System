using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string CompanyCreated { get; set; }
        public Movie(int id, string name, string type, string companyCreated)
        {
            Id = id;
            Name = name;
            Type = type;
            CompanyCreated = companyCreated;
        }

    }
}

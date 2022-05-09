using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Breed { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Pet()
        {
            this.Id = 0;
            this.Name = "";
            this.Breed = "";
            this.DateOfBirth = DateTime.Now;
        }

        public Pet(int id, string name, string breed, DateTime dateOfBirth)
        {
            this.Id = id;
            this.Name = name;
            this.Breed = breed;
            this.DateOfBirth = dateOfBirth;  
        }

    }
}

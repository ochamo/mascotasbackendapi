using DataAccess.DBAccess;
using DataAccess.Models;

namespace DataAccess.Data
{
    public class PetData : IPetData
    {
        private readonly ISqlDataAccess db;

        public PetData(ISqlDataAccess db)
        {
            this.db = db;
        }

        public Task<IEnumerable<Pet>> GetPets() => db.LoadData<Pet, dynamic>("SP_GetPets", new { });

        public Task InsertPet(Pet pet) =>
            db.SaveData("SP_InsertPet", pet);


    }
}

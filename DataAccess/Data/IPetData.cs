using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IPetData
    {
        Task<IEnumerable<Pet>> GetPets();
        Task InsertPet(Pet pet);
    }
}
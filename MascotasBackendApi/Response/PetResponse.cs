using DataAccess.Models;

namespace MascotasBackendApi.Response
{
    public class PetResponse
    {
        public IEnumerable<Pet> Datos { get; set; }

        public PetResponse(IEnumerable<Pet> pets)
        {
            this.Datos = pets;
        }

        public PetResponse()
        {
            this.Datos = new List<Pet>();
        }

    }
}

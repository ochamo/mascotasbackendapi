using DataAccess.Data;
using DataAccess.Models;
using MascotasBackendApi.Response;

namespace MascotasBackendApi
{
    public static class Api
    {
        public static void ConfigureApi(this WebApplication app)
        {
            app.MapGet("/mascota", GetPets);
            app.MapPost("/mascota", InsertPet);
        }

        private static async Task<IResult> InsertPet(Pet pet, IPetData data)
        {
            try
            {
                await data.InsertPet(pet);
                return Results.Ok();
            } catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }

        private static async Task<IResult> GetPets(IPetData data)
        {
            try
            {

                IEnumerable<Pet> pets = await data.GetPets();
                var items = new PetResponse(pets);
                return Results.Ok(items);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

    }
}

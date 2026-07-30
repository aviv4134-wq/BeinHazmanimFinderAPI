using System.Security.AccessControl;

namespace BeinHazmanimFinderAPI;

    public interface IAccommodation
    {

        public  Task<List<Accommodation>> GetAccommodationsAsync();
        public Task<Accommodation>? GetByIdAsync(int id);
        public Task<Accommodation> CreateAsync(Accommodation accommodation);
        public Task< bool> UpdateAsync(int id, Accommodation accommodation);
        public Task<bool> DeleteAsync(int id);
        //public Task<List<Accommodation>> GetByMaxPriceCityAccessibleAsync(string city , int? maxPrice = null,bool? accessible = null);

        //public Task<List<string>> GetTypesAsync();

}


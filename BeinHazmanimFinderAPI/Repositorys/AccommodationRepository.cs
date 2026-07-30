using System.Text.Json;

namespace BeinHazmanimFinderAPI
{
    public class AccommodationRepository : IAccommodation
    {
        private List<Accommodation> _accommodations;
        private int _nextId;
        public AccommodationRepository()
        {
            _nextId = 2;
            _accommodations = new List<Accommodation>
            {
               new Accommodation {
                Id = 1,
                Name = "King David Suites"
                ,AccommodationType = "Hotel"
                   ,City = "Jerusalem",
                Area = "City Center",
                KashrutAuthority = "Eida Charedit",
                PricePerNight = 950,
                MaximumGuests = 4,
                AvailableFrom = DateTime.Parse( "2026-08-01"),
                IsAccessible = true,
                IsAbroad = false
               }

            };
        }

        public async Task<List<Accommodation>> GetAccommodationsAsync()
        {
            await Task.Delay(10);
            return _accommodations;
        }
        public async Task<Accommodation>? GetByIdAsync(int id)
        {
            await Task.Delay(10);
            var accommodation = _accommodations.FirstOrDefault(a => a.Id == id);

            return accommodation;
        }
        public async Task<Accommodation> CreateAsync(Accommodation accommodation)
        {
            await Task.Delay(10);
            accommodation.Id = _nextId++;
            _accommodations.Add(accommodation);

            return accommodation;
        }
        public async Task<bool> UpdateAsync(int id, Accommodation accommodation)
        {
            await Task.Delay(10);
            var accommodationUpadate = await GetByIdAsync(id);
            if (accommodationUpadate == null) return false;

            accommodationUpadate.Id = accommodation.Id;

            accommodationUpadate.AccommodationType = accommodation.AccommodationType;
            accommodationUpadate.Area = accommodation.Area;
            accommodationUpadate.AvailableFrom = accommodation.AvailableFrom;
            accommodationUpadate.City = accommodation.City;
            accommodationUpadate.IsAbroad = accommodation.IsAbroad;
            accommodationUpadate.IsAccessible = accommodation.IsAccessible;
            accommodationUpadate.KashrutAuthority = accommodation.KashrutAuthority;
            accommodationUpadate.MaximumGuests = accommodation.MaximumGuests;
            accommodationUpadate.Name = accommodation.Name;
            accommodationUpadate.PricePerNight = accommodation.PricePerNight;

            return true;

        }
        public async Task<bool> DeleteAsync(int id)
        {
            await Task.Delay(10);
            var accommodation = await GetByIdAsync(id);
            if (accommodation == null) return false;
            _accommodations.Remove(accommodation);
            return true;
        }
        //public async Task<IEnumerable<Accommodation>> GetByMaxPriceCityAccessibleAsync(string? city, int? maxPrice, bool? accessible)
        //{
           

        //    await Task.Delay(10);
        //    if (city != null && maxPrice == null && accessible == null)
        //    {
        //        var quary = _accommodations.Where(a => a.City == city);
        //        return quary;
        //    }
        //    if (city != null && maxPrice == null && accessible == null)

        //        if (maxPrice == null)
        //        {
        //            var quary = _accommodations.Where(a => a.PricePerNight <= maxPrice);
        //        }
        //    if (accessible != null)
        //    {
        //        var quary = _accommodations.Where(a => a.IsAccessible == accessible);
        //    }


        //}

        //public async Task<List<string>> GetTypesAsync()
        //{
        //    var types = _accommodations.GroupBy(a => a.AccommodationType.Distinct());
        //    await Task.Delay(10);
        //    return types;
        //}
    }
}


namespace BeinHazmanimFinderAPI.Repositorys
{
    public class ActivityPlaceRepository : IActivityPlace
    {
        private List<ActivityPlace> _activityPlaces;
        private int _nextId;

        public ActivityPlaceRepository()
        {
            _nextId = 2;
            _activityPlaces = new List<ActivityPlace>
            {
                new ActivityPlace {
                    Id = 1,
                Name = "Cafe Rimon",
                Category = "Restaurant",
                City = "Jerusalem",
                Area = "City Center",
                TargetAudience = "Families",
                PricePerPerson = 90,
                MinimumAge = 0,
                AvailableDate = DateTime.Parse("2026-08-01"),
                IsAccessible = true,
                RequiresKashrut = true,
                KashrutAuthority = "Eida Charedit"
                }



            };
        }

        public async Task<List<ActivityPlace>> GetActivityPlaceAsync()
        {
            await Task.Delay(10);
            return _activityPlaces;
        }
        public async Task<ActivityPlace>? GetByIdAsync(int id)
        {
            await Task.Delay(10);
            var activityPlaces = _activityPlaces.FirstOrDefault(a => a.Id == id);

            return activityPlaces;
        }
        public async Task<ActivityPlace> CreateAsync(ActivityPlace activityPlace)
        {
            await Task.Delay(10);
            activityPlace.Id = _nextId++;
            _activityPlaces.Add(activityPlace);

            return activityPlace;
        }
        public async Task<bool> UpdateAsync(int id, ActivityPlace activityPlace)
        {
            await Task.Delay(10);
            var activityPlaceUpadate = await GetByIdAsync(id);
            if (activityPlaceUpadate == null) return false;

            activityPlaceUpadate.Id = activityPlace.Id;
            
            activityPlaceUpadate.Area = activityPlace.Area;
            
            activityPlaceUpadate.City = activityPlace.City;
           
            activityPlaceUpadate.Name = activityPlace.Name;

            activityPlaceUpadate.Category = activityPlace.Category;

            activityPlaceUpadate.TargetAudience = activityPlace.TargetAudience;

            activityPlaceUpadate.PricePerPerson = activityPlace.PricePerPerson;

            activityPlaceUpadate.MinimumAge = activityPlace.MinimumAge;

            activityPlaceUpadate.AvailableDate = activityPlace.AvailableDate;
            activityPlaceUpadate.IsAccessible = activityPlace.IsAccessible;
            activityPlaceUpadate.RequiresKashrut = activityPlace.RequiresKashrut;
            activityPlaceUpadate.KashrutAuthority = activityPlace.KashrutAuthority;

            return true;

        }
        public async Task<bool> DeleteAsync(int id)
        {
            await Task.Delay(10);
            var activityPlace = await GetByIdAsync(id);
            if (activityPlace == null) return false;
            _activityPlaces.Remove(activityPlace);
            return true;
        }

    }
}

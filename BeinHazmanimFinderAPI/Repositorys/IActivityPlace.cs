using BeinHazmanimFinderAPI;

namespace BeinHazmanimFinderAPI
{
    public interface IActivityPlace
    {
        public Task<List<ActivityPlace>> GetActivityPlaceAsync();
        public Task<ActivityPlace>? GetByIdAsync(int id);
        public Task<ActivityPlace> CreateAsync(ActivityPlace activityPlace);
        public Task<bool> UpdateAsync(int id, ActivityPlace activityPlace);
        public Task<bool> DeleteAsync(int id);
    }
}

namespace BeinHazmanimFinderAPI
{
    public class ServiesClient : Iservies
    {
        private IAccommodation _accommodations;
        private IActivityPlace _activityPlaces;

        public ServiesClient(IAccommodation accommodation, IActivityPlace activityPlace)
        {
            _accommodations = accommodation;
            _activityPlaces = activityPlace;
        }
    }
}

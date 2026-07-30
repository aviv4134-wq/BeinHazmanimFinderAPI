using System.Text.Json.Serialization;

namespace BeinHazmanimFinderAPI.enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AccommodationTypes
    {
        Hotel,
        Vacation,
        Apartment,
        GuestHouse,
        Zimmer,
        Resort,
        Hostel
    }
}

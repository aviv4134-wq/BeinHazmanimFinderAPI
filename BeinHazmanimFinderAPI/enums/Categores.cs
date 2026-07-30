using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeinHazmanimFinderAPI.enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Categores
    {
        Restaurant,
        
        WaterPark,
        
        NatureTrail,
        
        Museum,
        
        HistoricalSite,
        
        AdventurePark,
        
        BoatTrip,

        Visitor,
        Center,
        
        ChildrenActivity
    }
}

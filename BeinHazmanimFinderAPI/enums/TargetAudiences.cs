using System.Text.Json.Serialization;

namespace BeinHazmanimFinderAPI.enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TargetAudiences
    {
        Families,
        Children,
        Youth,
        Adults,
        Men,
        Women
    }
}

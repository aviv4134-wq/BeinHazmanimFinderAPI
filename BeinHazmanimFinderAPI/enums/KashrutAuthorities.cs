using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace BeinHazmanimFinderAPI.enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum KashrutAuthorities
    {
        
       
        EidaCharedit,
        
       
        RavRubin,

        
        RavLandau,
        
        BadatzMehadrin,

        
        LocalKehillah
    }
}

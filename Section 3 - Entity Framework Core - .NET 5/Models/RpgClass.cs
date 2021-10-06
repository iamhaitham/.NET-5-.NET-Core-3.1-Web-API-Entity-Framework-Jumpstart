using System.Text.Json.Serialization;

namespace Section_1___Introduction___.NET_5.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight,
        Mage,
        Cleric
    }
}

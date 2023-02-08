using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GRHW
{
    public partial class Customer
    {
        
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Email { get; set; }

        public string FavoriteColor { get; set; }

        public string DateOfBirth { get; set; }
    }

    public static class Serialize
    {
        public static string ToJson(this Customer self) => JsonConvert.SerializeObject(self, GRHW.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

}

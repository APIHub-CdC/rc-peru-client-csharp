using Newtonsoft.Json.Converters;

namespace IO.RcPeru.Client
{
    public class ApihubDateConverter : IsoDateTimeConverter
    {
        public ApihubDateConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}

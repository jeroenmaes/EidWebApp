using Egelke.Eid.Client.Model;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace EidShared
{
    public class EidResult
    {
        public Identity Identity { get; internal set; }
        public Address Address { get; internal set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new StringEnumConverter());
        }
    }
}

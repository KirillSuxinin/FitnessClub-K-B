using Newtonsoft.Json;
using System.Collections.Generic;
namespace FitnessClub.JSON
{
    public class Rootobject_Translater
    {
        public List<Tables> Rus { get; set; }
    }
    public class Tables
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string NameTable { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string HeaderTable { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public List<Property1> Property { get; set; }
    }
    public class Property1
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string NameProperty { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string HeaderProperty { get; set; }
    }

}

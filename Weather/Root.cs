using Newtonsoft.Json;

namespace Digital_Clock_WFApp.Weather
{
    public class Root
    {
        public Coord coord { get; set; }
        public List<Weather> weather { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }
        public Main main { get; set; }
        public int visibility { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public Sys sys { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }
}

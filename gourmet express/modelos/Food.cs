
using System.Text.Json.Serialization;

namespace gourmet_express.modelos
{
    internal class Food
    {
        @[JsonPropertyName("name")]
        public string Nome { get; set; }
        @[JsonPropertyName("author")]
        public string Autor { get; set; }
        @[JsonPropertyName("recipe")]
        public string Receita { get; set; }
        @[JsonPropertyName("preparation_time")]
        public int TempoPreparo { get; set; }
    }
}

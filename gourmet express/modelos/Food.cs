
using System.Text.Json.Serialization;

namespace gourmet_express.modelos;

internal class Food
{
    [JsonPropertyName("name")]
    public string Nome { get; set; }
    [JsonPropertyName("author")]
    public string Autor { get; set; }
    [JsonPropertyName("recipe")]
    public string Receita { get; set; }
    [JsonPropertyName("preparation_time")]
    public int TempoPreparo { get; set; }
    public static void ListarComidas(List<Food> comidas)
    {
        Console.WriteLine("Comidas disponíveis.");
        foreach (var comida in comidas)
        {
            Console.WriteLine(comida.Nome);
        }
    }
    public static void ExibirInformacoes(Food comida)
    {
        Console.WriteLine($"Nome: {comida.Nome} \n Autor: {comida.Autor} \n receita: {comida.Receita} \n tempo de preparo: {comida.TempoPreparo} minútos.");
    }
}

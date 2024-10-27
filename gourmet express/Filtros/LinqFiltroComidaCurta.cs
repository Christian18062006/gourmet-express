using gourmet_express.modelos;

namespace gourmet_express.Filtros;

internal class LinqFiltroComidaCurta
{
    public static void OrdenarComidasCurtas(List<Food> comidas)
    {
        Console.WriteLine("Comidas com rápido preparo.");
        var tempoMenor = comidas.Min(comida => comida.TempoPreparo);
        var comidasComMenorTempo = comidas.Where(comida => comida.TempoPreparo == tempoMenor).ToList();
        foreach (var comidaCurta in comidasComMenorTempo)
        {
            Console.WriteLine($"Nome da comida: {comidaCurta.Nome} tempo de preparo: {comidaCurta.TempoPreparo} minútos.");
        }
    }
}

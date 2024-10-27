
using gourmet_express.modelos;

namespace gourmet_express.Filtros;

internal class LinqFiltroAutor
{
    public static void OrdenarAutores(List<Food> comidas)
    {
        var ordenaAutores=comidas.Select(comida=>comida.Autor).Distinct().OrderBy(autor=>autor).ToList();
        Console.WriteLine("Autores cadastrados no nosso banco de dados.");
        foreach (var autor in ordenaAutores)
        {
            Console.WriteLine(autor);
        }
    }
}

using ScreenSound_API.Modelos;

namespace ScreenSound_API.Filtros;

internal class LinqOrder
{
    public static void ExibirBandas(List<Musica> musicas)
    {
        var todasAsBandas = musicas.OrderBy(banda => banda.Artista).Select(banda => banda.Artista).Distinct().ToList();

        Console.WriteLine("Lista de artistas:");
        
        foreach (var banda in todasAsBandas)
        {
            Console.WriteLine($"- {banda}");
        }
    }
}

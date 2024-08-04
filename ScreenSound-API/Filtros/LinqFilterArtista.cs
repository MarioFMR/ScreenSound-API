using ScreenSound_API.Modelos;

namespace ScreenSound_API.Filtros;

internal class LinqFilterArtista
{
    public static void ExibirAsBandas(List<Musica> musicas)
    {
        var todasAsBandas = musicas.OrderBy(bandas => bandas.Artista).Select(bandas => bandas.Artista).Distinct().ToList();

        Console.WriteLine("Lista de artistas:");
        
        foreach (var banda in todasAsBandas)
        {
            Console.WriteLine($"- {banda}");
        }
    }
}

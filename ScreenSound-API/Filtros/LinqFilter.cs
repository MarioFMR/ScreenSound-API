using ScreenSound_API.Modelos;

namespace ScreenSound_API.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosGeneros(List<Musica> musicas)
    {
        var todosOsGeneros = musicas.Select(generos => generos.Genero).Distinct().ToList();

        foreach (var genero in todosOsGeneros)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarBandasPorGenero(List<Musica> musicas, string genero)
    {
        var bandasPorGenero = musicas.Where(banda => banda.Genero!.Contains(genero)).Select(banda => banda.Artista).Distinct().ToList();

        Console.WriteLine($"Artistas do gênero {genero}:");

        foreach (var banda in bandasPorGenero)
        {
            Console.WriteLine($"- {banda}");
        }
    }

    public static void FiltrarMusicasPorBanda(List<Musica> musicas, string banda)
    {
        var musicasPorBanda = musicas.Where(musica => musica.Artista!.Equals(banda)).ToList();

        Console.WriteLine($"{banda}:");

        foreach (var musica in musicasPorBanda)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
}

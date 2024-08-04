using ScreenSound_API.Modelos;

namespace ScreenSound_API.Filtros;

internal class LinqFilterGenero
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGeneros = musicas.Select(generos => generos.Genero).Distinct().OrderBy(generos => generos).ToList();

        foreach (var genero in todosOsGeneros)
        {
            Console.WriteLine($"- {genero}");
        }
    }
}

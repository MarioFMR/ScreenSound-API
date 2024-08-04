using ScreenSound_API.Filtros;
using ScreenSound_API.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        //musicas[0].ExibirDetalhesDaMusica();

        //LinqFilter.FiltrarTodosGeneros(musicas);
        //LinqOrder.ExibirBandas(musicas);
        //LinqFilter.FiltrarBandasPorGenero(musicas, "rock");
        LinqFilter.FiltrarMusicasPorBanda(musicas, "Red Hot Chili Peppers");

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Descrição do erro: {ex.Message}");
    }
}


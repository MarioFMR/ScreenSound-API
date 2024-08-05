using ScreenSound_API.Filtros;
using ScreenSound_API.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        //Manipulação de arquivo via API
        //musicas[114].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosGeneros(musicas);
        //LinqOrder.ExibirBandas(musicas);
        //LinqFilter.FiltrarBandasPorGenero(musicas, "rock");
        //LinqFilter.FiltrarMusicasPorBanda(musicas, "Red Hot Chili Peppers");
        //LinqFilter.FiltrarMusicaPorAno(musicas, "1999");
        LinqFilter.FiltrarMusicaPorTonalidade(musicas, "C#");

        //Manipulação de arquivo local Json
        //var musicasFavoritas = new MusicasFavoritas("Mario");
        //musicasFavoritas.AddMusicasFavoritas(musicas[15]);
        //musicasFavoritas.AddMusicasFavoritas(musicas[31]);
        //musicasFavoritas.AddMusicasFavoritas(musicas[71]);
        //musicasFavoritas.AddMusicasFavoritas(musicas[87]);
        //musicasFavoritas.AddMusicasFavoritas(musicas[114]);

        //musicasFavoritas.ExibirMusicasFavoritas();

        //musicasFavoritas.GerarArquivoJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Descrição do erro: {ex.Message}");
    }
}


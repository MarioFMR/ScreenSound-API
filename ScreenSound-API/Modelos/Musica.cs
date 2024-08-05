using System.Text.Json.Serialization;

namespace ScreenSound_API.Modelos;

internal class Musica
{
    //Lista de string
    private string[] tonalidades = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

    //Propriedades da classe
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int? Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    [JsonPropertyName("year")]
    public string? AnoLacamento { get; set; }
    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string Tonalidade {
        get
        {
            return tonalidades[Key];
        }
    }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao/1000}s");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Ano: {AnoLacamento}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");
    }
}

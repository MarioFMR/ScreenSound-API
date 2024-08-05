using System.Text.Json;

namespace ScreenSound_API.Modelos;

internal class MusicasFavoritas
{
    //Propriedades
    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; }

    //Método construtor
    public MusicasFavoritas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }

    //Método adiciona musica favorita
    public void AddMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    //Metodo exibe musica favorita
    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Favoritos do {Nome}:");

        foreach (var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"- Musica: {musica.Nome} / Artista: {musica.Artista}");
        }
    }

    //Metodo adiciona os favoritos em um Json
    public void GerarArquivoJson() 
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });

        string nomeDoArquivo = $"Favoritos-{Nome}.Json";

        File.WriteAllText(nomeDoArquivo, json);

        Console.WriteLine($"\nArquivo criado com sucesso no caminho {Path.GetFullPath(nomeDoArquivo)}");
    }
}

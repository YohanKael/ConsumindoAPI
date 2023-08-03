using System.Text.Json;
using ConsumindoAPI.Filtros;
using ConsumindoAPI.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[5].ExibirDetalhesDaMusica();
        LinqFilter.FiltrandoMusicasPelaTonalidade(musicas, "C#");
        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenado(musicas);
        //LinqFilter.FiltrarArtistaPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
        //LinqFilter.FiltrarMusicasPorAno(musicas, "2005");

        //var musicasPreferidasDoYohan = new MusicasPreferidas("Yohan");

        //musicasPreferidasDoYohan.AdicionarMusicasFavoritas(musicas[10]);
        //musicasPreferidasDoYohan.AdicionarMusicasFavoritas(musicas[500]);
        //musicasPreferidasDoYohan.AdicionarMusicasFavoritas(musicas[1000]);
        //musicasPreferidasDoYohan.AdicionarMusicasFavoritas(musicas[1500]);
        //musicasPreferidasDoYohan.AdicionarMusicasFavoritas(musicas[1400]);

        //var musicasPreferidasDoDigo = new MusicasPreferidas("Digo");
        //musicasPreferidasDoDigo.AdicionarMusicasFavoritas(musicas[55]);
        //musicasPreferidasDoDigo.AdicionarMusicasFavoritas(musicas[5]);
        //musicasPreferidasDoDigo.AdicionarMusicasFavoritas(musicas[100]);
        //musicasPreferidasDoDigo.AdicionarMusicasFavoritas(musicas[500]);
        //musicasPreferidasDoDigo.AdicionarMusicasFavoritas(musicas[120]);


        //musicasPreferidasDoYohan.ExibirMusicasFavoritas();
        //musicasPreferidasDoYohan.GerarArquivoJson();
        // musicasPreferidasDoDigo.ExibirMusicasFavoritas();
    }
    catch(Exception ex)
    {
        Console.WriteLine($"O erro ocorrido foi:{ex.Message}");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsumindoAPI.Modelos
{
    internal class Musica
    {
        private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };


        [JsonPropertyName("song")]
        public string? Nome { get; set; }

        [JsonPropertyName("artist")]
        public string? Artista { get; set; }

        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }

        [JsonPropertyName("genre")]
        public string? Genero { get; set; }

        [JsonPropertyName("year")]
        public string? Ano { get; set; }

        [JsonPropertyName("key")]
        public int Key { get; set; }

        public string Tonalidade
        {
            get
            {
                return tonalidades[Key];
            }
        }

        public void ExibirDetalhesDaMusica()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Duracao: {Duracao}");
            Console.WriteLine($"Genero: {Genero}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Tonalidade: {Tonalidade}");
        }
    }
}

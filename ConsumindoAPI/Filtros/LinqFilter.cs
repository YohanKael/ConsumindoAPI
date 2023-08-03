using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsumindoAPI.Modelos;

namespace ConsumindoAPI.Filtros
{
    internal class LinqFilter
    {

        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
        {
            var TodosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
            foreach (var genero in TodosOsGenerosMusicais)
            {
                Console.WriteLine($"Genero: {genero}");
            }
        }

        public static void FiltrarArtistaPorGeneroMusical(List<Musica> musicas, string genero)
        {
            var ArtistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero))
                                                  .Select(musicas => musicas.Artista).Distinct().ToList();

            foreach (var artista in ArtistasPorGeneroMusical)
            {
                Console.WriteLine($" - {artista}");                     
            }
        }

        public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista) 
        {
            var musicasDoArtistaFiltradas = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
            Console.WriteLine(nomeDoArtista);
            foreach (var musica in musicasDoArtistaFiltradas)
            {
                Console.WriteLine($" - {musica.Nome}");
            }
        }

        public static void FiltrarMusicasPorAno(List<Musica> musicas, string ano)
        {
            var FiltrandoMusicasPorAno = musicas.Where(musica => musica.Ano!.Equals(ano))
                                                .OrderBy(musicas => musicas.Nome)
                                                .Select(musicas => musicas.Nome).Distinct().ToList();
            Console.WriteLine(ano);
            foreach (var musica in FiltrandoMusicasPorAno)
            {
                Console.WriteLine($" - {musica}");
            }
        }

        public static void FiltrandoMusicasPelaTonalidade(List<Musica> musicas, string tonalidade)
        {
            var FiltrandoPorTonalidade = musicas.Where(musica => musica.Tonalidade.Equals(tonalidade));
                                         musicas.Select(musica => musica.Nome).Distinct().ToList();
            Console.WriteLine($"Imprimindo todas as musicas com Tonalidade : {tonalidade}");

            foreach (var musica in FiltrandoPorTonalidade)
            {
                Console.WriteLine($" - {musica.Nome} - Tonalidade: {tonalidade}");
            }
        }
    }
}

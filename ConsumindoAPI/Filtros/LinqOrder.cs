using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsumindoAPI.Modelos;

namespace ConsumindoAPI.Filtros
{
    internal class LinqOrder
    {
        public static void ExibirListaDeArtistasOrdenado(List<Musica> musicas)
        {
            var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
            foreach (var artista in artistasOrdenados)
            {
                Console.WriteLine($"Artistas Ordenados: {artista}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudos_cs_curso2.Classes
{
    public class Album
    {
        public Album(string nome)
        {
            Nome = nome;
        }
        private List<Musica> musicas = new List<Musica>();
        public string Nome { get; }
        public int DuracaoTotal => musicas.Sum(m => m.Duracao);

        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }

        public void ExibirMusicasDoAlbum()
        {
            Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
            foreach(var musica in musicas)
            {
                Console.WriteLine($"Música: {musica.Nome}");
            }
            Console.WriteLine($"Para ouvir esse álbum inteiro, você precisa de {DuracaoTotal} segundos");
        }
    }
}
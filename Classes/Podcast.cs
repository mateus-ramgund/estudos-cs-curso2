using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudos_cs_curso2.Classes
{
    public class Podcast
    {
        public Podcast(string host, string nome)
        {
            Host = host;
            Nome = nome;
        }
        private List<Episodio> episodios = new List<Episodio>();
        public string Host { get; }
        public string Nome { get; }
        public int TotalEpisodios => episodios.Count;

        public void AdicionarEpisodio(Episodio episodio)
        {
            episodios.Add(episodio);
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Este é o Podcast {Nome}");
            Console.WriteLine($"O podcast é hosteado por {Host} e possui {TotalEpisodios} episódios.");
        }
    }
}
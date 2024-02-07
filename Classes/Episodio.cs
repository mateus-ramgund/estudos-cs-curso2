using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudos_cs_curso2.Classes
{
    public class Episodio
    {
        public Episodio(int ordem, string titulo, int duracao)
        {
            Ordem = ordem;
            Titulo = titulo;
            Duracao = duracao;
        }
        private List<string> convidados = new List<string>();
        public int Duracao { get; }
        public int Ordem { get; }
        public string Titulo { get; }
        public string Resumo  =>
                $"O episódio {Titulo} é o episódio número {Ordem}, possui {Duracao} minutos e conta com a presença de {convidados.Count} convidados: {string.Join(", ",convidados)}";

        public void AdicionarConvidados(string convidado)
        {
            convidados.Add(convidado);
        }
    }
}
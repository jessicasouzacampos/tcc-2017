using System.Collections.Generic;

namespace AppTCC2.Models
{
    public class BancoDados
    {
        public List<Cidade> Cidades { get; set; }
        public List<Termo> Termos { get; set; }
        public List<Tema> Temas { get; set; }
        public List<Arquivo> Arquivos { get; set; }

        public BancoDados()
        {
            Cidades = new List<Cidade>();
            Termos = new List<Termo>();
            Temas = new List<Tema>();
            Arquivos = new List<Arquivo>();
        }
    }
}
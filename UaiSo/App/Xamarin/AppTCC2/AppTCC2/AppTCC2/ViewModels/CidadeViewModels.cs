using AppTCC2.Models;
using System.Collections.Generic;

namespace AppTCC2.ViewModels
{
    public class CidadeViewModels : BaseViewModel
    {
        private List<Cidade> cidades { get; set; }
        private Cidade cidade { get; set; }

        public List<Cidade> Cidades
        {
            get
            {
                return cidades;
            }
            set
            {
                cidades = value;
                OnPropertyChanged("Cidades");
            }
        }

        public Cidade Cidade
        {
            get
            {
                return cidade;
            }
            set
            {
                cidade = value;
                OnPropertyChanged("Cidade");
                /*if (value != null)
                    PushAsync(new CadastrarCidade(cidade));*/
            }
        }

    }
    
}

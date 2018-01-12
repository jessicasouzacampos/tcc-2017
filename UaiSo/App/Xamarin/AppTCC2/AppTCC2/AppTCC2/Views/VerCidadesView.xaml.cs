using AppTCC2.Models;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AppTCC2.Views
{
    public partial class VerCidadesView : ContentPage
	{
        public List<Cidade> Cidades { get; set; }
        public Cidade Cidade { get; set; }  

        public VerCidadesView(BancoDados bd)
		{            
            InitializeComponent();

            this.Cidades = bd.Cidades;

            #region Testes
            //this.Cidades = new List<Cidade>
            //{
            //    new Cidade(){ Nome = "Divinópolis", CidadeId = 1,
            //        Temas = new List<Tema>(){
            //            new Tema() { Nome = "Culinária", TemaId = 1,
            //                Termos = new List<Termo>()
            //                {
            //                    new Termo(){Nome = "Beijo Quente", Significado = "Amendoim torrado com cobertura de açúcar ", TermoId = 1 },
            //                    new Termo(){Nome = "Queca", Significado = "Pão doce", TermoId = 2 },
            //                    new Termo(){Nome = "Tareco", Significado = "Quitanda feita de farinha de trigo", TermoId = 3 }
            //                }
            //            },
            //            new Tema() { Nome = "Cotidiano", TemaId = 2,
            //                Termos = new List<Termo>()
            //                {
            //                    new Termo(){Nome = "Braqueárea", Significado = "", TermoId = 1 },
            //                    new Termo(){Nome = "Dar Tombo", Significado = "", TermoId = 2 },
            //                    new Termo(){Nome = "Maiou", Significado = "", TermoId = 3 }
            //                }},
            //            new Tema() { Nome = "Cultura", TemaId = 3,
            //                Termos = new List<Termo>()
            //                {
            //                    new Termo(){Nome = "Benzedor", Significado = "", TermoId = 1 },
            //                    new Termo(){Nome = "Divina expô", Significado = "", TermoId = 2 },
            //                    new Termo(){Nome = "Prainha do 48", Significado = "", TermoId = 3 }
            //                }},
            //            new Tema() { Nome = "Esporte", TemaId = 4,
            //                Termos = new List<Termo>()
            //                {
            //                    new Termo(){Nome = "Fuminha", Significado = "", TermoId = 1 },
            //                    new Termo(){Nome = "Pauzinho", Significado = "", TermoId = 2 },
            //                    new Termo(){Nome = "Tora", Significado = "", TermoId = 3 }
            //                }},
            //            new Tema() { Nome = "Pessoa", TemaId = 5,
            //                Termos = new List<Termo>()
            //                {
            //                    new Termo(){Nome = "Amuado", Significado = "", TermoId = 1 },
            //                    new Termo(){Nome = "Custoso", Significado = "", TermoId = 2 },
            //                    new Termo(){Nome = "Regateira", Significado = "", TermoId = 3 }
            //                }},
            //        }
            //    },
            //    new Cidade(){ Nome = "Carmo da Mata" , CidadeId = 2,
            //        Temas = new List<Tema>(){
            //            new Tema() { Nome = "Culinária", TemaId = 1,
            //                Termos = new List<Termo>()
            //                {
            //                    new Termo(){Nome = "Quente pelano", Significado = "", TermoId = 1 },
            //                    new Termo(){Nome = "Marianica", Significado = "", TermoId = 2 },
            //                    new Termo(){Nome = "Serraia", Significado = "", TermoId = 3 }
            //                }
            //            },
            //            new Tema() { Nome = "Cotidiano", TemaId = 2,
            //                Termos = new List<Termo>()
            //                {
            //                    new Termo(){Nome = "Faniquito", Significado = "", TermoId = 1 },
            //                    new Termo(){Nome = "Fingir de égua", Significado = "", TermoId = 2 },
            //                    new Termo(){Nome = "Renquenguela", Significado = "", TermoId = 3 }
            //                }},
            //            new Tema() { Nome = "Cultura", TemaId = 3,
            //                Termos = new List<Termo>()
            //                {
            //                    new Termo(){Nome = "Baile", Significado = "", TermoId = 1 },
            //                    new Termo(){Nome = "Catirina", Significado = "", TermoId = 2 },
            //                    new Termo(){Nome = "Mascarado", Significado = "", TermoId = 3 }
            //                }},
            //            new Tema() { Nome = "Esporte", TemaId = 4,
            //                Termos = new List<Termo>()
            //                {
            //                    new Termo(){Nome = "Bicudo", Significado = "", TermoId = 1 },
            //                    new Termo(){Nome = "Panelinha", Significado = "", TermoId = 2 },
            //                    new Termo(){Nome = "Ranca", Significado = "", TermoId = 3 }
            //                }},
            //            new Tema() { Nome = "Pessoa", TemaId = 5,
            //                Termos = new List<Termo>()
            //                {
            //                    new Termo(){Nome = "Acanhado", Significado = "", TermoId = 1 },
            //                    new Termo(){Nome = "Estorvado", Significado = "", TermoId = 2 },
            //                    new Termo(){Nome = "Momado", Significado = "", TermoId = 3 }
            //                }},
            //        }
            //    },
            //    new Cidade(){ Nome = "Carmo do Cajuru", CidadeId = 3,
            //        Temas = new List<Tema>(){
            //            new Tema() { Nome = "Culinária", TemaId = 1,
            //                Termos = new List<Termo>()
            //                {
            //                    new Termo(){Nome = "Cariru", Significado = "", TermoId = 1 },
            //                    new Termo(){Nome = "Olho de sogra", Significado = "", TermoId = 2 },
            //                    new Termo(){Nome = "Gororoba", Significado = "", TermoId = 3 }
            //                }
            //            },
            //            new Tema() { Nome = "Cotidiano", TemaId = 2,
            //                Termos = new List<Termo>()
            //                {
            //                    new Termo(){Nome = "Atazanando", Significado = "", TermoId = 1 },
            //                    new Termo(){Nome = "Murinha", Significado = "", TermoId = 2 },
            //                    new Termo(){Nome = "Perna Doce", Significado = "", TermoId = 3 }
            //                }},
            //            new Tema() { Nome = "Cultura", TemaId = 3,
            //                Termos = new List<Termo>()
            //                {
            //                    new Termo(){Nome = "Brigar com as panelas", Significado = "", TermoId = 1 },
            //                    new Termo(){Nome = "Plasta", Significado = "", TermoId = 2 },
            //                    new Termo(){Nome = "Zé lagoa", Significado = "", TermoId = 3 }
            //                }},
            //            new Tema() { Nome = "Esporte", TemaId = 4,
            //                Termos = new List<Termo>()
            //                {
            //                    new Termo(){Nome = "Banheira", Significado = "", TermoId = 1 },
            //                    new Termo(){Nome = "Quebra dedo", Significado = "", TermoId = 2 },
            //                    new Termo(){Nome = "Rachão", Significado = "", TermoId = 3 }
            //                }},
            //            new Tema() { Nome = "Pessoa", TemaId = 5,
            //                Termos = new List<Termo>()
            //                {
            //                    new Termo(){Nome = "Cara de tacho", Significado = "", TermoId = 1 },
            //                    new Termo(){Nome = "Rei na barriga", Significado = "", TermoId = 2 },
            //                    new Termo(){Nome = "Tiu", Significado = "", TermoId = 3 }
            //                }},
            //        }
            //    },
            //    new Cidade(){ Nome = "Itaúna", CidadeId = 4,
            //        Temas = new List<Tema>(){
            //            new Tema() { Nome = "Culinária", TemaId = 1,
            //                Termos = new List<Termo>()
            //                {
            //                    new Termo(){Nome = "Minduim", Significado = "", TermoId = 1 },
            //                    new Termo(){Nome = "Tocim", Significado = "", TermoId = 2 },
            //                    new Termo(){Nome = "Torremo", Significado = "", TermoId = 3 }
            //                }
            //            },
            //            new Tema() { Nome = "Cotidiano", TemaId = 2,
            //                Termos = new List<Termo>()
            //                {
            //                    new Termo(){Nome = "Balaio", Significado = "", TermoId = 1 },
            //                    new Termo(){Nome = "Bia", Significado = "", TermoId = 2 },
            //                    new Termo(){Nome = "Emborna", Significado = "", TermoId = 3 }
            //                }},
            //            new Tema() { Nome = "Cultura", TemaId = 3,
            //                Termos = new List<Termo>()
            //                {
            //                    new Termo(){Nome = "Babujado", Significado = "", TermoId = 1 },
            //                    new Termo(){Nome = "Picá mula", Significado = "", TermoId = 2 },
            //                    new Termo(){Nome = "Tô na roia", Significado = "", TermoId = 3 }
            //                }},
            //            new Tema() { Nome = "Esporte", TemaId = 4,
            //                Termos = new List<Termo>()
            //                {
            //                    new Termo(){Nome = "Pé de ferro", Significado = "", TermoId = 1 },
            //                    new Termo(){Nome = "Biboca", Significado = "", TermoId = 2 },
            //                    new Termo(){Nome = "Mistoso", Significado = "", TermoId = 3 }
            //                }},
            //            new Tema() { Nome = "Pessoa", TemaId = 5,
            //                Termos = new List<Termo>()
            //                {
            //                    new Termo(){Nome = "Beleléu", Significado = "", TermoId = 1 },
            //                    new Termo(){Nome = "Cambito", Significado = "", TermoId = 2 },
            //                    new Termo(){Nome = "Storvo", Significado = "", TermoId = 3 }
            //                }},
            //        }
            //    }
            //};
            #endregion

            this.BindingContext = this;            
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var cidade = (Cidade) e.Item;

            Navigation.PushAsync(new VerTemasView(cidade));
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var cidade = (Cidade)e.SelectedItem;

            Navigation.PushAsync(new VerTemasView(cidade));
        }
    }
}
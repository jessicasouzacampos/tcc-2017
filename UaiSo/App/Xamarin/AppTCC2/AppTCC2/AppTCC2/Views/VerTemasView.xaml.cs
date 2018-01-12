using AppTCC2.Models;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTCC2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VerTemasView : ContentPage
	{
        public List<Tema> Temas { get; set; }
        public Tema Tema { get; set; }

        public VerTemasView(Cidade cidade)
		{
			InitializeComponent ();
            this.Title = cidade.Nome;

            Temas = cidade.Temas;

            this.BindingContext = this;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var tema = (Tema)e.Item;

            Navigation.PushAsync(new VerTermosView(tema));
        }
    }
}
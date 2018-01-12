using AppTCC2.Models;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTCC2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VerTermosView : ContentPage
	{
        public List<Termo> Termos { get; set; }
        public Termo Termo { get; set; }

        public VerTermosView (Tema tema)
		{
			InitializeComponent ();
            this.Title = tema.Nome;

            Termos = tema.Termos;

            this.BindingContext = this;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var termo = (Termo)e.Item;

            Navigation.PushAsync(new VerDetalhesTermo(termo));
        }
    }
}
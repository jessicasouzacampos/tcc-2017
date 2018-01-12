using AppTCC2.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTCC2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VerDetalhesTermo : ContentPage
	{
        public Termo Termo { get; set; }

		public VerDetalhesTermo (Termo termo)
		{
			InitializeComponent ();
            this.Termo = termo;

            this.BindingContext = this;
		}
	}
}
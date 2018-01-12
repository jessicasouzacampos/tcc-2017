using AppTCC2.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTCC2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Principal : ContentPage
	{
		public Principal ()
		{
			InitializeComponent();
            BindingContext = new PrincipalViewModel();
        }
	}
}
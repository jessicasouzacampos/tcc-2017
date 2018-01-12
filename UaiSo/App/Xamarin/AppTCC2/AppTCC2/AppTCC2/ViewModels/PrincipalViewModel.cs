using AppTCC2.Models;
using AppTCC2.Views;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppTCC2.ViewModels
{
    public class PrincipalViewModel : BaseViewModel
    {
        public ICommand Sincronizar { get; set; }
        public ICommand Cidades { get; set; }
        public BancoDados bd { get; set; }

        public PrincipalViewModel()
        {
            Sincronizar = new Command(SincronizarAzure);
            Cidades = new Command(VerCidades);            
        }

        async void SincronizarAzure()
        {
            
            try
            {
                var client = new HttpClient();
                var uri = "http://192.168.10.105:55964/api/UaiSo/BancoDados/";
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    bd = JsonConvert.DeserializeObject<BancoDados>(content);
                }

            }
            
            catch (Exception ex)
            {

                throw;
            }
           
        }

        async void VerCidades()
        {
            await PushAsync(new VerCidadesView(bd));
        }
    }
}

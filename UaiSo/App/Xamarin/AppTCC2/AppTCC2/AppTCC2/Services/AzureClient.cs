//using AppTCC2.Models;
//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//namespace AppTCC2.Services
//{
//    public class AzureClient
//    {
//        private IMobileServiceClient _client;
//        private IMobileServiceSyncTable<Cidade> _table;
//        private string dbPath = "AppTCC";
//        MobileServiceContractResolver mob = new MobileServiceContractResolver();
//        private const string serviceUri = "http://uaiso.azurewebsites.net";
//        public AzureClient()
//        {
//            _client = new MobileServiceClient(serviceUri);
//            var store = new MobileServiceSQLiteStore(dbPath);
//            store.DefineTable<Cidade>();
//            _client.SyncContext.InitializeAsync(store);
//            _table = _client.GetSyncTable<Cidade>();
//        }

//        public async Task<IEnumerable<Cidade>> GetContacts()
//        {
//            var empty = new Cidade[0];
//            try
//            {
//                if (Plugin.Connectivity.CrossConnectivity.Current.IsConnected)
//                {
//                    await SyncAsync();
//                }
//                return await _table.ToEnumerableAsync();
//            }
//            catch (Exception ex)
//            {
//                return empty;
//            }
//        }

//        /*public async void AddContact(Cidade contact)
//        {
//            await _table.InsertAsync(contact);

//        }*/

//        public async Task SyncAsync()
//        {
//            IReadOnlyCollection<MobileServiceTableOperationError> syncErrors = null;
//            try
//            {
                
//                await _table.PullAsync("allCidades",_table.CreateQuery());
//            }
//            catch (Exception)
//            {

//                throw;
//            }
            
//        }

//        public async Task CleanData()
//        {
//            await _table.PurgeAsync("allCidades", _table.CreateQuery(), new System.Threading.CancellationToken());
//        }

//    }
//}

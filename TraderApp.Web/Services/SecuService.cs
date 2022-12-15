using TraderApp.Model;

namespace TraderApp.Web.Services
{
    public class SecuService : ISecuService
    {
        private readonly HttpClient httpclient;

        public SecuService(HttpClient httpclient)
        {
            this.httpclient = httpclient;
        }

        public async Task<HttpResponseMessage> addSecuritites(Securities securitiy)
        {
            return await httpclient.PostAsJsonAsync<Securities>("api/secu/add",securitiy);
        }

        public async Task deleteSecuritites(int id)
        {
           await httpclient.DeleteAsync($"api/secu/{id}");
        }

        public async Task<IEnumerable<Securities>> getSecurities()
        {   var sec = await httpclient.GetFromJsonAsync<Securities[]>("/api/secu/list");
            return sec;
        }

        public async Task<HttpResponseMessage> updateSecurity(Securities securities)
        {
            return await httpclient.PutAsJsonAsync<Securities>("api/secu",securities);
        }
    }
}

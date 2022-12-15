using TraderApp.Model;

namespace TraderApp.Web.Services
{
    public interface ISecuService
    {
        Task<IEnumerable<Securities>> getSecurities();
        Task<HttpResponseMessage> addSecuritites(Securities securitiy);

        Task deleteSecuritites(int id);

        Task<HttpResponseMessage> updateSecurity(Securities securities);

    }
}

using Microsoft.AspNetCore.Mvc.Formatters;
using System.Runtime.CompilerServices;
using TraderApp.Api.Db;
using TraderApp.Model;

namespace TraderApp.Api.Repositories
{
    public class SecuritiesRepository : ISecuritiesRepositories
    {
        public static List<Securities> list = new List<Securities> {
        new Securities(0, "nvd", "Nvida", 10.20, 20)
        };



        public void addSecu(Securities secu)
        {
           secu.id = list.Count;
           list.Add(secu);
        }

        public void deleteSecu(int id)
        {
            Securities choosed = list.First(x => x.id == id);
            list.Remove(choosed);
        }

        public IEnumerable<Securities> getAll()
        {
          
            return list;

        }

        public void updateSecu(Securities security)
        {
            var result = list.First(x => x.id == security.id);
            if (result != null)
            {
                result.SoldPrice = security.SoldPrice;
            }
          

        }
    }
}

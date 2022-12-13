using Microsoft.AspNetCore.Mvc.Formatters;
using System.Runtime.CompilerServices;
using TraderApp.Api.Db;
using TraderApp.Model;

namespace TraderApp.Api.Repositories
{
    public class SecuritiesRepository : ISecuritiesRepositories
    {
        public static List<Securities> list = new List<Securities> {
        new Securities(1, "nvd", "Nvida", 10.20, 20)
        };



        public void addSecu(Securities secu)
        {
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




    }
}

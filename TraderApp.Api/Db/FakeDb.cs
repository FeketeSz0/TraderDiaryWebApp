using TraderApp.Model;

namespace TraderApp.Api.Db
{
    public class FakeDb
    {
        public IEnumerable<Securities> fakeDb() {
            List<Securities> securities = new List<Securities>();
            securities.Add(new Securities(1, "nvd", "Nvida", 10.20, 20));
            return securities;

        }
        public IEnumerable<Securities> Securities() { 
                return fakeDb();
        
        }


    }
}

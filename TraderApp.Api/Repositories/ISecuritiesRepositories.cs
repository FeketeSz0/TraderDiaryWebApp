using TraderApp.Model;

namespace TraderApp.Api.Repositories
{
    public interface ISecuritiesRepositories
    {
        public void addSecu(Securities secu);
        public void deleteSecu(int id);
        public IEnumerable<Securities> getAll();
    }
}

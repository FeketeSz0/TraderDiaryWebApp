namespace TraderApp.Web.Services
{
    public interface IStockService
    {

        event Action OnChange;
        public string stockPrice { get; set; }
        public string tag { get; set; }
        void getStockPrice();
    }
}

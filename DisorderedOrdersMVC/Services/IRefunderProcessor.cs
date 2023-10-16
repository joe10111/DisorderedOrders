namespace DisorderedOrdersMVC.Services
{
    public interface IRefunderProcessor
    {
        public bool ProcessRefund(int amount);
    }
}

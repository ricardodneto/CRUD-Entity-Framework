namespace WebApplicationCRUD.Models.Services
{
    public class SellerService
    {
        private readonly WebApplicationCRUDContext _context;

        public SellerService(WebApplicationCRUDContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}

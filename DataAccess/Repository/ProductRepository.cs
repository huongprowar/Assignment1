using BusinessObject.Models;

namespace DataAccess.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        FstoreContext _context = FstoreContext.Instance;


        public Product GetProduct(int id) => _context.Products.FirstOrDefault(x => x.ProductId == id);

        public IEnumerable<Product> GetProducts() => FstoreContext.Instance.Products;
        public void Update(Product product)
        {
            Product _product = _context.Products.FirstOrDefault(x => x.ProductId == product.ProductId);
            _product.UnitPrice = product.UnitPrice;
            _product.ProductName = product.ProductName;
            _product.Weight = product.Weight;
            _context.Update(_product);
            _context.SaveChanges();
        }

    }
}

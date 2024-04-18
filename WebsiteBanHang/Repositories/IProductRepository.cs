using WebsiteBanHang.Models;

namespace WebsiteBanHang.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task CreateAsync(Product product);
        Task EditAsync(Product product);
        Task DeleteAsync(int id);
        Task<IEnumerable<Product>> SearchByName(string name);
        Task<IEnumerable<Product>> SearchByCategory(int categoryId);
    }
}

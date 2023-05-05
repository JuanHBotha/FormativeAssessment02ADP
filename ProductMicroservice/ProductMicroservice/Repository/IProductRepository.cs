using ProductMicroservice.Model;
using System.Collections.Generic;
namespace ProductMicroservice.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int Productid);
        void InsertProduct(Product product);
        void DeleteProduct(Product product);
        void UpdateProduct(Product product);
        void Save();
        object GetProductByID(int id);
        void DeleteProduct(int id);
    }
}

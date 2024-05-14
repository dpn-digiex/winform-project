using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemTraoDoiDoCu.Models.Product
{
    internal interface IProductRepository
    {
        bool Add(ProductModel productModel);
        void Edit(ProductModel productModel);
        void EditByKeyColumn(int productId, Dictionary<string, object> updates);
        void Delete(int id);
        void InsertImage();
        int GetTotalProducts();

        ProductModel GetProductDetail(int id);

        IEnumerable<ProductModel> GetProductsByPagination(int pageNumber);
        IEnumerable<ProductModel> GetProductsByFilter(Dictionary<string, object> updates);
        IEnumerable<ProductModel> GetAll();
        IEnumerable<ProductModel> GetByValue(string value); // Searchs
    }
}

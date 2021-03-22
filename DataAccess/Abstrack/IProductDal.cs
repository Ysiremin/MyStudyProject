using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstrack
{
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
        void Uptade(Product product);
        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryId);
    }
}

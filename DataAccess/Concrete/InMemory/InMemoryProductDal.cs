using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal
    {
        //List<Category> _products;

        //public InMemoryProductDal()
        //{
        //    // Oracle, Sql Server, Postgres, MongoDb'den geliyormuş gibi simule ediyorum.
        //    //_products = new List<Category>
        //    //{
        //    //    new Category { ProductId = 1,CategoryId=1, ProductName = "Bardak", UnitPrice = 15,UnitsInStock =15},
        //    //    new Category { ProductId = 2,CategoryId=1, ProductName = "Kamera", UnitPrice = 500,UnitsInStock =3},
        //    //    new Category { ProductId = 3,CategoryId=2, ProductName = "Telefon", UnitPrice = 1500,UnitsInStock =2},
        //    //    new Category { ProductId = 4,CategoryId=2, ProductName = "Klavye", UnitPrice = 150,UnitsInStock =65},
        //    //    new Category { ProductId = 5,CategoryId=2, ProductName = "Fare", UnitPrice = 85,UnitsInStock =1}
        //    //};
        //}
        //public void Add(Category product)
        //{
        //    _products.Add(product);
        //}

        //public void Delete(Category product)
        //{
        //    Category productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
        //    _products.Remove(productToDelete);
        //}

        //public Category Get(Expression<Func<Category, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Category> GetAll()
        //{
        //    return _products;
        //}

        //public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Category> GetAllByCategory(int categoryId)
        //{
        //    List<Category> products = _products.Where(p => p.CategoryId == categoryId).ToList();
        //    return products;
        //}

        //public void Update(Category product)
        //{
        //    Category productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
        //    productToUpdate.ProductName = product.ProductName;
        //    productToUpdate.CategoryId = product.CategoryId;
        //    productToUpdate.UnitPrice = product.UnitPrice;
        //    productToUpdate.UnitsInStock = product.UnitsInStock;
        //}
    }
}

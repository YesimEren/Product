using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager:IProductService
    {
        IProductDal _productDal;
        //eğer const.oluşturmazsam istediğiöm atamayı yapmayacğım.Rrpositorydeki bütün işlemleri
        //_productdal ile yapacağım.

        public ProductManager(IProductDal productDal) // Bu const. method
        {
            _productDal = productDal; //yapıcı method.Bütün maager sınıflar için yapmamaız lazım.
        }

        public List<Product> GetList()
        {
            return _productDal.GetList();
        }

        public void TDelete(Product t)
        {
            _productDal.Delete(t);
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }

        public void Tİnsert(Product t)
        {
            _productDal.Insert(t);
        }
    }
    }

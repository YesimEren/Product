using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EntityProductDal : GenericRepository<Product>,IProductDal
    {
        //bu alanda sadece,bu methoda ait methodlar tanımladığım zaman olacak.
    }
}

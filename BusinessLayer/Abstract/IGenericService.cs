using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {

        void Tİnsert(T t);
        void TDelete(T t);
        void TUpdate(T t);

        List<T> GetList();
        T TGetById(int id);
        //Burası benim kontrollerimi yapacağım kısım.Ürün adı girerken 20 karakteri geçmesi.
        //Ürün adı giren kişi sistemde yetkili olsun.
        //Entity için GenericService yazdık.Her bir entitiy için interface tanımlamam lazım.
    }
}

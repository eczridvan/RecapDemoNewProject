using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager:IBrandService
    {
         IBrandDal _brandDal;

         public BrandManager(IBrandDal brandDal)
         {
             _brandDal = brandDal;
         }

         public List<Brand> GetAll()
         {
             return _brandDal.GetAll();
         }

        public Brand GetByIdBak(int brandId)
        {
            return _brandDal.Get(b => b.Id == brandId);
        }
    }
}

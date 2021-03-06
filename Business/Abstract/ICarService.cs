using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
   public interface ICarService
   {
       List<Car> GetAll();
       List<Car> GetAllByCategoryId(int id);
       List<Car> GetCarsByBrandId(int id);
       List<Car> GetCarsByColorId(int id);

       List<CarDetailDto> GetCarDetails();
   }
}

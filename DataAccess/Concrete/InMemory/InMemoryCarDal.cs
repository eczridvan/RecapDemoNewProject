using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
   public class InMemoryCarDal:ICarDal
   {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 250000, ModelYear = 2020, Description = "SEDAN 1.3 BENZİN"},
                new Car{Id = 2, BrandId = 1, ColorId = 2, DailyPrice = 350000, ModelYear = 2020, Description = "HP 1.6 DİZEL"},
                new Car{Id = 3, BrandId = 2, ColorId = 1, DailyPrice = 450000, ModelYear = 2020, Description = "SEDAN 1.4 BENZİN"},
                new Car{Id = 4, BrandId = 3, ColorId = 1, DailyPrice = 550000, ModelYear = 2020, Description = "DÜZ 1.8 BENZİN"},
                new Car{Id = 5, BrandId = 3, ColorId = 2, DailyPrice = 1250000, ModelYear = 2020, Description = "SUV 3.0 BENZİN"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            //Car carToUpdate = null;
            //foreach (var c in _cars)
            //{
            //    if (car.Id == c.Id)
            //    {
            //        carToUpdate.BrandId = car.BrandId;
            //        carToUpdate.ColorId = car.ColorId;
            //        carToUpdate.DailyPrice = car.DailyPrice;
            //        carToUpdate.ModelYear = car.ModelYear;
            //        carToUpdate.Description = car.Description;

            //    }
            //}

            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = carToUpdate.ModelYear;
            carToUpdate.Description = carToUpdate.Description;




        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);

            //foreach (var c in _cars)
            //{
            //    if (car.Id == c.Id )
            //    {
            //        carToDelete = c;
            //    }
            //}

            // _cars.Remove(carToDelete);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }
    }
}

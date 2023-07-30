using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 500, ModelYear = "2013", Description = "0 km" },
                new Car { Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 400, ModelYear = "2011", Description = "1000 km" },
                new Car { Id = 3, BrandId = 3, ColorId = 2, DailyPrice = 300, ModelYear = "2010", Description = "100 km" },
                new Car { Id = 4, BrandId = 1, ColorId = 1, DailyPrice = 200, ModelYear = "2009", Description = "10 km" }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public List<CarDetailDto> CarDetailDtos()
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get()
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

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            Car car = _cars.Find(c => c.Id == id);
            return car;

        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}

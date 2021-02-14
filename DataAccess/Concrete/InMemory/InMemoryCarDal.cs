using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal :ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1, BrandId=5, ColorId=1, DailyPrice=200, ModelYear=2016, Description="Ford Focus"},
                new Car{Id=2, BrandId=4, ColorId=2, DailyPrice=500, ModelYear=2017, Description="Renault Symbol"},
                new Car{Id=3, BrandId=3, ColorId=1, DailyPrice=1000, ModelYear=2021, Description="Mercedes"},
                new Car{Id=4, BrandId=2, ColorId=2, DailyPrice=100, ModelYear=2010, Description="Golf"},
                new Car{Id=5, BrandId=1, ColorId=1, DailyPrice=250, ModelYear=2019, Description="Volkswagen Jetta"},



            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
            
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == c.Id);
            _cars.Remove(carToDelete);

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

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(c => c.Id == CarId).ToList();

        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == c.Id);
          
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

            Console.WriteLine(carToUpdate.Id + "Araç Güncellendi.");



        }
    }
}

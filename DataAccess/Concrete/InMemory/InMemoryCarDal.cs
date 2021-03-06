﻿using DataAccess.Abstract;
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
                new Car{CarId=1, BrandId=5, ColorId=1, DailyPrice=200, ModelYear="2016", Descriptions="Ford Focus"},
                new Car{CarId=2, BrandId=4, ColorId=2, DailyPrice=500, ModelYear="2017", Descriptions="Renault Symbol"},
                new Car{CarId=3, BrandId=3, ColorId=1, DailyPrice=1000, ModelYear="2021", Descriptions="Mercedes"},
                new Car{CarId=4, BrandId=2, ColorId=2, DailyPrice=100, ModelYear="2010", Descriptions="Golf"},
                new Car{CarId=5, BrandId=1, ColorId=1, DailyPrice=250, ModelYear="2019", Descriptions="Volkswagen Jetta"},



            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
            
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == c.CarId);
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
            return _cars.Where(c => c.CarId == CarId).ToList();

        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == c.CarId);
          
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Descriptions = car.Descriptions;
            carToUpdate.ModelYear = car.ModelYear;

            Console.WriteLine(carToUpdate.CarId + "Araç Güncellendi.");



        }
    }
}

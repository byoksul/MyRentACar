using Business.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        InMemoryCarDal _inMemoryCarDal;

        public CarManager(InMemoryCarDal inMemoryCarDal)
        {
            _inMemoryCarDal = inMemoryCarDal;
        }

        public List<Car> GetAll()
        {
            return _inMemoryCarDal.GetAll();


           
        }
    }
}

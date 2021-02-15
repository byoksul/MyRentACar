using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;    

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.CarName.Length<2)
            {
                return new ErrorResult(Messages.CarNameInvalid);


            }

            _carDal.Add(car);

            return new SuccessResult(Messages.CarAdded);

        }
        public IResult Update(Car car)
        {
            return new SuccessResult();

        }

        public IResult Delete(Car car)
        {
            return new SuccessResult();
        }

        public IDataResult<List<Car>>GetAll()
        {
            if (DateTime.Now.Hour==13)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenceTime);
               

            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);

        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(x => x.BrandId == id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(x => x.ColorId == id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>( _carDal.GetCarDetails());
        }

        public IDataResult<Car> Get(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c=>c.CarId==id));


        }
    }
}
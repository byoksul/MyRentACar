using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll(); // Tüm Araçları getir
        IDataResult<List<Car>> GetCarsByBrandId(int id); // Marka Id sine göre getir
        IDataResult<List<Car>> GetCarsByColorId(int id); // Renk Id sine göre getir
        IDataResult<List<CarDetailDto>> GetCarDetails(Expression<Func<Car, bool>> filter = null);
        IDataResult<Car> Get(int id); // Tüm Araçları Getirecek
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<Car> GetById(int id);
        





    }
}

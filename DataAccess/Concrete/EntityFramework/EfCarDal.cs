using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (CarContext context = new CarContext())
            {
                var result = from c in context.Cars
                             join x in context.Colors
                             on c.ColorId equals x.ColorId
                             join a in context.Brands
                             on c.BrandId equals a.BrandId
                             select new CarDetailDto 
                             {
                                 CarName = c.CarName, 
                                 BrandName = a.BrandName, 
                                 ColorName = x.ColorName, 
                                 DailyPrice= (int)c.DailyPrice 
                             };
                return result.ToList();



            }
            
        }
    }
}

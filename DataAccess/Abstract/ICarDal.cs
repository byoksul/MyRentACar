using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Ürünle igili VeriTabanında yapacağım operasyonlar.

    public interface ICarDal: IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();

        

    }

}

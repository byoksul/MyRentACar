using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brand)
        {
            _brandDal = brand;

        }
                   

        public void Add(Brand brand)
        {
           if (brand.BrandName.Length >= 2)
            {
                _brandDal.Add(brand);
                
            }
            else
            {
                Console.WriteLine("Araba'nın Adı 2'den az harf olmaz..");
            }
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);

        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public List<Brand> GetById(int id)
        {
            return _brandDal.GetAll(x => x.BrandId == id);

        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);

        }
    }
}

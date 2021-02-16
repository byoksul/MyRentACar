﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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
                   

        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length > 2)
            {
                _brandDal.Add(brand);
                return new SuccessResult(Messages.AddedBrand);

            }
            return new ErrorResult(Messages.FailedBrandAddOrUpdate);
        }

        public IResult Delete(Brand brand)
        {

            _brandDal.Delete(brand);
            return new SuccessResult(Messages.DeletedBrand);

        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(  _brandDal.Get(x => x.BrandId == id));

        }

        public IResult Update(Brand brand)
        {
            if (brand.BrandName.Length>2)
            {
                _brandDal.Update(brand);
                return new SuccessResult(Messages.UpdatedBrand);

            }
            return new ErrorResult(Messages.FailedBrandAddOrUpdate);

            
            

        }
    }
}

using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal color)
        {
            _colorDal = color;

        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
           
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
           return _colorDal.GetAll();

        }

        public List<Color> GetById(int id)
        {
            return _colorDal.GetAll(x => x.ColorId == id);

        }

        public void Update(Color color)
        {
            _colorDal.Update(color);

        }
    }
}

using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DataAccess.Concrete.EntityFramework;
using Core.DataAccess.EntitiyFramework;

namespace DataAccess.Concrete.Entity_Framework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, CarContext>, IColorDal
    {
       
    }
}

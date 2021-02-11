﻿using System;
using Business.Concrete;
using DataAccess.Concrete.Entity_Framework;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}
            //Car car = new Car {BrandId = 1, ColorId = 1, DailyPrice = 100,  ModelYear = 2018};
            //carManager.Add(car);
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
                
            }


        }
    }
}
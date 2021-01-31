using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("------Araç Özellikleri-------");
                //Console.WriteLine($"{car.BrandId} \n {car.CarId} {car.ColorId} {car.DailyPrice} {car.Description} {car.ModelYear}");

                Console.WriteLine("AraçID:" + car.CarId + "MarkaID:" + car.BrandId + "Renk: " + car.ColorId + "Model:" + car.ModelYear + "Günlük Fiyatı:" + car.DailyPrice + " Markası:" + car.Description);
           
            }
            
        }
    }
}

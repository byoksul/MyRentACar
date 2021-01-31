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
                Console.WriteLine("----BY YOKSUL RENT A CAR--- \n ---Araç Özellikleri---" );
                Console.WriteLine("AraçID:" + car.CarId + "MarkaID:" + car.BrandId + "Renk:" + car.ColorId + "Model Yılı:" + car.ModelYear + "Günlük Fiyatı:" + car.DailyPrice + "Açıklama:" + car.Description);

            }

        }
    }
}

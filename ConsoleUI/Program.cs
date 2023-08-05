using Business.Concrete;
using Core.Utilities.Results.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InMemoryCarDal memoryCarDal = new InMemoryCarDal();

            EfCarDal efCarDal = new EfCarDal();



            //CarManager  carManager = new CarManager(efCarDal);
            //Car car1 = new Car();
            ////car1.Id = 5;
            //car1.CarName = "Foo";
            //car1.DailyPrice = 10;
            //car1.BrandId = 4;
            //car1.ColorId = 4;
            //car1.ModelYear = "2001";
            //car1.Description = "Test";
            ////efCarDal.Add(car1);
            //car1 = carManager.GetCar(7);
            ////car1.ColorId = 4;
            ////car1.BrandId = 4;
            ////efCarDal.Update(car1);
            ////efCarDal.Delete(car1);
       
            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(car.CarName+""+car.DailyPrice+" "+ car.BrandName+" "+car.ColorName);
            //    //Console.WriteLine(car.CarName+" "+car.ColorId);
            //}

            ////Console.WriteLine(carManager.GetCar(5).CarName);
            ///


            SuccessResult result = new SuccessResult("asd");
            Console.WriteLine(result.Success+ result.Message);



        }
    }
}
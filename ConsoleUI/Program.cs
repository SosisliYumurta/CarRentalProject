using Business.Concrete;
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



            CarManager  carManager = new CarManager(efCarDal);
       
            foreach (var car in carManager.GetCarsByColorId(4))
            {
                Console.WriteLine(car.DailyPrice+" "+car.Description);
            }
            Car car1 = new Car();
            car1.DailyPrice = 0;
            efCarDal.Add(car1);

        }
    }
}
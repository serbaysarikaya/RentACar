using Bussiness.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrandManager bm = new BrandManager(new EfBrandDal());

            //IDataResult<List<Brand>> brands = bm.GetAll();

            //foreach (Brand brand in brands.Data)
            //{
            //    Console.WriteLine($"Id: {brand.Id} -- Name: {brand.Name}");
            //    Console.WriteLine("-------------------------------------");
            //}

            //IDataResult<List<Brand>> renoBeyler = bm.GetAllByName("Renault");

            //foreach (Brand brand in renoBeyler.Data)
            //{
            //    Console.WriteLine($"Id: {brand.Id} -- Name: {brand.Name}");
            //    Console.WriteLine("-------------------------------------");
            //}




            CarManager cm = new CarManager(new EfCarDal());

            IDataResult<List<CarDto>> cardetails = cm.GetAllDetails();

            foreach(CarDto car in cardetails.Data)
            {
                Console.WriteLine($"{car.Brand}  {car.Model} -- {car.Color}");
                Console.WriteLine($"Model: {car.ModelYear} -- Kilometer: {car.Kilometer}");
            }

            Console.ReadKey();
        }
    }
}

using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            EfUserDal userDal = new EfUserDal();
            List<User> users = userDal.GetAll(u => u.UserDetailId == 2);

            foreach (User user in users)
            {
                Console.WriteLine(user.UserDetailId);
            }

            Console.ReadKey();
        }
    }
}

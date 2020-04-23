using System;
using System.Collections.Generic;
using Shopping.Business.Entity;
using Shopping.Business.Manager;
using Shopping.Helper;
using log4net.Config;


namespace Shopping
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            BasicConfigurator.Configure();
            
            CustomerManager customer = new CustomerManager();
            
            List<Customer> customers = customer.GetAll();

            Console.WriteLine($"{customers[0].LastName}");

            //customer.Show(customer.GetAll());

            List<int> ids = new List<int>();

            ids.Add(Convert.ToInt32(Console.ReadLine()));

            customer.Delete(ids.ToArray());

            //customer.Show(customer.GetAll());
            
            Customer cs = customer.GetById(Convert.ToInt32(Console.ReadLine()));
            if (cs != null)
            {
                cs.FirstName = "sasadasddasa";
                customer.Update(cs);
            }
            
            //customer.Show(customer.GetAll());
            /*
            for (int x = 1; x <= 5; x++)
            {
                Customer cs1 = new Customer(GenerateID.GetGeneratedID(), "casca", "a", "asd", "f", "sadasd", "asdas@masd", "cebu");
                customer.Add(cs1);
                Console.WriteLine("a");
            }
            */
            //customer.Add(cs1);

            //customer.Show(customer.GetAll());
        }
    }
}

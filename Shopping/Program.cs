using System;
using System.Collections.Generic;
using Shopping.Business.Model;
using Shopping.Business.Manager;
using Shopping.Helper;


namespace Shopping
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CustomerManager customer = new CustomerManager();
            
            //customer.Show(customer.GetAll());

            int id = Convert.ToInt32(Console.ReadLine());

            customer.Delete(id);

            //customer.Show(customer.GetAll());
            
            Customer cs = customer.GetById(Convert.ToInt32(Console.ReadLine()));
            if (cs != null)
            {
                cs.FirstName = "sasadasdd";
                customer.Update(cs);
            }

            //customer.Show(customer.GetAll());
            /*
            for (int x = 1; x <= 5; x++)
            {
                Customer cs1 = new Customer(GenerateID.GetGeneratedID(), "casca", "a", "asd", "f", "sadasd", "asdas@masd", "cebu");
                customer.Add(cs1);
            }*/

            //customer.Add(cs1);

            //customer.Show(customer.GetAll());
        }
    }
}

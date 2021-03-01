using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicBankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Customerİnfo person1 = new Customerİnfo();
            person1.Name = "Ahmet";
            person1.SurName = "Yıldız";
            person1.Age = 28;
            person1.Balance = 10239;
            person1.Id = 12345432;

            Customerİnfo person2 = new Customerİnfo();
            person2.Name = "Sema";
            person2.SurName = "Taşkıran";
            person2.Age = 19;
            person2.Balance = 873;
            person2.Id = 21323275;

            Customerİnfo person3 = new Customerİnfo();
            person3.Name = "Berat";
            person3.SurName = "Doğan";
            person3.Age = 34;
            person3.Balance = 20021;
            person3.Id = 19208662;

            Customerİnfo person4 = new Customerİnfo();
            person4.Name = "Abdullah";
            person4.SurName = "Sarı";
            person4.Age = 30;
            person4.Balance = 202102;
            person4.Id = 11141446;

            Customerİnfo person5 = new Customerİnfo();
            person5.Name = "Mehmet";
            person5.SurName = "Doğan";
            person5.Age = 38;
            person5.Balance = 112946;
            person5.Id = 12822401;

            Customerİnfo[] customer = new Customerİnfo[]{person1,person2,person3,person4,person5};
            CustomerManager customerManager = new CustomerManager();
            customerManager.AddPerson("Berkay","Doğan",20,1200,21331232);
            customerManager.RemovePerson(21332321,"Caner");
            Console.WriteLine("------------------------------");
            
            customerManager.ListPersons(customer);


        }
    }
}

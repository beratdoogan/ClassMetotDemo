using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicBankSystem
{
    class CustomerManager
    {
        public void AddPerson(string Name,string SurName,int Age,int Balance,int Id){
            Console.WriteLine(Name + " Eklendi");
        }
        public void RemovePerson(int Id,string Name){
            Console.WriteLine( Id + " ID'ye sahip olan " + Name + " kişisi kaldırıldı");
        }
        public void ListPersons(Customerİnfo[] customers){
           foreach(Customerİnfo customer in customers){
               Console.WriteLine("Ad : " + customer.Name);
               Console.WriteLine("Soyad : " + customer.SurName);
               Console.WriteLine("Yaş : " + customer.Age);
               Console.WriteLine("Bakiye : " + customer.Balance);
               Console.WriteLine("Id : " + customer.Id);
               Console.WriteLine("------------------------------");
               
               
           }
        }
    }
}

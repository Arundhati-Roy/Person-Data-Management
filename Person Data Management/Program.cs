using System;
using System.Collections.Generic;
using System.Linq;

namespace Person_Data_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Person Data Management!");
            //UC1 Create List and Insert records
            List<Person> listPersonsInCity = new List<Person>();
            AddPerson(listPersonsInCity);

            RetrieveTop2Records_ForAgeLessThan60(listPersonsInCity);

            Retrieve_ForTeenagers(listPersonsInCity);

            Retrieve_AverageAge(listPersonsInCity);

            Check_SpecificName(listPersonsInCity);

            SkipRecord_forAgeLessThan60(listPersonsInCity);

            RemoveSpecificName(listPersonsInCity);
        }
        public static void AddPerson(List<Person> list)
        {
            /*Console.WriteLine("Enter the details of Person ");
            Console.WriteLine("Name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Address: ");
            String addr = Console.ReadLine();
            Console.WriteLine("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("SSN: ");
            String ssn = Console.ReadLine();
            Person p = new Person(name, addr, age, ssn);
            list.Add(p);*/
            //Console.WriteLine("Person successfully added...........Following are the details\n");
            list.Add(new Person("dgvsf345", "AR", "wesdfg", 23));
            list.Add(new Person("dftgsf345", "fgh", "wesdrftgyhjfg", 67));
            list.Add(new Person("edrfg", "AjhgR", "wesdfg", 87));
            list.Add(new Person("dsjhgff35", "AbvcR", "wedfsdfg", 32));
            list.Add(new Person("dff35", "AbvdefrgcR", "wes23dfg", 45));
            list.Add(new Person("ds5", "AbwevcR", "wesdfg", 97));
            list.Add(new Person("drftgy798", "AbsdfvcR", "wes324dfg", 3));
            list.Add(new Person("rghb45", "AbsdfvcR", "w24dfg", 18));
            list.Add(new Person("5ertdf", "zsdxc", "wes3fg", 13));
            list.Add(new Person("8yiu", "7yeuhd", "wes32", 15));


        }
        //UC2
        public static void RetrieveTop2Records_ForAgeLessThan60(List<Person> list)
        {
            Console.WriteLine("\nRetrieveTop2Records_ForAgeLessThan60");
            foreach (Person p in list.FindAll(e => (e.age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name: " + p.Name + "\nAge: " + p.age);
            }
        }
        //UC3
        public static void Retrieve_ForTeenagers(List<Person> list)
        {
            Console.WriteLine("\nRetrieve for age between 13 to 18(incl)");
            foreach (Person p in list.FindAll(e => (e.age <= 18 && e.age >= 13)).ToList())
            {
                Console.WriteLine("Name: " + p.Name + "\nAge: " + p.age);
            }
        }
        //UC4
        public static void Retrieve_AverageAge(List<Person> list)
        {
            Console.WriteLine("\nRetrieve average age");
            int average = 0;
            foreach (Person p in list)
            {
                average = (int)list.Average(p => p.age);
            }
            Console.WriteLine("Average Age: " + average);
        }
        //UC5
        public static void Check_SpecificName(List<Person> list)
        {
            Console.WriteLine("\nSearch for: ");
            string name = Console.ReadLine();
            var b = list.FindAll(e => (e.Name == name)).FirstOrDefault();
            if (b != null)
            {
                Console.WriteLine("Name: " + b.Name + "\nAge: " + b.age);
            }
            else
                Console.WriteLine("Does not exist");
        }
        //UC6
        public static void SkipRecord_forAgeLessThan60(List<Person> list)
        {
            Console.WriteLine("\nSkipRecord_forAgeLessThan60 ");
            foreach (Person p in list.FindAll(e => (e.age > 60)).ToList())
            {
                Console.WriteLine("Name: " + p.Name + "\nAge: " + p.age);
            }
        }
        //UC7
        public static void RemoveSpecificName(List<Person> list)
        {
            Console.WriteLine("\nName to be Removed: ");
            string name = Console.ReadLine();
            var b = list.FindAll(e => (e.Name == name)).FirstOrDefault();
            if (b != null)
            {
                Console.WriteLine("Removed Name and Age");
                Console.WriteLine("Name: " + b.Name + "\nAge: " + b.age);
                list.Remove(b);
            }
            else
                Console.WriteLine("Does not exist");
        }
    }
}


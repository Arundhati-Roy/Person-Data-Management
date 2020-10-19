using System;
using System.Collections.Generic;
using System.Text;

namespace Person_Data_Management
{
    class Person
    {
        public string Name, address, SSN;
        public int age;

        public Person(string ssn,string Name, string address, int age)
        {
            this.Name = Name;
            this.address = address;
            this.age = age;
            this.SSN = ssn;
        }

        public string getFirstName()
        {
            return this.Name;
        }
        public void setFirstName(string Name)
        {
            this.Name = Name;
        }

        

        public string getAddress()
        {
            return this.address;
        }
        public void setAddress(string add)
        {
            this.address = add;
        }

       
        public long getAge()
        {
            return this.age;
        }
        public void setPhone(int age)
        {
            this.age = age;
        }
        public string getSSN()
        {
            return this.SSN;
        }
        public void setSSN(string ssn)
        {
            this.SSN = ssn;
        }
    }
}

using System;

namespace sushnost
{
    class Person
    {
        public string FirtsName;
        public string LastName;
        public int age;     

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {FirtsName} \nФамилия:{LastName}  \nВозраст: {age}");
        }
    }
              class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person();
            tom.GetInfo();      

            tom.FirtsName = "Tom";
            tom.LastName = "Azizov";
            tom.age = 34;
            tom.GetInfo();  
            Console.ReadKey();
        }
    }
}

    
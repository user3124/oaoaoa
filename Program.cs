using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ext0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "MyName asdasd asdasd sd";
            value.MyMethod();

            int num = 4;
            int result = num.ToPower(3);
            Console.WriteLine(result);

            Person ktoto = new Person("Oleg", 23);
            ktoto.GetAge();

            Console.WriteLine(value.WordCount()); // Число слов через пробелы
        }
    }

    public static class MyClass
    {
        public static void MyMethod(this string str)
        {
            Console.WriteLine(str + "_test");
        }

        public static void GetAge(this Person person)
        {
            Console.WriteLine(person.Age);
        }

        public static int ToPower(this int number, int power = 0)
        {
            int temp = 1;
            
            for (int howMuch = 0; howMuch < power; ++howMuch)
            {
                temp *= number;
            }

            return temp;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello, my name is {Name}");
        }
    }

    public static class StringUtilities
    {
        public static int WordCount(this string text)
        {
            return text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}

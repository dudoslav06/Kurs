using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj dzien swoich urodzin:");
            int dayOfBirthDate = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj miesiac swoich urodzin:");
            int mounthOfBirthDate = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj rok swoich urodzin:");
            int yearOfBirthDate = int.Parse(Console.ReadLine());


            DateTime dateOfBirth = new DateTime(yearOfBirthDate, mounthOfBirthDate, dayOfBirthDate);
            TimeSpan timeSpan = DateTime.Now - dateOfBirth;



            Console.WriteLine(timeSpan);

            






            //byte byteValue = 100;
            //int intValue = byteValue;
            //byte byteValue2 = (byte)intValue;
            //string userInput = Console.ReadLine();
            //int yearOfBirth;
            //if (int.TryParse(userInput, out yearOfBirth))
            //{
            //    int age = DateTime.Now.Year - yearOfBirth;

            //    Console.WriteLine("You are" + age);
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect value");
            //}
            Console.ReadKey();
        }
    }
}

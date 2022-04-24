using System;

namespace MiPrimerPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int height;
            height = 170;

            int age = 20;

            string name = "Juan Carlos";

            string information = name + " tiene " + age + " años y mide " + height + " cm.";
            Console.WriteLine(information);

            if (age < 20)
            {
                Console.WriteLine("Es menor a 20");
            }
            else
            {
                Console.WriteLine("Es mayor a 20");
            }

            int items = 2;
            while (items > 0)
            {
                Console.WriteLine(items);
                items = items - 1;
            }

            int[] vectorDeNumerosEnteros = new int[5];
            vectorDeNumerosEnteros[0] = 123;
            vectorDeNumerosEnteros[1] = 547;

        }
    }
}

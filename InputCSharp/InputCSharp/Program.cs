using System;
using System.Globalization;

namespace Course {
    class Progam {
        static void Main(string[] args) {

            string name1 = Console.ReadLine();

            char sex1 = char.Parse(Console.ReadLine());

            double wage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string one = vet[0];
            string two = vet[1];
            string three = vet[2];

            string[] date = Console.ReadLine().Split(' ');
            string name2 = date[0];
            char sex2 = char.Parse(date[1]);
            int age = int.Parse(date[2]);
            double height = double.Parse(date[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você Digitou: ");
            Console.WriteLine(name1);
            Console.WriteLine(sex1);
            Console.WriteLine(wage.ToString("F2", CultureInfo.InvariantCulture));   
            Console.WriteLine(one);
            Console.WriteLine(two);
            Console.WriteLine(three);

            Console.WriteLine(name2);
            Console.WriteLine(sex2);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_alquiler_coche
{
    class Program
    {
        static void Main(string[] args)
        {

            string name,license;
            int age,where,ChosenDays,days,weeks,payment,discount;
            bool licenseAnswer;

            const int pricedays = 10;
            const int weekdays = 7;


            Console.WriteLine("Introduzca su nombre:");
            name = Console.ReadLine();
            Console.WriteLine("Cliente:" + name);
            
            Console.WriteLine("Introduzca su edad:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cliente " + name + " de " + age + " años.");

            Console.WriteLine("Tiene carnet de conducir? Responda S ó N");
            license = Console.ReadLine();

            Console.Write("El cliente " + name + " de " + age + " años, ");

            if (license == "s" || license == "S")
            {
                licenseAnswer = true;
                Console.WriteLine("con carnet de conducir.");
            }
            else
            {
                licenseAnswer = false;
                Console.WriteLine("sin carnet de conducir.");
            }

            if (licenseAnswer = false || age < 18)
            {
                Console.WriteLine("No puedes alquilar un coche.");
            }
            else
            {

                Console.WriteLine("¿Donde desea alquilar el coche?");
                Console.WriteLine("1.Bilbao");
                Console.WriteLine("2.Barcelona");
                Console.WriteLine("3.Madrid");
                Console.WriteLine("4.Santander");
                where = Convert.ToInt32(Console.ReadLine());

                Console.Write("Vas a recoger el coche en ");
                switch (where)
                {
                    case 1:
                        Console.WriteLine("Bilbao");
                        break;
                    case 2:
                        Console.WriteLine("Barcelona");
                        break;
                    case 3:
                        Console.WriteLine("Madrid");
                        break;
                    case 4:
                        Console.WriteLine("Santander");
                        break;
                }

                Console.Write("¿Cuantos dias desea alquilar el coche?");
                ChosenDays = Convert.ToInt32(Console.ReadLine());


                weeks = ChosenDays / weekdays;
                days = ChosenDays % weekdays;
                discount = ChosenDays - weeks;
                payment = discount * pricedays;



                Console.WriteLine("Cliente " + name + " de " + age + " años  y carnet de conducir.");
                Console.Write("Va a recoger el coche en ");

                switch (where)
                {
                    case 1:
                        Console.Write("Bilbao");
                        break;
                    case 2:
                        Console.Write("Barcelona");
                        break;
                    case 3:
                        Console.Write("Madrid");
                        break;
                    case 4:
                        Console.Write("Santander");
                        break;
                }

                if (ChosenDays < 7)
                {
                    Console.WriteLine("Alquila durante " + ChosenDays + ("dias"));
                }
                else if (ChosenDays > 7)
                {
                    Console.WriteLine("Alquila durante " + weeks + " semana(s)" + days + ("dias"));
                }

                Console.WriteLine("Por la cantidad de " + payment + " euskos");
            }           
            Console.ReadLine();





        }
    }
}

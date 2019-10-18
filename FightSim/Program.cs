using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in namn på fighter: ");

            Fighter fighter = new Fighter();
            {
                fighter.namn = Console.ReadLine();

            };

            Console.WriteLine("" + fighter.namn + "!");

            Console.WriteLine("Skriv in namn på fighter2: ");

            Fighter fighter2 = new Fighter();
            {
                fighter2.namn = Console.ReadLine();

            };

            
            Console.WriteLine("" + fighter2.namn + "!");

            Console.ReadLine();

            




            


            Console.WriteLine("Nu börjar fighten");

            Console.ReadLine();


            Random generator = new Random();


           



            fighter.liv = 9;

            fighter2.liv = 10;

            

            while (fighter2.liv >= 0 && fighter.liv >= 0)
            {


                int damage = generator.Next(0, 5);

                fighter2.liv -= damage;

                
                Console.WriteLine(""+ fighter.namn + " slår " + fighter2.namn + " med " + damage + "!" );
                Console.WriteLine("" + fighter2.namn + " har " + fighter2.liv + " liv kvar.");

                Console.ReadLine();

                damage = generator.Next(0, 5);

                fighter.liv -= damage;

                Console.WriteLine("" + fighter2.namn + " slår " + fighter.namn + " med " + damage + "!");
                Console.WriteLine("" + fighter.namn + " har " + fighter.liv + " liv kvar");

                fighter.liv -= damage;

                Console.ReadLine();


            }



            if (fighter2.liv < 0)
            {



                Console.WriteLine("Ser ut som att " + fighter.namn + " vann!! Grattis!");

                Console.ReadLine();



            }

            else if (fighter.liv < 0)
            {
                Console.WriteLine("Ser ut som att " + fighter2.namn + " vann!! Grattis!");

                Console.ReadLine();



            }



            Console.WriteLine("Match över!");

            Console.ReadLine();





        }
    }
}

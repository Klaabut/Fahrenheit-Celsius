using System;

namespace KTFahrenheitCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere! See on siin on Fahrenheit-Celsius kalkulaator.");
            Start:
            Console.WriteLine("Kui soovite teisaldada Fahrenheiti Celsiuseks, siis vajutage 1 ja kui soovite Celsiust Fahrenheitiks teha siis vajutage 2.");
            int vastus;
            double sisest;
            
            vastus = int.Parse(Console.ReadLine());

            if (vastus == 1)
            {

                Console.WriteLine("Teisaldame Fahrenheiti Celsiuseks. Sisestage temperatuur(F)");
                sisest = double.Parse(Console.ReadLine());
                fahrenheitCelsiuseks(sisest);


            }
            else if (vastus == 2)
            {
                Console.WriteLine("Teisaldame Celsiuse Fahrenheitiks. Sisestage temperatuur(C)");
                sisest = double.Parse(Console.ReadLine());
                celsiusFahrenheitiks(sisest);
            }
            else
            {
                Console.WriteLine("Sisestage 1 või 2, kolmandat valikut ei ole ju >:( !!!");
                goto Start;
            }

            // TAHTSIN PANNA ALG TEMPERATUURI KÜSIMIST KA FUNKTSIOONI SISSE KUID SEE EI TÖÖTANUD, AGA NII TÖÖTAB :).

            Console.ReadLine();
        }

        public static void fahrenheitCelsiuseks(double sisest)
        {
            double teisaldus;
            

            teisaldus = (sisest - 32) * 5 / 9;

            Console.WriteLine($"{sisest} kraadi F. skaalal on {teisaldus} kraadi Celsiuse skaalal.");
        }
        public static void celsiusFahrenheitiks(double sisest)
        {
            double teisaldus;
            

            teisaldus = (sisest * 9) / 5 + 32;

            Console.WriteLine($"{sisest} kraadi C. skaalal on {teisaldus} kraadi Fahrenheiti skaalal.");
        }
    }
}

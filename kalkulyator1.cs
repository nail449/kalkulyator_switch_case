using System;

namespace first_project
{
    class Kalkulyator
    {
        static void Main(string[] args)
        {
           Console.Write("1-ci ededi daxil edin: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2-ci ededi daxil edin: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
           Console.Write("Hansi emeliyyati yerine yetirmek isteyirsiniz? ");
            string emeliyyat = Console.ReadLine();

            switch (emeliyyat)
            {
                case "+":
                    Console.WriteLine("Netice: {0}", num1 + num2);
                    break;
                case "-":
                    Console.WriteLine("Netice: {0}", num1 - num2);
                    break;
                case "*":
                    Console.WriteLine("Netice: {0}",num1 * num2);
                    break;
                case "/":
                    Console.WriteLine("Netice: {0}",num1 / num2);
                    break;
                case "%":
                    Console.WriteLine("Netice: {0}",num1 % num2);
                    break;
                default:
                    Console.WriteLine("Teessuf ki,bele bir emeliyyat movcud deyil.");
                    break;
            }


                }   
    }
}

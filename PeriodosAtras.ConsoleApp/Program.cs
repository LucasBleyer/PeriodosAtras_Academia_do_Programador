using System;

namespace PeriodosAtras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data de hoje: " + DateTime.Now.ToShortDateString());

            int dias, meses, anos;
            while (true)
            {
                Console.Write("Digite uma data (dd/mm/YYYY): ");
                string data_str = Console.ReadLine();

                string[] data_array = data_str.Split('/');
                string dias_array = data_array[0];
                string meses_array = data_array[1];
                string anos_array = data_array[2];

                dias = Convert.ToInt32(dias_array);
                meses = Convert.ToInt32(meses_array);
                anos = Convert.ToInt32(anos_array);

                if (dias <= 31 && meses <= 12 && anos <= 2022)
                {
                    Console.WriteLine("Data informada: {0}/{1}/{2}", dias, meses, anos);
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Formato incorreto, digite novamente...\n");
                    Console.ResetColor();
                }
            }
        }
    }
}
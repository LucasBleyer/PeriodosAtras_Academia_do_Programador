using System;

namespace PeriodosAtras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data de hoje: " + DateTime.Now.ToShortDateString());

            Console.Write("Digite uma data (dd/mm/YYYY): ");
            string data_str = Console.ReadLine();

            string[] data_array = data_str.Split('/');
            string dias_array = data_array[0];
            string meses_array = data_array[1];
            string anos_array = data_array[2];

            int dias = Convert.ToInt32(dias_array);
            int meses = Convert.ToInt32(meses_array);
            int anos = Convert.ToInt32(anos_array);

            if (dias <= 31 && meses <= 12 && anos <= 2022)
            {
                Console.WriteLine("{0}/{1}/{2}", dias, meses, anos);
            }
        }
    }
}

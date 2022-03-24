using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras.ConsoleApp
{
    internal class Notificador
    {
        public enum TipoMensagem
        {
            Erro,Sucesso
        }

        public void ApresentarMensagem(string mensagem, TipoMensagem tipo)
        {
            switch (tipo)
            {
                case TipoMensagem.Sucesso:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case TipoMensagem.Erro:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }

            Console.WriteLine();
            Console.WriteLine(mensagem);
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Layout.TelaPrincipal();

            Console.WriteLine("                             ");
            Console.WriteLine(" Digite a Opção Desejada :   ");
            Console.WriteLine(" =========================   ");
            Console.WriteLine(" 1 - Criar Conta             ");
            Console.WriteLine(" =========================   ");
            Console.WriteLine(" 2 - Entrar com CPF e Senha  ");
            Console.WriteLine(" =========================   ");

            Console.ReadKey();
        }
    }
}

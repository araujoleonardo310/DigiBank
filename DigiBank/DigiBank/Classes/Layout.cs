using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank
{
    public class Layout
    {
        private static int opcao = 0;

        public static void TelaPrincipal()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();

            Console.WriteLine("                             ");
            Console.WriteLine(" Digite a Opção Desejada :   ");
            Console.WriteLine(" =========================   ");
            Console.WriteLine(" 1 - Criar Conta             ");
            Console.WriteLine(" =========================   ");
            Console.WriteLine(" 2 - Entrar com CPF e Senha  ");
            Console.WriteLine(" =========================   ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    TelaCriarConta();
                    break;
                case 2:
                    Console.WriteLine("Opção 2");
                    break;

                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }

        }

        private static void TelaCriarConta()
        {
            Console.Clear();

            Console.WriteLine("                             ");
            Console.WriteLine(" Digite seu nome :           ");
            Console.WriteLine(" =========================   ");
            Console.WriteLine(" Digite o CPF                ");
            Console.WriteLine(" =========================   ");
            Console.WriteLine(" Digite sua senha            ");
            Console.WriteLine(" =========================   ");


        }
    }
}

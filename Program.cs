using System;

namespace Gritador_Etec_AT_
{
    class Program
    {
        static void Main(string[] args)
        {
            string NomeDoUsuario;

            Console.Write("Por Favor, digite seu nome: ".ToUpper());
            NomeDoUsuario = Console.ReadLine();
            
            Console.Write("Obrigado, ".ToUpper());
            Console.Write(NomeDoUsuario .ToUpper());

            Console.WriteLine("!! Clique em qualquer tecla para finalizar...".ToUpper());
            Console.ReadLine();
            
            




        }
    }
}

using System;

namespace CursoGitHub.InterfaceConsole
    //inicio do namespace
{
    internal class Program
    {//inicio da classe
        static void Main(string[] args)
        { //inicio do método
            /*
             * Main - principal
             * O método inicia-se com a letra maiscula
             * Variável
             * É um espaço reservado na memória
             */
            string pergunta;
            string resposta="git init";
            Console.WriteLine("Qual comando para iniciar o git?");
            pergunta = Console.ReadLine();
            if (pergunta.Equals(resposta))
            {
                Console.WriteLine("acertou");
            }
            else
            {
                Console.WriteLine("errou");
            }
            Console.WriteLine($"A resposta é : {resposta}");
            Console.WriteLine(resposta);
            resposta = Console.ReadLine();

//            Console.WriteLine("Alô Mundo!");
        }
    }//fim do método
}//fim da classe
//fim do namespace
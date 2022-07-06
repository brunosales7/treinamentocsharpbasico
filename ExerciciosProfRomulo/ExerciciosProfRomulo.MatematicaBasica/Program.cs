using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProfRomulo.MatematicaBasica
{
    internal class Program
    {
        static void Main(string[] args)//Exercício 4- Crie um programa para a escolinha Tic Tic calcular 3 notas de um aluno.
                                       //Entrar com o nome do aluno e as três notas
                                       //Mostrar a soma das notas e a média.

        {
            // 1 º declara as variáveis
            string nome, resultado;
            double soma, nota1, nota2, nota3;
            double media;
            
            //2º entrada de dados

            Console.WriteLine("Introduza o nome do aluno = ");
            nome = (Console.ReadLine());
            Console.WriteLine("Introduza a nota 1 = ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduza a nota 2 = ");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduza a nota 3 = ");
            nota3 = double.Parse(Console.ReadLine());
            soma = ((nota1 + nota2 + nota3));
            Console.WriteLine($"Essa e sua nota total = {soma}");
            media = (nota1 + nota2 + nota3) /3;
            Console.WriteLine($"Essa e sua media = {media}");



            if (media >= 7)
            {
                resultado = ("aprovado");
            } else if (media >= 10)
            {
                resultado = ("aprovado");
                    }
            else if (media <= 4)

            {
                resultado = ("reprovado");
            } else if (media >= 3)
            {
                resultado = ("reprovou");
            };
            Console.WriteLine($"O aluno obteve a media  = {media} e foi reprovado");



        }
    }
}

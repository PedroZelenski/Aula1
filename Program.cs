using System;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Digite seu nome: ");
            //string nome = Console.ReadLine();
            //Console.WriteLine($"Bem-vindo, {nome}");

            //if (nome == "Pedro")
            //    Console.WriteLine("Este e o meu nome!");

            //else
            //    Console.WriteLine("Este nao e meu nome!");

            //Console.WriteLine("Digite a sua idade:");
            //int idade = Convert.ToInt32(Console.ReadLine());

            //while (idade > 0)
            //{
            //    Console.WriteLine(idade);
            //    idade = idade - 1;
            //}

            //for (int i = idade; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //string[] nomes = new string[5];
            //nomes[0] = "Paulo";
            //nomes[1] = "Pedro";
            //nomes[2] = "Diego";
            //nomes[3] = "Camila";
            //nomes[4] = "Danilo";

            //Console.WriteLine("Alunos do primeiro sabado de aula: ");

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($" - {nomes[i]}");
            //}

            Console.WriteLine("Digite o primeiro numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;
            string operacao = "";

            Console.WriteLine("Informe a operacao (+, -, *, ou /): ");
            operacao = Console.ReadLine();

            while (operacao != "+" && operacao != "-" && operacao != "*" && operacao != "/")
            {

                Console.WriteLine("Informe a operacao (+, -, *, ou /): ");
                operacao = Console.ReadLine();

                switch (operacao)
                {
                    case "+":
                        resultado = num1 + num2;
                        break;

                    case "-":
                        resultado = num1 - num2;
                        break;

                    case "*":
                        resultado = num1 * num2;
                        break;

                    case "/":
                        resultado = num1 / num2;
                        break;

                    default:
                        Console.WriteLine("Voce nao digitou a operacao correta.");
                        break;
                }
            }

            Console.WriteLine($"O resultado e: {resultado}");
        }
    }
}

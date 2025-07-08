using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Calculadora de IMC");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Calcular IMC");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            if (opcao == "0")
            {
                Console.WriteLine("Saindo...");
                break;
            }
            else if (opcao == "1")
            {
                double peso = LerDouble("Digite seu peso em kg: ");
                double altura = LerDouble("Digite sua altura em metros (ex: 1.75): ");

                double imc = CalcularIMC(peso, altura);
                string classificacao = ClassificarIMC(imc);

                Console.WriteLine($"\nSeu IMC é {imc:F2}");
                Console.WriteLine($"Classificação: {classificacao}\n");
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.\n");
            }
        }
    }

    static double LerDouble(string mensagem)
    {
        double valor;
        while (true)
        {
            Console.Write(mensagem);
            string input = Console.ReadLine();
            if (double.TryParse(input, out valor) && valor > 0)
                return valor;
            Console.WriteLine("Valor inválido. Por favor, digite um número positivo.\n");
        }
    }

    static double CalcularIMC(double peso, double altura)
    {
        return peso / (altura * altura);
    }

    static string ClassificarIMC(double imc)
    {
        if (imc < 18.5)
            return "Abaixo do peso";
        else if (imc < 25)
            return "Peso normal";
        else if (imc < 30)
            return "Sobrepeso";
        else
            return "Obesidade";
    }
}

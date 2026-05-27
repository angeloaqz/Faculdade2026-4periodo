// Exercicio 1
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o nome do produto: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o preço do produto: ");
        string precoTexto = Console.ReadLine();

        try
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("O nome do produto não pode estar em branco.");

            float preco = float.Parse(precoTexto);

            if (preco <= 0)
                throw new ArgumentException("O preço deve ser maior que zero.");

            Console.WriteLine($"\nProduto cadastrado: {nome} — R$ {preco:F2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: O preço digitado não é um número válido.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}

//Exercicio 2 
using System;

class Program
{
    static float ConverterParaCelsius(string entrada)
    {
        return float.Parse(entrada);
    }

    static void Main()
    {
        float temperatura = 0;
        bool entradaValida = false;

        while (!entradaValida)
        {
            Console.Write("Digite a temperatura em Celsius: ");
            string entrada = Console.ReadLine();

            try
            {
                temperatura = ConverterParaCelsius(entrada);
                entradaValida = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Valor inválido. Digite um número válido.\n");
            }
        }

        Console.WriteLine($"Temperatura válida: {temperatura}°C");
    }
}

//Exercicio 3
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        string entrada = Console.ReadLine();

        try
        {
            int numero = int.Parse(entrada);
            Console.WriteLine($"Número digitado: {numero}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Valor inválido. Por favor, digite um número inteiro.");
        }
    }
}

//Exercicio 4 
using System;

class IdadeInvalidaException : Exception
{
    public IdadeInvalidaException(string mensagem) : base(mensagem) { }
}

class Program
{
    static void VerificarIdade(int idade)
    {
        if (idade < 18)
            throw new IdadeInvalidaException("Idade mínima para acesso é 18 anos.");

        Console.WriteLine("Acesso permitido.");
    }

    static void Main()
    {
        Console.Write("Digite a idade: ");
        string entrada = Console.ReadLine();

        try
        {
            int idade = int.Parse(entrada);
            VerificarIdade(idade);
        }
        catch (IdadeInvalidaException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Digite um número válido.");
        }
    }
}

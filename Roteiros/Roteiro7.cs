//Exercicio 1 
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> listaDeCompras = new List<string>();
        string opcao = "";

        while (opcao != "4")
        {
            Console.WriteLine("\n--- LISTA DE COMPRAS ---");
            Console.WriteLine("1 - Adicionar item");
            Console.WriteLine("2 - Remover item");
            Console.WriteLine("3 - Listar itens");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha: ");
            opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Console.Write("Nome do item: ");
                string item = Console.ReadLine();
                listaDeCompras.Add(item);
                Console.WriteLine($"'{item}' adicionado!");
            }
            else if (opcao == "2")
            {
                Console.Write("Nome do item a remover: ");
                string item = Console.ReadLine();

                if (listaDeCompras.Remove(item))
                    Console.WriteLine($"'{item}' removido!");
                else
                    Console.WriteLine("Item não encontrado na lista.");
            }
            else if (opcao == "3")
            {
                if (listaDeCompras.Count == 0)
                {
                    Console.WriteLine("Lista vazia.");
                }
                else
                {
                    Console.WriteLine($"\nItens na lista ({listaDeCompras.Count} total):");
                    foreach (string item in listaDeCompras)
                        Console.WriteLine($"  - {item}");
                }
            }
        }
    }
}

//Exercicio 2
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> catalogo = new Dictionary<int, string>();
        string opcao = "";

        while (opcao != "4")
        {
            Console.WriteLine("\n--- CATÁLOGO DE PRODUTOS ---");
            Console.WriteLine("1 - Adicionar produto");
            Console.WriteLine("2 - Buscar produto por código");
            Console.WriteLine("3 - Listar todos os produtos");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha: ");
            opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Console.Write("Código do produto: ");
                int codigo = int.Parse(Console.ReadLine());

                if (catalogo.ContainsKey(codigo))
                {
                    Console.WriteLine("Erro: esse código já existe no catálogo.");
                }
                else
                {
                    Console.Write("Nome do produto: ");
                    string nome = Console.ReadLine();
                    catalogo.Add(codigo, nome);
                    Console.WriteLine("Produto adicionado!");
                }
            }
            else if (opcao == "2")
            {
                Console.Write("Digite o código: ");
                int codigo = int.Parse(Console.ReadLine());

                if (catalogo.ContainsKey(codigo))
                    Console.WriteLine($"Produto: {catalogo[codigo]}");
                else
                    Console.WriteLine("Código não encontrado.");
            }
            else if (opcao == "3")
            {
                if (catalogo.Count == 0)
                {
                    Console.WriteLine("Catálogo vazio.");
                }
                else
                {
                    Console.WriteLine("\nProdutos cadastrados:");
                    foreach (KeyValuePair<int, string> par in catalogo)
                        Console.WriteLine($"  Código {par.Key}: {par.Value}");
                }
            }
        }
    }
}

//Exercicio 3 
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> numerosUnicos = new HashSet<int>();

        Console.WriteLine("Digite números inteiros (0 para parar):");

        while (true)
        {
            Console.Write("Número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero == 0)
                break;

            bool adicionado = numerosUnicos.Add(numero);

            if (!adicionado)
                Console.WriteLine("  (duplicata ignorada)");
        }

        Console.WriteLine($"\nNúmeros únicos digitados ({numerosUnicos.Count}):");
        foreach (int n in numerosUnicos)
            Console.WriteLine($"  {n}");
    }
}

//Exercicio 4 
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> fila = new Queue<string>();
        string opcao = "";

        while (opcao != "4")
        {
            Console.WriteLine("\n--- FILA DE ATENDIMENTO ---");
            Console.WriteLine($"Clientes na fila: {fila.Count}");
            Console.WriteLine("1 - Adicionar cliente");
            Console.WriteLine("2 - Atender próximo cliente");
            Console.WriteLine("3 - Ver tamanho da fila");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha: ");
            opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Console.Write("Nome do cliente: ");
                string nome = Console.ReadLine();
                fila.Enqueue(nome);
                Console.WriteLine($"'{nome}' entrou na fila.");
            }
            else if (opcao == "2")
            {
                if (fila.Count == 0)
                {
                    Console.WriteLine("Fila vazia! Nenhum cliente para atender.");
                }
                else
                {
                    string proximo = fila.Dequeue();
                    Console.WriteLine($"Atendendo: {proximo}");
                    Console.WriteLine($"Clientes restantes: {fila.Count}");
                }
            }
            else if (opcao == "3")
            {
                Console.WriteLine($"Há {fila.Count} cliente(s) na fila.");
                if (fila.Count > 0)
                    Console.WriteLine($"Próximo a ser atendido: {fila.Peek()}");
            }
        }
    }
}

//Exercicio 5 
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();

        Stack<char> pilha = new Stack<char>();

        foreach (char c in palavra)
            pilha.Push(c);

        string invertida = "";
        while (pilha.Count > 0)
            invertida += pilha.Pop();

        Console.WriteLine($"Palavra original:  {palavra}");
        Console.WriteLine($"Palavra invertida: {invertida}");
    }
}

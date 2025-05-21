using System;
using System.Collections.Generic;

namespace MenuEstruturasDados
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal();
        }

        static void MenuPrincipal()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== MENU PRINCIPAL ====");
                Console.WriteLine("1. Vetores");
                Console.WriteLine("2. Matrizes");
                Console.WriteLine("3. Trabalhar com Lista");
                Console.WriteLine("4. Trabalhar com Fila");
                Console.WriteLine("5. Trabalhar com Pilha");
                Console.WriteLine("6. Algoritmos de Pesquisa");
                Console.WriteLine("7. Encerrar");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": Vetores.Menu(); break;
                    case "2": Matrizes.Menu(); break;
                    case "3": Lista.Menu(); break;
                    case "4": Fila.Menu(); break;
                    case "5": Pilha.Menu(); break;
                    case "6": Pesquisa.Menu(); break;
                    case "7": return;
                    default: Console.WriteLine("Opção inválida!"); Console.ReadKey(); break;
                }
            }
        }
    }

    public static class Vetores
    {
        static List<int> vetor = new();

        public static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- MENU VETORES ---");
                Console.WriteLine("1. Inserir elemento");
                Console.WriteLine("2. Remover elemento");
                Console.WriteLine("3. Exibir todos");
                Console.WriteLine("4. Buscar elemento");
                Console.WriteLine("5. Voltar");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": Console.Write("Valor: "); vetor.Add(int.Parse(Console.ReadLine())); break;
                    case "2": Console.Write("Valor a remover: "); vetor.Remove(int.Parse(Console.ReadLine())); break;
                    case "3": foreach (var item in vetor) Console.WriteLine(item); Console.ReadKey(); break;
                    case "4": Console.Write("Valor a buscar: "); Console.WriteLine(vetor.Contains(int.Parse(Console.ReadLine())) ? "Encontrado" : "Não encontrado"); Console.ReadKey(); break;
                    case "5": return;
                    default: Console.WriteLine("Opção inválida"); Console.ReadKey(); break;
                }
            }
        }
    }

    public static class Matrizes
    {
        static int[,] matriz = new int[3, 3];

        public static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- MENU MATRIZES ---");
                Console.WriteLine("1. Inserir elemento");
                Console.WriteLine("2. Exibir todos");
                Console.WriteLine("3. Buscar elemento");
                Console.WriteLine("4. Voltar");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Linha: "); int l = int.Parse(Console.ReadLine());
                        Console.Write("Coluna: "); int c = int.Parse(Console.ReadLine());
                        Console.Write("Valor: "); matriz[l, c] = int.Parse(Console.ReadLine());
                        break;
                    case "2":
                        for (int i = 0; i < 3; i++)
                            for (int j = 0; j < 3; j++)
                                Console.WriteLine($"[{i},{j}]: {matriz[i, j]}");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Write("Valor a buscar: ");
                        int val = int.Parse(Console.ReadLine());
                        bool encontrado = false;
                        for (int i = 0; i < 3; i++)
                            for (int j = 0; j < 3; j++)
                                if (matriz[i, j] == val) encontrado = true;
                        Console.WriteLine(encontrado ? "Encontrado" : "Não encontrado");
                        Console.ReadKey();
                        break;
                    case "4": return;
                    default: Console.WriteLine("Opção inválida"); Console.ReadKey(); break;
                }
            }
        }
    }

    public static class Lista
    {
        static List<string> lista = new();

        public static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- MENU LISTA ---");
                Console.WriteLine("1. Inserir elemento");
                Console.WriteLine("2. Remover elemento");
                Console.WriteLine("3. Exibir todos");
                Console.WriteLine("4. Buscar elemento");
                Console.WriteLine("5. Voltar");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": Console.Write("Valor: "); lista.Add(Console.ReadLine()); break;
                    case "2": Console.Write("Valor a remover: "); lista.Remove(Console.ReadLine()); break;
                    case "3": foreach (var item in lista) Console.WriteLine(item); Console.ReadKey(); break;
                    case "4": Console.Write("Valor a buscar: "); Console.WriteLine(lista.Contains(Console.ReadLine()) ? "Encontrado" : "Não encontrado"); Console.ReadKey(); break;
                    case "5": return;
                    default: Console.WriteLine("Opção inválida"); Console.ReadKey(); break;
                }
            }
        }
    }

    public static class Fila
    {
        static Queue<string> fila = new();

        public static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- MENU FILA ---");
                Console.WriteLine("1. Inserir elemento");
                Console.WriteLine("2. Remover elemento");
                Console.WriteLine("3. Exibir todos");
                Console.WriteLine("4. Voltar");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": Console.Write("Valor: "); fila.Enqueue(Console.ReadLine()); break;
                    case "2": if (fila.Count > 0) fila.Dequeue(); else Console.WriteLine("Fila vazia"); Console.ReadKey(); break;
                    case "3": foreach (var item in fila) Console.WriteLine(item); Console.ReadKey(); break;
                    case "4": return;
                    default: Console.WriteLine("Opção inválida"); Console.ReadKey(); break;
                }
            }
        }
    }

    public static class Pilha
    {
        static Stack<string> pilha = new();

        public static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- MENU PILHA ---");
                Console.WriteLine("1. Inserir elemento");
                Console.WriteLine("2. Remover elemento");
                Console.WriteLine("3. Exibir todos");
                Console.WriteLine("4. Voltar");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": Console.Write("Valor: "); pilha.Push(Console.ReadLine()); break;
                    case "2": if (pilha.Count > 0) pilha.Pop(); else Console.WriteLine("Pilha vazia"); Console.ReadKey(); break;
                    case "3": foreach (var item in pilha) Console.WriteLine(item); Console.ReadKey(); break;
                    case "4": return;
                    default: Console.WriteLine("Opção inválida"); Console.ReadKey(); break;
                }
            }
        }
    }

    public static class Pesquisa
    {
        static List<int> dados = new();

        public static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- MENU PESQUISA ---");
                Console.WriteLine("1. Inserir elemento");
                Console.WriteLine("2. Remover elemento");
                Console.WriteLine("3. Exibir todos os elementos");
                Console.WriteLine("4. Buscar elemento (Busca Linear)");
                Console.WriteLine("5. Voltar");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Valor a inserir: ");
                        dados.Add(int.Parse(Console.ReadLine()));
                        break;
                    case "2":
                        Console.Write("Valor a remover: ");
                        int valorRemover = int.Parse(Console.ReadLine());
                        if (dados.Remove(valorRemover))
                            Console.WriteLine("Removido com sucesso.");
                        else
                            Console.WriteLine("Valor não encontrado.");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Elementos:");
                        foreach (var item in dados)
                            Console.WriteLine(item);
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Write("Valor a buscar: ");
                        int alvo = int.Parse(Console.ReadLine());
                        int posicao = BuscaLinear(alvo);
                        if (posicao != -1)
                            Console.WriteLine($"Encontrado na posição {posicao}.");
                        else
                            Console.WriteLine("Valor não encontrado.");
                        Console.ReadKey();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static int BuscaLinear(int valor)
        {
            for (int i = 0; i < dados.Count; i++)
            {
                if (dados[i] == valor)
                    return i;
            }
            return -1;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeClientes
{
    class Program
    {
        [System.Serializable]

        struct Cliente
        {
            public string nome;
            public string email;
            public string cpf;

        }

        static List<Cliente> clientes = new List<Cliente>();

        enum Menu { Adicionar = 1, Listagem , Remover, Sair }
        static void Main(string[] args)
        {
            bool escolheuSair = false;

            while (!escolheuSair) 
            { 
            Console.WriteLine("Sistema de Clientes - Bem Vindos");
            Console.WriteLine("1-Listagem\n2-Adicionar\n3-Remover\n4-Sair");
            int intOp = int.Parse(Console.ReadLine());
            Menu opcao = (Menu)intOp;

                switch (opcao)
                {
                    case Menu.Adicionar:
                        Adicionar();
                        break;
                    case Menu.Listagem:
                        Listagem();
                        break;
                    case Menu.Remover:
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }
                Console.Clear();
            }
        }

        static void Adicionar()
        {
            Cliente cliente = new Cliente();
            Console.WriteLine("Cadastro de Cliente: ");
            Console.WriteLine("Nome do Cliente: ");
            cliente.nome = Console.ReadLine();
            Console.WriteLine("Email do Cliente: ");
            cliente.email = Console.ReadLine();
            Console.WriteLine("CPF do Cliente: ");
            cliente.cpf = Console.ReadLine();

            clientes.Add(cliente);
            
            Console.WriteLine("Cadastro Concluído! Enter para sair!");
            Console.ReadLine();
        }

        static void Listagem()
        {
            if(clientes.Count > 0)
            {
                Console.WriteLine("Lista de Clientes: ");
                int i = 0;

                foreach (Cliente cliente in clientes)
                {
                    Console.WriteLine($"ID: {i} ");
                    Console.WriteLine($"Nome: {cliente.nome} ");
                    Console.WriteLine($"Email: {cliente.email} ");
                    Console.WriteLine($"CPF: {cliente.cpf} ");
                    Console.WriteLine("==============================");
                    i++;
                }
            } else
            {
                Console.WriteLine("Nenhum cliente cadastrado!");
            }

            Console.WriteLine("Aperte Enter para sair!");
            Console.ReadLine();
        }
    }
}

using EsteticaOliviaMaria.entidades;
using System;
using EsteticaOliviaMaria.entidades.Enum;


namespace EsteticaOliviaMaria
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Oque deseja fazer agora:");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1 - Cadastrar Cliente");
            Console.WriteLine("2 - Cadastrar Funcionario");
            Console.WriteLine("3 - Cadastrar Serviço");
            Console.WriteLine("4 - Agendar Serviço");
            Console.WriteLine("5 - Consultar Agenda");
            Console.WriteLine("6 - Consultar Salario/Comissao Funcionario");
            Console.WriteLine("--------------------------------------------");
            int Cod = int.Parse(Console.ReadLine());

            if (Cod < 1 && Cod > 6)
            {
                Console.WriteLine("Codigo invalido");
            }

            else if (Cod == 1)
            {
                Console.Write("Digite Nome do cliente: ");
                String NomeCliente = Console.ReadLine();
                Console.Write("Nascimento: ");
                DateTime Nascimento = DateTime.Parse(Console.ReadLine());
                Console.Write("Identidade: ");
                Double Identidade = Double.Parse(Console.ReadLine());
                Console.Write("CPF: ");
                Double CPF = Double.Parse(Console.ReadLine());
                Console.Write("Telefone: ");
                String Telefone = Console.ReadLine();
                Console.WriteLine("Endereço: ");
                String Endereco = Console.ReadLine();

                Cliente cliente = new Cliente(NomeCliente,Nascimento,Identidade,CPF,Endereco,Telefone);
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Cliente Cadastrado Com Sucesso!!");
                Console.WriteLine("----------------------------------------------");


            }

            else if (Cod == 2)
            {
                Console.Write("Digite Nome do Funcionario: ");
                String NomeFunc = Console.ReadLine();
                Console.Write("Nascimento: ");
                DateTime NascimentoFunc = DateTime.Parse(Console.ReadLine());
                Console.Write("Salario:  ");
                Double SalarioFunc = Double.Parse(Console.ReadLine());

                Console.Write("Profissao ");
                Profissao ProfissaoFunc = Enum.Parse<Profissao>(Console.ReadLine());
            

                Funcionario funcionario  = new Funcionario(NomeFunc,NascimentoFunc,ProfissaoFunc,SalarioFunc);
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Funcionario Cadastrado Com Sucesso!!");
                Console.WriteLine("----------------------------------------------");




            }
            






        }
    }
}

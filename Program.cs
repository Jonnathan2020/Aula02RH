using System;
using Aula02RH.Models;
using Aula02RH.Models.Enuns;

namespace Aula02RH
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Funcionario func = new Funcionario();

            func.Id = 23;
            func.Nome = "Josefino";
            func.CPF = "1234567890";
            func.DataAdmissao = DateTime.Parse("01/01/2023");
            func.Salario= 2000.00M;
            func.TipoFuncionario = Models.Enuns.TipoFuncionarioEnum.CLT;

            string mensagem = func.ExibirPeriodoExperiencia();
            Console.WriteLine("-----------------------------");
            Console.WriteLine(mensagem);
            Console.WriteLine("-----------------------------");
            */

            Funcionario func = new Funcionario();

            Console.WriteLine("Digite o Id do Funcionário: ");
            func.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do Funcionário: ");
            func.Nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF: ");
            func.CPF = Console.ReadLine();
            
            Console.WriteLine("Digite a data de admissão: ");
            func.DataAdmissao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Salário: ");
            func.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Escolha o tipo de funcionário (1 - CLT / 2 - Aprendiz): ");
            int opcao = int.Parse(Console.ReadLine());

            func.TipoFuncionario = (opcao == 1)? TipoFuncionarioEnum.CLT : TipoFuncionarioEnum.Aprendiz;

            func.ReajustarSalario();
            decimal valorDescontoVT = func.CalcularDescontoVT(6);

            Console.WriteLine("----------------------------------");
            Console.WriteLine($"O salário reajustado é {func.Salario}.\n"); 
            Console.WriteLine($"O desconto do VT é {valorDescontoVT}. \n");
            Console.WriteLine("----------------------------------");
             

        }
    }
}
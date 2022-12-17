using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //isaque dos Santos Antonio ADS RA = 6322109

            // faça um programa que leia dois valores e mostre tres menssagens a seguir....

            //‘Números iguais’, caso os números sejam iguais 
            //‘Primeiro é maior’, caso o primeiro seja maior que o segundo; 
            //‘Segundo maior’, caso o segundo seja maior que o primeiro

            //double A, B;


            //Console.WriteLine (" digite o valor de A");
            //A = double.Parse (Console.ReadLine());

            //Console.WriteLine("digite o valor de B");
            //B = double.Parse (Console.ReadLine());


            //if (A > B)

            //{
            //    Console.WriteLine("o primeiro e maior");
            //}
            //else if (A < B)

            //{
            //    Console.WriteLine("o segundo e maior");

            //}
            //else 

            //{ Console.WriteLine("os dois sao iguais");
            //}

            //Console.ReadKey();

            // //.............EXERCICIO 2...........

            //Faça um programa que leia uma data no formato ddmmaaaa, mostrar se a data é válida ou não.

            //  int dia, mes, ano;

            //  Console.WriteLine(" vamos verificar, se data no formato ddmmaaaa é valida");

            //  Console.Write("insira um dia: ");
            //dia  = Convert.ToInt32(Console.ReadLine());


            //  Console.Write(" insira um mês: ");
            //  mes = Convert.ToInt32(Console.ReadLine());


            //  Console.Write("insira um ano: ");
            //  ano = Convert.ToInt32(Console.ReadLine());

            //  if ((dia > 31) || (dia < 1) || (mes > 12) || (mes < 1))
            //  {

            //      Console.WriteLine("Dia ou mês invalidos, por favor, insira uma data válida");
            //  }
            //  else
            //  {

            //      Console.Write("Sua data é válida: " + dia + "." + mes + "." + ano + ". Obrigado");
            //  }

            //  Console.ReadKey();

            //............................ EXERCICIO 3..................

            //Faça um programa que receba o código correspondente ao cargo de um funcionário e seu salário atual. O programa deverá calcular o aumento e mostrar o cargo, o aumento e o novo salário. Os cargos e o percentual de aumento estão na tabela a seguir

            //Código	Cargo	Percentual de aumento
            // 1   Secretário  35 %
            // 2   Caixa   20 %
            //3   Gerente 15 %

            //int c;
            //double salario, reajuste, novosalario;

            //Console.WriteLine("Programa de Reajuste Salarial");

            //Console.Write("\nDigite um número de acordo com o cargo do funcionário: \n\n1 - Secretário \n2 - Caixa \n3 - Gerente \n-> ");

            //c = Convert.ToInt32(Console.ReadLine());

            //Console.Write("\nDigite o salário desse funcionário: R$");
            //salario = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("\n");

            //if (c == 1) //Reajuste de 35% - Cargo Secretario
            //{
            //    reajuste = (salario * 0.35);
            //    novosalario = reajuste + salario;

            //    Console.WriteLine("\nReajuste salarial de 35% para o cargo de Secretário: " +
            //        "\n\nSalário sem reajuste: R$" + salario
            //        + "\nSalário com reajuste: R$" + novosalario
            //        + "\n\nAumento de R$: " + reajuste);
            //}

            //else if (c == 2) //Reajuste de 20% - Cargo Caixa
            //{
            //    reajuste = (salario * 0.20);
            //    novosalario = reajuste + salario;

            //    Console.WriteLine("\nReajuste salarial de 20% para o cargo de Caixa: " +
            //        "\n\nSalário sem reajuste: R$" + salario
            //        + "\nSalário com reajuste: R$" + novosalario 
            //        + "\n\nAumento de R$: " + reajuste);
            //}

            //else if (c == 3) //Reajuste de 15% para o cargo de gerente
            //{
            //    reajuste = (salario * 0.15);
            //    novosalario = reajuste + salario;

            //    Console.WriteLine("\nReajuste salarial de 15% para o cargo de Gerente: " +
            //        "\n\nSalário sem reajuste: R$" + salario
            //        + "\nSalário com reajuste: R$" + novosalario
            //        + "\n\nAumento de R$: " + reajuste);
            //}

            //else
            //{
            //    Console.WriteLine("\nPor favor, insira um valor válido nos cargos.1,2 ou 3 ");
            //    //Mensagem de erro se o usuario nao digitar os numeros referente aos cargos
            //}
            //Console.ReadKey();
        }
    }
}

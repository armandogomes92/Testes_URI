using System;
using System.Collections.Generic;
using System.Text;

namespace Testes_URI
{
    class SalarioBonus
    {


//Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês(em dinheiro). Sabendo que este vendedor
//ganha 15% de comissão sobre suas vendas efetuadas, informar o total a receber no final do mês, com duas casas decimais.

//Entrada
//O arquivo de entrada contém um texto (primeiro nome do vendedor) e 2 valores de dupla precisão(double) com duas casas decimais, representando o
//salário fixo do vendedor e montante total das vendas efetuadas por este vendedor, respectivamente.
//EX: nome = João, fixo = 500.00, vendas = 1230.30

//Saída
//Imprima o total que o funcionário deverá receber, conforme exemplo fornecido.
//EX: TOTAL = R$ 684.54
        static void Main(string[] args)
        {

            string nome = Console.ReadLine();
            double fixo = Double.Parse(Console.ReadLine());
            double vendas = Double.Parse(Console.ReadLine());
            double salario = fixo + (15 * vendas) / 100;

            Console.WriteLine("TOTAL = R$ " + salario.ToString("F2"));
        }
    }
}

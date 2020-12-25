using System;
using System.Collections.Generic;
using System.Text;

namespace Testes_URI
{
    class Salario
    {
//Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse
//funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

//Entrada
//O arquivo de entrada contém 2 números inteiros e 1 número com duas casas decimais, representando o número, quantidade de horas
//trabalhadas e o valor que o funcionário recebe por hora trabalhada, respectivamente.
//EX: numero = 25, horas = 100, valor = 5.50

//Saída
//Imprima o número e o salário do funcionário, conforme exemplo fornecido, com um espaço em branco antes e depois da igualdade.
//No caso do salário, também deve haver um espaço em branco após o $.
        static void Main(string[] args)
        {

            int numero = Int32.Parse(Console.ReadLine());
            int horas = Int32.Parse(Console.ReadLine());
            double valor = Double.Parse(Console.ReadLine());
            double salario = valor * horas;
            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));

        }
    }
}

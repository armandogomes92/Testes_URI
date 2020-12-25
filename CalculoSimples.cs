using System;
using System.Collections.Generic;
using System.Text;

namespace Testes_URI
{
    class CalculoSimples
    {
//Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2,
//o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.

//Entrada
//O arquivo de entrada contém duas linhas de dados.Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.
// EX: texto = 12 1 5.30, texto2 = 16 2 5.10

//Saída
//A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois pontos e um espaço após o "R$". 
//O valor deverá ser apresentado com 2 casas após o ponto.
//EX: VALOR A PAGAR: R$ 15.50
        static void CalcSimples(string[] args)
        {

            string[] texto = Console.ReadLine().Split(' ');
            string[] texto2 = Console.ReadLine().Split(' ');
            int n1 = int.Parse(texto[0]), n2 = int.Parse(texto[1]);
            double n3 = double.Parse(texto[2]);
            int n4 = int.Parse(texto2[0]), n5 = int.Parse(texto2[1]);
            double n6 = double.Parse(texto2[2]);

            double total = (n2 * n3) + (n5 * n6);
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));
        }
    }
}

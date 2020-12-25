using System;
using System.Collections.Generic;
using System.Text;

namespace Testes_URI
{
    class ProdutoSimples
    {
//Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores e atribua esta operação à variável PROD.
//A seguir mostre a variável PROD com mensagem correspondente.

//Entrada
//O arquivo de entrada contém 2 valores inteiros.
//EX: a = 3, b = 9

//Saída
//Imprima a mensagem "PROD" e a variável PROD conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade.
//Não esqueça de imprimir o fim de linha após o produto, caso contrário seu programa apresentará a mensagem: “Presentation Error”.
//EX: PROD = 27

        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int prod = a * b;

            Console.WriteLine("PROD = " + prod);

        }
    }
}

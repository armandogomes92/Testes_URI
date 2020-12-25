using System;
using System.Collections.Generic;
using System.Text;

namespace Testes_URI
{
    class Diferenca
    {
//Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: 
//DIFERENCA = (A * B - C * D).

//Entrada
//O arquivo de entrada contém 4 valores inteiros.
//EX: a = 5, b = 6, c = 7, d = 8

//Saída
//Imprima a mensagem DIFERENCA com todas as letras maiúsculas, conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade.
//EX: DIFERENCA = -26
        static void CalcDiferenca(string[] args)
        {

            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
            int d = Int32.Parse(Console.ReadLine());

            int diferenca = a * b - c * d;

            Console.WriteLine("DIFERENCA = " + diferenca);
        }
    }
}

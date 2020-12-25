using System;
using System.Collections.Generic;
using System.Text;

namespace Testes_URI
{
    class OMaior
    {
//Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. Utilize a fórmula: (a+b+abs(a-b))/2
//Entrada
//O arquivo de entrada contém três valores inteiros.
//EX: a = 7, b = 14, c = 106
//Saída
//Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".
//EX: 106 eh o maior
        public static void Maior(string[] args)
        {

            string linha = Console.ReadLine();
            String[] v = linha.Split(' ');

            int a = int.Parse(v[0]);
            int b = int.Parse(v[1]);
            int c = int.Parse(v[2]);

            int MaiorAB = 0;

            MaiorAB = (a + b + Math.Abs(a - b)) / 2;

            if (MaiorAB > c)
            {
                Console.WriteLine($"{MaiorAB} eh o maior");
            }
            else
            {
                Console.WriteLine($"{c} eh o maior");
            }

        }
    }
}

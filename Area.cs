using System;
using System.Collections.Generic;
using System.Text;

namespace Testes_URI
{
    class Area
    {
//Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C.Em seguida, calcule e mostre:

//a) a área do triângulo retângulo que tem A por base e C por altura.
//b) a área do círculo de raio C. (pi = 3.14159)
//c) a área do trapézio que tem A e B por bases e C por altura.
//d) a área do quadrado que tem lado B.
//e) a área do retângulo que tem lados A e B.

//Entrada
//O arquivo de entrada contém três valores com um dígito após o ponto decimal.
//EX: texto = 3.0 4.0 5.2

//Saída
//O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas descritas acima, sempre com mensagem 
//correspondente e um espaço entre os dois pontos e o valor. O valor calculado deve ser apresentado com 3 dígitos após o ponto decimal.
//EX: 
//TRIANGULO: 7.800
//CIRCULO: 84.949
//TRAPEZIO: 18.200
//QUADRADO: 16.000
//RETANGULO: 12.000
        static void CArea(string[] args)
        {
            string[] texto = Console.ReadLine().Split(' ');
            double a = double.Parse(texto[0]), b = double.Parse(texto[1]), c = double.Parse(texto[2]);
            double pi = 3.14159;

            double triangulo = (c * a) / 2;
            double circulo = pi * Math.Pow(c, 2);
            double trapezio = ((a + b) / 2) * c;
            double quadrado = b * b;
            double retangulo = a * b;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3"));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3"));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3"));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3"));
        }
    }
}

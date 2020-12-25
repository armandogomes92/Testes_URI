using System;
using System.Collections.Generic;
using System.Text;

namespace Testes_URI
{
    class AreaDoCirculo
    {
//A fórmula para calcular a área de uma circunferência é: area = π . raio2. Considerando para este problema que π = 3.14159:
//- Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π.

//Entrada
//A entrada contém um valor de ponto flutuante (dupla precisão), no caso, a variável raio.
//EX: 2.00

//Saída
//Apresentar a mensagem "A=" seguido pelo valor da variável area, conforme exemplo abaixo, com 4 casas após o ponto decimal.
//Utilize variáveis de dupla precisão (double). Como todos os problemas, não esqueça de imprimir o fim de linha após o resultado,
//caso contrário, você receberá "Presentation Error".
//EX: A=12.5664

        public static void AreaCirculo(string[] args)
        {
            double n = 3.14159;
            double raio = double.Parse(Console.ReadLine());
            double area = n * Math.Pow(raio, 2);
            area = Math.Round(area, 4);
            Console.WriteLine("A=" + area.ToString("F4"));
        }
    }
}

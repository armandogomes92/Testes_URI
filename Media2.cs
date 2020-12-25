using System;
using System.Collections.Generic;
using System.Text;

namespace Testes_URI
{
    class Media2
    {
//Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. A seguir, calcule a média do aluno, sabendo que a nota A tem peso
//2, a nota B tem peso 3 e a nota C tem peso 5. Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

//Entrada
//O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão (double).
//EX: a = 5.0, b = 6.0, c = 7.0

//Saída
//Imprima a mensagem "MEDIA" e a média do aluno conforme exemplo abaixo, com 1 dígito após o ponto decimal e com um espaço em branco antes e depois
//da igualdade. Assim como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".
//EX: MEDIA = 6.3

        static void CalcMedia2(string[] args)
        {

            double a = double.Parse(Console.ReadLine());
            double pa = 2;
            double b = double.Parse(Console.ReadLine());
            double pb = 3;
            double c = double.Parse(Console.ReadLine());
            double pc = 5;

            double media = ((a * pa) + (b * pb) + (c * pc)) / (pa + pb + pc);

            Console.WriteLine("MEDIA = " + media.ToString("F1"));
        }
    }
}

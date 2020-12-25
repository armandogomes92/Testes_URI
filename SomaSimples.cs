﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Testes_URI
{
//Leia dois valores inteiros, no caso para variáveis A e B. A seguir, calcule a soma entre elas e atribua à variável SOMA.
//A seguir escrever o valor desta variável.

//Entrada
//O arquivo de entrada contém 2 valores inteiros.
//EX: A = 30, B = 10

//Saída
//Imprima a mensagem "SOMA" com todas as letras maiúsculas, com um espaço em branco antes e depois da igualdade seguido pelo valor correspondente à
//soma de A e B. Como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".
//EX: SOMA = 40
    class SomaSimples
    {
        public static void Somar(string[] args)
        {

            int A = Int32.Parse(Console.ReadLine());
            int B = Int32.Parse(Console.ReadLine());
            int SOMA = A + B;

            Console.WriteLine("SOMA = " + SOMA);

        }
    }
}

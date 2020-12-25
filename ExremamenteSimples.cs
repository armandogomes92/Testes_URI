using System;
using System.Collections.Generic;
using System.Text;

namespace Testes_URI
{
    class ExremamenteSimples
    {
//Leia 2 valores inteiros e armazene-os nas variáveis A e B. Efetue a soma de A e B atribuindo o seu resultado na variável X. Imprima X conforme exemplo apresentado abaixo. Não apresente mensagem alguma além daquilo que está sendo especificado e não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".

//Entrada
//A entrada contém 2 valores inteiros.
//EX: A = 10, B = 9

//Saída
//Imprima a mensagem "X = " (letra X maiúscula) seguido pelo valor da variável X e pelo final de linha.
//Cuide para que tenha um espaço antes e depois do sinal de igualdade, conforme o exemplo abaixo.
//EX: X = 19

        static void Main(string[] args)
        {

            int A, B, X;
            A = Int32.Parse(Console.ReadLine());
            B = Int32.Parse(Console.ReadLine());
            X = A + B;
            Console.WriteLine("X = " + X);

        }
    }
}

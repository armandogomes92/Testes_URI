using System;
using System.Collections.Generic;
using System.Text;

namespace Testes_URI
{
    class OConsumo
    {
//Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida(em Km) e o total de combustível gasto(em litros). 

//Entrada
//O arquivo de entrada contém dois valores: um valor inteiro X representando a distância total percorrida(em Km), e um valor real Y representando o
//total de combustível gasto, com um dígito após o ponto decimal. 
//EX: x = 500, y = 35.0

//Saída 
//Apresente o valor que representa o consumo médio do automóvel com 3 casas após a vírgula, seguido da mensagem "km/l".
//EX: 14.286 km/l
        static void Consumo(string[] args)
        {

            int x = Int32.Parse(Console.ReadLine());
            double y = Double.Parse(Console.ReadLine());

            double z = x / y;

            Console.WriteLine(z.ToString("F3") + " km/l");

        }
    }
}

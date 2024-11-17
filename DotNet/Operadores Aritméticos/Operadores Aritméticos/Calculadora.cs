using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Aritméticos
{
    // Calculadora simples 
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"A soma de {x} + {y} = {x + y}\n");
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"A subtração de {x} - {y} = {x - y}\n");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"A multiplicação de {x} * {y} = {x * y} \n");
        }
        public void Dividir(int x, int y)
        {
            Console.WriteLine($"A divisão de {x} / {y} = {x / y}\n");
        }
    }
}

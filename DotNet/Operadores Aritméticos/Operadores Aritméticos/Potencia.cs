using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Aritméticos
{
    public class Potencia
    {

        public void Potenciacao(int x, int y)
        {
            // Buscamos o metodo Pow da classe Math, que realiza o calculo de potencia
            double pot = Math.Pow(x, y);
            Console.WriteLine($"O resultado da potencia de {x} e {y} = {pot}\n");
        }

        // Para calcular o seno, cosseno e a tangente podemos importar os calculos da biblioteca Math
        //Math.Round é utilizado na formatação da variavel
        public void Seno(double angulo)
        {
            // Realizando o calculo de seno, utilizando a classe math para buscar o valor de Pi e o calculo de seno
            double radio = angulo * Math.PI / 180;
            double seno = Math.Sin(radio);
            Console.WriteLine($"Seno = {Math.Round(seno, 4)}\n");

        }
        public void Cosseno(double angulo)
        {
            // Realizando o calculo do cosseno, utilizando a classe math para buscar o valor de Pi e o calculo do cosseno
            double radio = angulo * Math.PI / 180;
            double cosseno = Math.Cos(radio);
            Console.WriteLine($"Seno = {Math.Round(cosseno, 4)}\n");

        }

        // Para calcular a raiz quadrada de um número podemos utilizar Math.Sqrt
        public void Raiz(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz = {raiz}\n");
        }

    }
}

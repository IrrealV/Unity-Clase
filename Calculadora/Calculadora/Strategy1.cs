using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Strategy1 : IStrategy
    {

        public void algorithm()
        {
            Console.Write("Ejecutar estrategia 1");
        }
    }
    public class Strategy2 : IStrategy
    {

        public void algorithm()
        {
            Console.Write("Ejecutar estrategia 2");
        }
    }

    public class Strategy3 : IStrategy
    {

        public void algorithm()
        {
            Console.Write("Ejecutar estrategia 3");
        }
    }

    public class Calculadora : ICalculable
    {
        public void sum(float value1, float value2)
        {
            float result = value1 + value2;
            Console.Write($"{value1} + {value2} = {result}");
        }

        public void sustract(float value1, float value2)
        {
            float result = value1 - value2;
            Console.Write($"{value1} - {value2} = {result}");
        }

        public void multiply(float value1, float value2)
        {
            float result = value1 * value2;
            Console.Write($"{value1} * {value2} = {result}");
        }

        public void divide(float value1, float value2)
        {
            float result = value1 / value2;
            Console.Write($"{value1} / {value2} = {result}");
        }
    }
}

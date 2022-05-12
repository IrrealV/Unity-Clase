using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public interface IStrategy
    {
        void algorithm();
    }

    public interface ICalculable
    {
        void sum(float value1, float value2);
    }
}

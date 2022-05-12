using System;

namespace Calculadora
{
    class Program
    {
		public static void Main(string[] args)
		{
			//strategy();
			calculable();
		}

		public static void strategy()
		{
			IStrategy str1 = new Strategy1();
			Context ctx = new Context(str1);

			ctx.ApplyStrategy();

			ctx.SetStrategy(new Strategy2());
			ctx.ApplyStrategy();

			ctx.SetStrategy(new Strategy3());
			ctx.ApplyStrategy();
		}

		public static void calculable()
		{
			ICalculable cal1 = new Calculadora();
			ContextCalculate ctxCalc = new ContextCalculate(cal1);

			ctxCalc.SetCalculable(cal1);
			ctxCalc.ApplyCalculable(1, 4);
		}
	}
}

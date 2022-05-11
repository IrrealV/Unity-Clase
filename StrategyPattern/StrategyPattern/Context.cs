using System;


namespace StrategyPatternRiderTest
{
	public class Context
	{
		private IStrategy strategy;

		public Context(IStrategy strategy) // <- le pasamos el tipo de interfaz
		{   // Constructor
			this.strategy = strategy;
		}

		public void SetStrategy(IStrategy strategy)
		{
			this.strategy = strategy;
		}

		public void ApplyStrategy()
		{
			Console.WriteLine("Invocamos la estrategia en algún punto del código");
			strategy.algorithm();
		}
	}
}
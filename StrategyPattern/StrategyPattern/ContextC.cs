using System;


namespace StrategyPatternRiderTest
{
	public class ContextCalculate
	{
		private ICalculable calculable;

		public ContextCalculate(ICalculable calculable)
		{
			this.calculable = calculable;
		}

		public void SetCalculable(ICalculable calculable)
		{
			this.calculable = calculable;
		}

		public void ApplyCalculable(float value1, float value2)
		{
			Console.WriteLine("Invocamos calculable");
			calculable.sum(value1, value2);
		}
	}
}
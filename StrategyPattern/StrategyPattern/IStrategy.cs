


namespace StrategyPatternRiderTest
{
	public interface IStrategy
	{   // la interfaz tiene un metodo que todas las clases que implementen
		// IStrategy deben tener
		void algorithm();
	}

	public interface ICalculable
	{
		void sum(float value1, float value2);
	}
}
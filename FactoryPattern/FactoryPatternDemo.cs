using System;

namespace FactoryPattern
{
	class FactoryPatternDemo
	{
		static void Main(string[] args)
		{
			PizzaFactory pizzaFactory = new NYPizzaFactory();

			Pizza pizza = pizzaFactory.CreatePizza("Margarita");

			pizza.Prepare();
			pizza.Bake();
			pizza.Cut();
			pizza.Box();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
	class ChicagoPizzaFactory : PizzaFactory
	{
		public override Pizza CreatePizza(string type)
		{
			Pizza pizza;

			type = type.ToLower();

			switch (type)
			{
				case "pepperoni":
					pizza = new ChicagoPepperoni(type);
					break;
				case "margarita":
					pizza = new ChicagoMargarita(type);
					break;
				default:
					throw new ArgumentException("Illegal type");
			}

			return pizza;
		}
	}
}

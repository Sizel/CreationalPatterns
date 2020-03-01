using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
	class NYPizzaFactory : PizzaFactory
	{
		public override Pizza CreatePizza(string type)
		{
			Pizza pizza;

			type = type.ToLower();

			switch (type)
			{
				case "pepperoni":
					pizza = new NYPepperoni(type);
					break;
				case "margarita":
					pizza = new NYMargarita(type);
					break;
				default:
					throw new ArgumentException("Illegal type");
			}

			return pizza;
		}
	}
}

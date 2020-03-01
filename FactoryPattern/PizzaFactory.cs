using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
	abstract class PizzaFactory
	{
		public abstract Pizza CreatePizza(string type);
	}
}

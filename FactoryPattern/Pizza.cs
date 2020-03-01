using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
	public abstract class Pizza
	{
		public string Name { get; set; }
		public Pizza(string name)
		{
			Name = name;
		}

		public abstract void Prepare();

		public abstract void Bake();

		public abstract void Cut();

		public abstract void Box();

	}
}

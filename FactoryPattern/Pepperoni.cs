using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
	class Pepperoni : Pizza
	{
		public Pepperoni(string name) : base(name) { }
		public override void Bake()
		{
			Console.WriteLine("Baking pepperoni...");
		}

		public override void Box()
		{
			Console.WriteLine("Boxing pepperoni...");
		}

		public override void Cut()
		{
			Console.WriteLine("Cutting pepperoni...");
		}

		public override void Prepare()
		{
			Console.WriteLine("Preparing pepperoni...");
		}
	}
}

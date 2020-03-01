using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
	class Margarita : Pizza
	{
		public Margarita(string name) : base(name) { }
		public override void Bake()
		{
			Console.WriteLine("Baking margarita...");
		}

		public override void Box()
		{
			Console.WriteLine("Boxing margarita...");
		}

		public override void Cut()
		{
			Console.WriteLine("Cutting margarita...");
		}

		public override void Prepare()
		{
			Console.WriteLine("Preparing margarita...");
		}
	}
}

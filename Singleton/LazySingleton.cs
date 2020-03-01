using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
	class LazySingleton
	{
		private static readonly Lazy<LazySingleton> lazy = new Lazy<LazySingleton>(() => new LazySingleton(), true);

		private LazySingleton() { }

		public static LazySingleton Instance { get { return lazy.Value; } }
	}
}
